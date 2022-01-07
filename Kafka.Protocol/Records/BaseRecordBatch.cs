﻿using System;
using System.IO;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;
using Kafka.Protocol.Cryptography;

namespace Kafka.Protocol.Records
{
    public abstract class BaseRecordBatch : ISerialize
    {
        public Int64 BaseOffset { get; set; } = Int64.Default;
        public Int32 BatchLength { get; set; } = Int32.Default;
        public Int32 PartitionLeaderEpoch { get; set; } = Int32.Default;
        public Int8 Magic { get; set; } = Int8.Default;
        public Int32 Crc { get; private set; } = Int32.Default;
        public Int16 Attributes { get; set; } = Int16.Default;
        public Int32 LastOffsetDelta { get; set; } = Int32.Default;
        public Int64 FirstTimestamp { get; set; } = Int64.Default;
        public Int64 MaxTimestamp { get; set; } = Int64.Default;
        public Int64 ProducerId { get; set; } = Int64.Default;
        public Int16 ProducerEpoch { get; set; } = Int16.Default;
        public Int32 BaseSequence { get; set; } = Int32.Default;
        protected NullableArray<Record> Records { get; set; }

        public RecordBatch.CompressionType Compression
        {
            get => (RecordBatch.CompressionType)Attributes.GetValueOfBitRange(0, 2);
            set => Attributes =
                Attributes.SetBitRangeValue(0, 2, (ushort)value);
        }

        public RecordBatch.Timestamp TimestampType
        {
            get => (RecordBatch.Timestamp)Convert.ToByte(
                Attributes.IsBitSet(3));
            set => Attributes.SetBit(3, Convert.ToBoolean((byte)value));
        }

        public bool IsTransactional
        {
            get => Attributes.IsBitSet(4);
            set => Attributes = Attributes.SetBit(4, value);
        }

        public bool IsControlBatch
        {
            get => Attributes.IsBitSet(5);
            set => Attributes = Attributes.SetBit(5, value);
        }

        protected static async ValueTask<T> FromReaderAsync<T>(
            T recordBatch,
            PipeReader reader,
            bool asCompact,
            CancellationToken cancellationToken = default)
            where T : BaseRecordBatch
        {
            var size = asCompact
                ? (int)(await UVarInt
                    .FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false)).Value - 1
                : (int)await Int32.FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            if (size < 0)
            {
                return recordBatch;
            }

            recordBatch.BaseOffset = await Int64.FromReaderAsync(reader, asCompact,
                    cancellationToken)
                .ConfigureAwait(false);
            recordBatch.BatchLength = await Int32.FromReaderAsync(reader, asCompact,
                    cancellationToken)
                .ConfigureAwait(false);
            recordBatch.PartitionLeaderEpoch = await Int32
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.Magic = await Int8
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.Crc = await Int32
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.Attributes = await Int16.FromReaderAsync(reader, asCompact,
                    cancellationToken)
                .ConfigureAwait(false);
            recordBatch.LastOffsetDelta = await Int32
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.FirstTimestamp = await Int64
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.MaxTimestamp = await Int64
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.ProducerId = await Int64.FromReaderAsync(reader, asCompact,
                    cancellationToken)
                .ConfigureAwait(false);
            recordBatch.ProducerEpoch = await Int16
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.BaseSequence = await Int32
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            recordBatch.Records = await NullableArray<Record>.FromReaderAsync(
                    reader, asCompact,
                    () => Record.FromReaderAsync(reader, asCompact,
                        cancellationToken), cancellationToken)
                .ConfigureAwait(false);


            await recordBatch.CheckForDataCorruption(asCompact, cancellationToken)
                .ConfigureAwait(false);

            var actualSize = recordBatch.GetSize(asCompact);
            if (size != actualSize)
            {
                throw new CorruptMessageException($"Expected size {size} got {actualSize}");
            }

            return recordBatch;
        }

        private async ValueTask CheckForDataCorruption(
            bool asCompact,
            CancellationToken cancellationToken)
        {
            var bytes = await SerializeCrcData(asCompact, cancellationToken)
                .ConfigureAwait(false);
            var crc = Crc32C.Compute(bytes);
            if (crc != Crc)
            {
                throw new CorruptMessageException(
                    $"Record batch is corrupt. The read data has crc {crc} but the record batch states that crc should be {Crc}");
            }
        }

        public async ValueTask WriteToAsync(
            Stream writer,
            bool asCompact,
            CancellationToken cancellationToken = default)
        {
            var size = GetSize(asCompact);
            if (asCompact)
            {
                UVarInt length = Records.Value == null ? 0 : (uint)size + 1;
                await length.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            }
            else
            {
                Int32 length = Records.Value?.Length ?? -1;
                await length
                    .WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            }

            if (Records.Value != null)
            {
                await BaseOffset
                    .WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await BatchLength
                    .WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await PartitionLeaderEpoch
                    .WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await Magic.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);

                var bytes = await SerializeCrcData(asCompact, cancellationToken)
                    .ConfigureAwait(false);
                Crc = (int)Crc32C.Compute(bytes);

                await Crc.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await Bytes.From(bytes)
                    .WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            }
        }

        public int GetSize(bool asCompact)
        {
            var size = 0;
            if (Records.Value != null)
            {
                size = BaseOffset.GetSize(asCompact) +
                       BatchLength.GetSize(asCompact) +
                       PartitionLeaderEpoch.GetSize(asCompact) +
                       Magic.GetSize(asCompact) +
                       Crc.GetSize(asCompact) +
                       Attributes.GetSize(asCompact) +
                       LastOffsetDelta.GetSize(asCompact) +
                       FirstTimestamp.GetSize(asCompact) +
                       MaxTimestamp.GetSize(asCompact) +
                       ProducerId.GetSize(asCompact) +
                       ProducerEpoch.GetSize(asCompact) +
                       BaseSequence.GetSize(asCompact) +
                       NullableArray<Record>.From(Records)
                           .GetSize(asCompact);
            }

            return (asCompact
                       ? UVarInt.From((uint)size + 1).GetSize(asCompact)
                       : Int32.From(size).GetSize(asCompact)) +
                   size;
        }

        private async ValueTask<byte[]> SerializeCrcData(
            bool asCompact,
            CancellationToken cancellationToken)
        {
            var writer = new MemoryStream();
            await using (writer.ConfigureAwait(false))
            {
                await Attributes.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await LastOffsetDelta.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await FirstTimestamp.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await MaxTimestamp.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await ProducerId.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await ProducerEpoch.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
                await BaseSequence.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);

                // todo: support compression
                await Records.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            }

            return writer.ToArray();
        }
    }
}