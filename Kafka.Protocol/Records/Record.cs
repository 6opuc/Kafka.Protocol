﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol.Records
{
    public class Record : ISerialize
    {
        public Int8 Attributes { get; set; } = Int8.Default;
        public VarLong TimestampDelta { get; set; } = VarLong.Default;
        public VarInt OffsetDelta { get; set; } = VarInt.Default;
        public byte[]? Key { get; set; }
        public byte[]? Value { get; set; }
        public Header[] Headers { get; set; } = Array.Empty<Header>();

        private int _size = 0;

        internal static async ValueTask<Record> FromReaderAsync(
            PipeReader reader,
            bool asCompact,
            CancellationToken cancellationToken = default)
        {
            var size = await VarInt
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            var record = new Record
            {
                Attributes = await Int8.FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false),
                TimestampDelta = await VarLong.FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false),
                OffsetDelta = await VarInt.FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false),
                _size = size,
            };

            var keyLength = await VarInt.FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            record.Key = keyLength == -1
                ? null
                : await reader.ReadAsync(keyLength, cancellationToken)
                    .ConfigureAwait(false);
            var valueLen = await VarInt.FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            record.Value = valueLen == -1
                ? null
                : await reader.ReadAsync(
                        valueLen,
                        cancellationToken)
                    .ConfigureAwait(false);

            var headerCount = await VarInt
                .FromReaderAsync(reader, asCompact, cancellationToken)
                .ConfigureAwait(false);
            var headers = new List<Header>();
            for (var i = 0; i < headerCount; i++)
            {
                headers.Add(await Header.FromReaderAsync(reader, asCompact, cancellationToken)
                    .ConfigureAwait(false));
            }
            record.Headers = headers.ToArray();
/*
            var actualSize = record.PayloadSize(asCompact);
            if (size != actualSize)
            {
                throw new CorruptMessageException($"Expected size {size} got {actualSize}");
            }*/
            return record;
        }

        public static Record FromStream(
            Stream stream,
            bool asCompact)
        {
            var size = stream.ReadAsVarInt32();
            var record = new Record
            {
                Attributes = (sbyte)stream.ReadByte(),
                TimestampDelta = stream.ReadAsVarInt64(),
                OffsetDelta = stream.ReadAsVarInt32(),
                _size = size,
            };

            var keyLength = stream.ReadAsVarInt32();
            record.Key = keyLength == -1
                ? null
                : stream.ReadBytes(keyLength);
            var valueLen = stream.ReadAsVarInt32();
            record.Value = valueLen == -1
                ? null
                : stream.ReadBytes(valueLen);

            var headerCount = stream.ReadAsVarInt32();
            var headers = new Header[headerCount];
            for (var i = 0; i < headerCount; i++)
            {
                headers[i] = Header.FromStream(stream, asCompact);
            }
            record.Headers = headers;

            return record;
        }

        ValueTask ISerialize.WriteToAsync(Stream writer, bool asCompact, CancellationToken cancellationToken) => WriteToAsync(writer, asCompact, cancellationToken);
        internal async ValueTask WriteToAsync(
            Stream writer,
            bool asCompact,
            CancellationToken cancellationToken = default)
        {
            await VarInt.From(PayloadSize(asCompact)).WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            await Attributes.WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            await TimestampDelta.WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            await OffsetDelta.WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            await VarInt.From(Key?.Length ?? -1).WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            if (Key != null)
            {
                await writer.WriteAsLittleEndianAsync(Key, cancellationToken)
                    .ConfigureAwait(false);
            }
            await VarInt.From(Value?.Length ?? -1).WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            if (Value != null)
            {
                await writer.WriteAsLittleEndianAsync(Value, cancellationToken)
                    .ConfigureAwait(false);
            }

            await VarInt.From(Headers.Length)
                .WriteToAsync(writer, asCompact, cancellationToken)
                .ConfigureAwait(false);
            foreach (var header in Headers)
            {
                await header.WriteToAsync(writer, asCompact, cancellationToken)
                    .ConfigureAwait(false);
            }
        }

        int ISerialize.GetSize(bool asCompact) => GetSize(asCompact);
        internal int GetSize(bool asCompact)
        {
            //var size = PayloadSize(asCompact);
            return VarInt.From(_size).GetSize(asCompact) + _size;
        }

        private int PayloadSize(bool asCompact) =>
            Attributes.GetSize(asCompact) +
            TimestampDelta.GetSize(asCompact) +
            OffsetDelta.GetSize(asCompact) +
            VarInt.From(Key?.Length ?? -1).GetSize(asCompact) +
            (Key?.Length ?? 0) +
            VarInt.From(Value?.Length ?? -1).GetSize(asCompact) +
            (Value?.Length ?? 0) +
            VarInt.From(Headers.Length).GetSize(asCompact) +
            Headers.Sum(header => header.GetSize(asCompact));
    }
}