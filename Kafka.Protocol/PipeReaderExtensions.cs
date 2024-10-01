﻿using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol
{
    public static class PipeReaderExtensions
    {
        public static async ValueTask<byte[]> ReadAsLittleEndianAsync(
            this PipeReader reader,
            int length,
            CancellationToken cancellationToken = default)
        {
            var bytes = await ReadAsync(reader, length, cancellationToken)
                .ConfigureAwait(false);
            if (BitConverter.IsLittleEndian == false)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static async ValueTask<byte[]> ReadAsBigEndianAsync(
            this PipeReader reader,
            int length,
            CancellationToken cancellationToken = default)
        {
            var bytes = await ReadAsync(reader, length, cancellationToken)
                .ConfigureAwait(false);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }

            return bytes;
        }

        public static async ValueTask<byte[]> ReadAsync(
            this PipeReader reader,
            int length,
            CancellationToken cancellationToken = default)
        {
            if (length <= 0)
            {
                return Array.Empty<byte>();
            }

            var bufferWriter = new ArrayBufferWriter<byte>(length);

            ReadResult result;
            do
            {
                result = await reader.ReadAsync(cancellationToken)
                    .ConfigureAwait(false);
                var buffer = result.Buffer.Slice(
                    0, Math.Min(bufferWriter.FreeCapacity, result.Buffer.Length));
                buffer.CopyTo(bufferWriter.GetSpan());
                bufferWriter.Advance((int)buffer.Length);
                reader.AdvanceTo(buffer.End);

                if (bufferWriter.WrittenCount == length)
                {
                    return bufferWriter.WrittenMemory.ToArray();
                }
            } while (result.HasMoreData());

            if (bufferWriter.WrittenCount == 0)
            {
                reader.Complete();
                throw new OperationCanceledException(cancellationToken);
            }

            var exception = new OperationCanceledException(
                    $"Expected {length} bytes, got {bufferWriter.WrittenCount}",
                    cancellationToken);
            reader.Complete(exception);
            throw exception;
        }
    }
}