﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Kafka.Protocol.Records;

// ReSharper disable MemberHidesStaticFromOuterClass FromReaderAsync will cause a lot of these warnings
namespace Kafka.Protocol
{
    public class ControlledShutdownResponse : Message
    {
        public ControlledShutdownResponse(Int16 version)
        {
            if (version.InRange(MinVersion, MaxVersion) == false)
                throw new UnsupportedVersionException($"ControlledShutdownResponse does not support version {version}. Valid versions are: 0-3");
            Version = version;
            IsFlexibleVersion = version >= 3;
        }

        internal override Int16 ApiMessageKey => ApiKey;

        public static readonly Int16 ApiKey = Int16.From(7);
        public static readonly Int16 MinVersion = Int16.From(0);
        public static readonly Int16 MaxVersion = Int16.From(3);
        public override Int16 Version { get; }
        internal bool IsFlexibleVersion { get; }

        // https://github.com/apache/kafka/blob/99b9b3e84f4e98c3f07714e1de6a139a004cbc5b/generator/src/main/java/org/apache/kafka/message/ApiMessageTypeGenerator.java#L324
        public Int16 HeaderVersion
        {
            get
            {
                return (short)(IsFlexibleVersion ? 1 : 0);
            }
        }

        private Tags.TagSection CreateTagSection()
        {
            return new Tags.TagSection();
        }

        internal override int GetSize() => _errorCode.GetSize(IsFlexibleVersion) + _remainingPartitionsCollection.GetSize(IsFlexibleVersion) + (IsFlexibleVersion ? CreateTagSection().GetSize() : 0);
        internal static async ValueTask<ControlledShutdownResponse> FromReaderAsync(Int16 version, PipeReader reader, CancellationToken cancellationToken = default)
        {
            var instance = new ControlledShutdownResponse(version);
            instance.ErrorCode = await Int16.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            instance.RemainingPartitionsCollection = await Map<String, RemainingPartition>.FromReaderAsync(reader, instance.IsFlexibleVersion, () => RemainingPartition.FromReaderAsync(instance.Version, reader, cancellationToken), field => field.TopicName, cancellationToken).ConfigureAwait(false);
            if (instance.IsFlexibleVersion)
            {
                var tagSection = await Tags.TagSection.FromReaderAsync(reader, cancellationToken).ConfigureAwait(false);
                await foreach (var tag in tagSection.WithCancellation(cancellationToken).ConfigureAwait(false))
                {
                    switch (tag.Tag)
                    {
                        default:
                            throw new InvalidOperationException($"Tag '{tag.Tag}' for ControlledShutdownResponse is unknown");
                    }
                }
            }

            return instance;
        }

        internal override async ValueTask WriteToAsync(Stream writer, CancellationToken cancellationToken = default)
        {
            await _errorCode.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            await _remainingPartitionsCollection.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            if (IsFlexibleVersion)
            {
                await CreateTagSection().WriteToAsync(writer, cancellationToken).ConfigureAwait(false);
            }
        }

        private Int16 _errorCode = Int16.Default;
        /// <summary>
        /// <para>The top-level error code.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public Int16 ErrorCode
        {
            get => _errorCode;
            private set
            {
                _errorCode = value;
            }
        }

        /// <summary>
        /// <para>The top-level error code.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public ControlledShutdownResponse WithErrorCode(Int16 errorCode)
        {
            ErrorCode = errorCode;
            return this;
        }

        private Map<String, RemainingPartition> _remainingPartitionsCollection = Map<String, RemainingPartition>.Default;
        /// <summary>
        /// <para>The partitions that the broker still leads.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public Map<String, RemainingPartition> RemainingPartitionsCollection
        {
            get => _remainingPartitionsCollection;
            private set
            {
                _remainingPartitionsCollection = value;
            }
        }

        /// <summary>
        /// <para>The partitions that the broker still leads.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public ControlledShutdownResponse WithRemainingPartitionsCollection(params Func<RemainingPartition, RemainingPartition>[] createFields)
        {
            RemainingPartitionsCollection = createFields.Select(createField => createField(new RemainingPartition(Version))).ToDictionary(field => field.TopicName);
            return this;
        }

        public delegate RemainingPartition CreateRemainingPartition(RemainingPartition field);
        /// <summary>
        /// <para>The partitions that the broker still leads.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public ControlledShutdownResponse WithRemainingPartitionsCollection(IEnumerable<CreateRemainingPartition> createFields)
        {
            RemainingPartitionsCollection = createFields.Select(createField => createField(new RemainingPartition(Version))).ToDictionary(field => field.TopicName);
            return this;
        }

        public class RemainingPartition : ISerialize
        {
            internal RemainingPartition(Int16 version)
            {
                Version = version;
                IsFlexibleVersion = version >= 3;
            }

            internal Int16 Version { get; }
            internal bool IsFlexibleVersion { get; }

            private Tags.TagSection CreateTagSection()
            {
                return new Tags.TagSection();
            }

            int ISerialize.GetSize(bool asCompact) => GetSize(asCompact);
            internal int GetSize(bool _) => _topicName.GetSize(IsFlexibleVersion) + _partitionIndex.GetSize(IsFlexibleVersion) + (IsFlexibleVersion ? CreateTagSection().GetSize() : 0);
            internal static async ValueTask<RemainingPartition> FromReaderAsync(Int16 version, PipeReader reader, CancellationToken cancellationToken = default)
            {
                var instance = new RemainingPartition(version);
                instance.TopicName = await String.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                instance.PartitionIndex = await Int32.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                if (instance.IsFlexibleVersion)
                {
                    var tagSection = await Tags.TagSection.FromReaderAsync(reader, cancellationToken).ConfigureAwait(false);
                    await foreach (var tag in tagSection.WithCancellation(cancellationToken).ConfigureAwait(false))
                    {
                        switch (tag.Tag)
                        {
                            default:
                                throw new InvalidOperationException($"Tag '{tag.Tag}' for RemainingPartition is unknown");
                        }
                    }
                }

                return instance;
            }

            ValueTask ISerialize.WriteToAsync(Stream writer, bool asCompact, CancellationToken cancellationToken) => WriteToAsync(writer, asCompact, cancellationToken);
            internal async ValueTask WriteToAsync(Stream writer, bool _, CancellationToken cancellationToken = default)
            {
                await _topicName.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                await _partitionIndex.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                if (IsFlexibleVersion)
                {
                    await CreateTagSection().WriteToAsync(writer, cancellationToken).ConfigureAwait(false);
                }
            }

            private String _topicName = String.Default;
            /// <summary>
            /// <para>The name of the topic.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public String TopicName
            {
                get => _topicName;
                private set
                {
                    _topicName = value;
                }
            }

            /// <summary>
            /// <para>The name of the topic.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public RemainingPartition WithTopicName(String topicName)
            {
                TopicName = topicName;
                return this;
            }

            private Int32 _partitionIndex = Int32.Default;
            /// <summary>
            /// <para>The index of the partition.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public Int32 PartitionIndex
            {
                get => _partitionIndex;
                private set
                {
                    _partitionIndex = value;
                }
            }

            /// <summary>
            /// <para>The index of the partition.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public RemainingPartition WithPartitionIndex(Int32 partitionIndex)
            {
                PartitionIndex = partitionIndex;
                return this;
            }
        }
    }
}
