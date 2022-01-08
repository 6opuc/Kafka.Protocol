﻿using System;
using System.IO;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace Kafka.Protocol
{
    public partial struct Float64
    {
        public int GetSize() => 8;

        public ValueTask WriteToAsync(Stream writer,
            CancellationToken cancellationToken = default) =>
            writer.WriteAsBigEndianAsync(BitConverter.GetBytes(Value),
                cancellationToken);

        public static async ValueTask<Float64> FromReaderAsync(
            PipeReader reader,
            
            CancellationToken cancellationToken = default) =>
            BitConverter.ToDouble(
                await reader.ReadAsBigEndianAsync(8, cancellationToken)
                    .ConfigureAwait(false),
                0);
    }
}