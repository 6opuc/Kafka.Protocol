﻿using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol.Records
{
    public class ControlRecordKey : ISerialize
    {
        private Int16 _version = Int16.Default;
        public Int16 Version
        {
            get => _version;
            set
            {
                if (value != Int16.From(0))
                {
                    throw new UnsupportedVersionException($"Version '{value}' is not supported. Supported version is 0");
                }

                _version = value;
            }
        }

        private Int16 _type = Int16.Default;

        public bool IsAbortMarker
        {
            get => _type == Int16.From(0);
            set => _type = Int16.From(value ? (short)0 : (short)1);
        }

        public bool IsCommit
        {
            get => _type == Int16.From(1);
            set => _type = Int16.From(value ? (short)1 : (short)0);
        }

        public void ReadFrom(IKafkaReader reader)
        {
            Version = Int16.From(reader.ReadInt16());
            _type = Int16.From(reader.ReadInt16());
        }

        public async Task WriteToAsync(IKafkaWriter writer, CancellationToken cancellationToken = default)
        {
            await writer.WriteInt16Async(Version.Value, cancellationToken);
            await writer.WriteInt16Async(_type.Value, cancellationToken);
        }
    }
}