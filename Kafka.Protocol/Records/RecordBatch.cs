﻿using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol.Records
{
    public class RecordBatch : ISerialize
    {
        public Int64 BaseOffset { get; set; } = Int64.Default;
        public Int32 BatchLength { get; set; } = Int32.Default;
        public Int32 PartitionLeaderEpoch { get; set; } = Int32.Default;
        public Int8 Magic { get; set; } = Int8.Default;
        public Int32 Crc { get; set; } = Int32.Default;
        public Int16 Attributes { get; set; } = Int16.Default;
        public Int32 LastOffsetDelta { get; set; } = Int32.Default;
        public Int64 FirstTimestamp { get; set; } = Int64.Default;
        public Int64 MaxTimestamp { get; set; } = Int64.Default;
        public Int64 ProducerId { get; set; } = Int64.Default;
        public Int16 ProducerEpoch { get; set; } = Int16.Default;
        public Int32 BaseSequence { get; set; } = Int32.Default;
        public Record[]? Records { get; set; } = new Record[0];

        public Compressions Compression => new Compressions(this);

        public class Compressions
        {
            private readonly RecordBatch _recordBatch;

            internal Compressions(RecordBatch recordBatch)
            {
                _recordBatch = recordBatch;
            }

            private ushort Value
            {
                get => _recordBatch.Attributes.GetValueOfBitRange(0, 2);
                set => _recordBatch.Attributes = _recordBatch.Attributes.SetBitRangeValue(0, 2, value);
            }

            public bool None
            {
                get => Value == 0;
                set
                {
                    if (value)
                    {
                        Value = 0;
                    }
                }
            }

            public bool Gzip
            {
                get => Value == 1;
                set
                {
                    if (value)
                    {
                        Value = 1;
                    }
                }
            }

            public bool Snappy
            {
                get => Value == 2;
                set
                {
                    if (value)
                    {
                        Value = 2;
                    }
                }
            }

            public bool Lz4
            {
                get => Value == 3;
                set
                {
                    if (value)
                    {
                        Value = 3;
                    }
                }
            }

            public bool Zstd
            {
                get => Value == 4;
                set
                {
                    if (value)
                    {
                        Value = 4;
                    }
                }
            }
        }

        public TimestampTypes TimestampType => new TimestampTypes(this);

        public class TimestampTypes
        {
            private readonly RecordBatch _recordBatch;

            internal TimestampTypes(RecordBatch recordBatch)
            {
                _recordBatch = recordBatch;
            }

            public bool CreateTime
            {
                get => !LogAppendTime;
                set => LogAppendTime = !value;
            }

            public bool LogAppendTime
            {
                get => _recordBatch.Attributes.IsBitSet(3);
                set => _recordBatch.Attributes = _recordBatch.Attributes.SetBit(3, value);
            }
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

        public void ReadFrom(IKafkaReader reader)
        {
            BaseOffset = Int64.From(reader.ReadInt64());
            BatchLength = Int32.From(reader.ReadInt32());
            PartitionLeaderEpoch = Int32.From(reader.ReadInt32());
            Magic = Int8.From(reader.ReadInt8());
            Crc = Int32.From(reader.ReadInt32());
            Attributes = Int16.From(reader.ReadInt16());
            LastOffsetDelta = Int32.From(reader.ReadInt32());
            FirstTimestamp = Int64.From(reader.ReadInt64());
            MaxTimestamp = Int64.From(reader.ReadInt64());
            ProducerId = Int64.From(reader.ReadInt64());
            ProducerEpoch = Int16.From(reader.ReadInt16());
            BaseSequence = Int32.From(reader.ReadInt32());
            Records = reader.Read(() => new Record());
        }

        public async Task WriteToAsync(IKafkaWriter writer,
            CancellationToken cancellationToken = default)
        {
            await writer.WriteInt64Async(BaseOffset.Value, cancellationToken);
            await writer.WriteInt32Async(BatchLength.Value, cancellationToken);
            await writer.WriteInt32Async(PartitionLeaderEpoch.Value, cancellationToken);
            await writer.WriteInt8Async(Magic.Value, cancellationToken);
            await writer.WriteInt32Async(Crc.Value, cancellationToken);
            await writer.WriteInt16Async(Attributes.Value, cancellationToken);
            await writer.WriteInt32Async(LastOffsetDelta.Value, cancellationToken);
            await writer.WriteInt64Async(FirstTimestamp.Value, cancellationToken);
            await writer.WriteInt64Async(MaxTimestamp.Value, cancellationToken);
            await writer.WriteInt64Async(ProducerId.Value, cancellationToken);
            await writer.WriteInt16Async(ProducerEpoch.Value, cancellationToken);
            await writer.WriteInt32Async(BaseSequence.Value, cancellationToken);
            await writer.WriteAsync(cancellationToken, Records);
        }
    }
}