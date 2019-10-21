﻿using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol
{
    public class KafkaReader : IKafkaReader
    {
        private readonly PipeReader _reader;

        public KafkaReader(PipeReader reader)
        {
            _reader = reader;
        }

        public async ValueTask<Boolean> ReadBooleanAsync(
            CancellationToken cancellationToken = default)
        {
            return Boolean.From(
                BitConverter.ToBoolean(
                await ReadAsLittleEndianAsync(1, cancellationToken),
                0));
        }

        public async ValueTask<Int8> ReadInt8Async(
            CancellationToken cancellationToken = default)
        {
            return Int8.From(
                Convert.ToSByte(
                await ReadByteAsync(cancellationToken)));
        }

        public async ValueTask<Int16> ReadInt16Async(
            CancellationToken cancellationToken = default)
        {
            return Int16.From(
                BitConverter.ToInt16(
                await ReadAsBigEndianAsync(2, cancellationToken),
                0));
        }

        public async ValueTask<Int32> ReadInt32Async(
            CancellationToken cancellationToken = default)
        {
            return Int32.From(
                BitConverter.ToInt32(
                await ReadAsBigEndianAsync(4, cancellationToken),
                0));
        }

        public async ValueTask<Int64> ReadInt64Async(
            CancellationToken cancellationToken = default)
        {
            return Int64.From(
                BitConverter.ToInt64(
                await ReadAsBigEndianAsync(8, cancellationToken),
                0));
        }

        public async ValueTask<UInt32> ReadUInt32Async(
            CancellationToken cancellationToken = default)
        {
            return UInt32.From(
                BitConverter.ToUInt32(
                await ReadAsBigEndianAsync(4, cancellationToken),
                0));
        }

        public async ValueTask<VarInt> ReadVarIntAsync(
            CancellationToken cancellationToken = default)
        {
            return VarInt.From(
                (int)(await ReadVarLongAsync(cancellationToken)).Value);
        }

        public async ValueTask<VarLong> ReadVarLongAsync(
            CancellationToken cancellationToken = default)
        {
            var more = true;
            ulong value = 0;
            var shift = 0;
            while (more)
            {
                var lowerBits = await ReadByteAsync(cancellationToken);
                more = (lowerBits & 128) != 0;
                value |= (uint)((lowerBits & 0x7f) << shift);
                shift += 7;
            }

            return VarLong.From(
                value.DecodeFromZigZag());
        }

        public async ValueTask<String> ReadStringAsync(
            CancellationToken cancellationToken = default)
        {
            var length = await ReadInt16Async(cancellationToken);
            var bytes = await ReadAsLittleEndianAsync(length.Value, cancellationToken);
            return String.From(
                Encoding.UTF8.GetString(bytes));
        }

        public async ValueTask<String?> ReadNullableStringAsync(
            CancellationToken cancellationToken = default)
        {
            var length = await ReadInt16Async(cancellationToken);
            if (length.Value == -1)
            {
                return null;
            }

            var bytes = await ReadAsLittleEndianAsync(length.Value, cancellationToken);
            return String.From(
                Encoding.UTF8.GetString(bytes));
        }

        public async ValueTask<Bytes> ReadBytesAsync(
            CancellationToken cancellationToken = default)
        {
            var length = await ReadInt32Async(cancellationToken);
            return Bytes.From(
                await ReadAsLittleEndianAsync(length.Value, cancellationToken));
        }

        public async ValueTask<Bytes?> ReadNullableBytesAsync(
            CancellationToken cancellationToken = default)
        {
            var length = await ReadInt32Async(cancellationToken);
            if (length.Value == -1)
            {
                return null;
            }

            return Bytes.From(
                await ReadAsLittleEndianAsync(length.Value, cancellationToken));
        }

        public async ValueTask<T[]> ReadArrayAsync<T>(Func<ValueTask<T>> createItem,
            CancellationToken cancellationToken = default)
            where T : ISerialize
        {
            return await ReadNullableArrayAsync(createItem, cancellationToken) ?? 
                throw new NotSupportedException($"The array cannot be null. Consider changing to {nameof(ReadNullableArrayAsync)}");
        }

        public async ValueTask<T[]?> ReadNullableArrayAsync<T>(Func<ValueTask<T>> createItem, 
            CancellationToken cancellationToken = default) where T : ISerialize
        {
            var length = await ReadInt32Async(cancellationToken);
            if (length.Value == -1)
            {
                return null;
            }

            var result = new T[length.Value];
            for (var i = 0; i < length.Value; i++)
            {
                result[i] = await createItem();
            }

            return result;
        }

        private async ValueTask<byte> ReadByteAsync(CancellationToken cancellationToken = default)
        {
            return (await ReadAsLittleEndianAsync(1, cancellationToken))
                .First();
        }

        private async ValueTask<byte[]> ReadAsLittleEndianAsync(
            int length,
            CancellationToken cancellationToken = default)
        {
            var bytes = await ReadAsync(length, cancellationToken);
            if (BitConverter.IsLittleEndian == false)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        private async ValueTask<byte[]> ReadAsBigEndianAsync(
            int length,
            CancellationToken cancellationToken = default)
        {
            var bytes = await ReadAsync(length, cancellationToken);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        private async ValueTask<byte[]> ReadAsync(
            int length,
            CancellationToken cancellationToken = default)
        {
            ReadResult result;
            do
            {
                result = await _reader.ReadAsync(cancellationToken);
            } while (result.Buffer.Length < length &&
                     result.IsCanceled == false &&
                     result.IsCompleted == false);

            if (result.Buffer.Length < length)
            {
                throw new InvalidOperationException(
                    $"Expected {length} bytes, got {result.Buffer.Length}");
            }
            
            var bytes = result.Buffer.Slice(0, length).ToArray();
            _reader.AdvanceTo(result.Buffer.GetPosition(length));
            return bytes;
        }
    }
}