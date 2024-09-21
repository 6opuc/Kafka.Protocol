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
    public class AlterUserScramCredentialsResponse : Message
    {
        public AlterUserScramCredentialsResponse(Int16 version)
        {
            if (version.InRange(MinVersion, MaxVersion) == false)
                throw new UnsupportedVersionException($"AlterUserScramCredentialsResponse does not support version {version}. Valid versions are: 0");
            Version = version;
            IsFlexibleVersion = true;
        }

        internal override Int16 ApiMessageKey => ApiKey;

        public static readonly Int16 ApiKey = Int16.From(51);
        public static readonly Int16 MinVersion = Int16.From(0);
        public static readonly Int16 MaxVersion = Int16.From(0);
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

        internal override int GetSize() => _throttleTimeMs.GetSize(IsFlexibleVersion) + _resultsCollection.GetSize(IsFlexibleVersion) + (IsFlexibleVersion ? CreateTagSection().GetSize() : 0);
        internal static async ValueTask<AlterUserScramCredentialsResponse> FromReaderAsync(Int16 version, PipeReader reader, CancellationToken cancellationToken = default)
        {
            var instance = new AlterUserScramCredentialsResponse(version);
            instance.ThrottleTimeMs = await Int32.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            instance.ResultsCollection = await Array<AlterUserScramCredentialsResult>.FromReaderAsync(reader, instance.IsFlexibleVersion, () => AlterUserScramCredentialsResult.FromReaderAsync(instance.Version, reader, cancellationToken), cancellationToken).ConfigureAwait(false);
            if (instance.IsFlexibleVersion)
            {
                var tagSection = await Tags.TagSection.FromReaderAsync(reader, cancellationToken).ConfigureAwait(false);
                await foreach (var tag in tagSection.WithCancellation(cancellationToken).ConfigureAwait(false))
                {
                    switch (tag.Tag)
                    {
                        default:
                            throw new InvalidOperationException($"Tag '{tag.Tag}' for AlterUserScramCredentialsResponse is unknown");
                    }
                }
            }

            return instance;
        }

        internal override async ValueTask WriteToAsync(Stream writer, CancellationToken cancellationToken = default)
        {
            await _throttleTimeMs.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            await _resultsCollection.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
            if (IsFlexibleVersion)
            {
                await CreateTagSection().WriteToAsync(writer, cancellationToken).ConfigureAwait(false);
            }
        }

        private Int32 _throttleTimeMs = Int32.Default;
        /// <summary>
        /// <para>The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public Int32 ThrottleTimeMs
        {
            get => _throttleTimeMs;
            private set
            {
                _throttleTimeMs = value;
            }
        }

        /// <summary>
        /// <para>The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public AlterUserScramCredentialsResponse WithThrottleTimeMs(Int32 throttleTimeMs)
        {
            ThrottleTimeMs = throttleTimeMs;
            return this;
        }

        private Array<AlterUserScramCredentialsResult> _resultsCollection = Array.Empty<AlterUserScramCredentialsResult>();
        /// <summary>
        /// <para>The results for deletions and alterations, one per affected user.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public Array<AlterUserScramCredentialsResult> ResultsCollection
        {
            get => _resultsCollection;
            private set
            {
                _resultsCollection = value;
            }
        }

        /// <summary>
        /// <para>The results for deletions and alterations, one per affected user.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public AlterUserScramCredentialsResponse WithResultsCollection(params Func<AlterUserScramCredentialsResult, AlterUserScramCredentialsResult>[] createFields)
        {
            ResultsCollection = createFields.Select(createField => createField(new AlterUserScramCredentialsResult(Version))).ToArray();
            return this;
        }

        public delegate AlterUserScramCredentialsResult CreateAlterUserScramCredentialsResult(AlterUserScramCredentialsResult field);
        /// <summary>
        /// <para>The results for deletions and alterations, one per affected user.</para>
        /// <para>Versions: 0+</para>
        /// </summary>
        public AlterUserScramCredentialsResponse WithResultsCollection(IEnumerable<CreateAlterUserScramCredentialsResult> createFields)
        {
            ResultsCollection = createFields.Select(createField => createField(new AlterUserScramCredentialsResult(Version))).ToArray();
            return this;
        }

        public class AlterUserScramCredentialsResult : ISerialize
        {
            internal AlterUserScramCredentialsResult(Int16 version)
            {
                Version = version;
                IsFlexibleVersion = true;
            }

            internal Int16 Version { get; }
            internal bool IsFlexibleVersion { get; }

            private Tags.TagSection CreateTagSection()
            {
                return new Tags.TagSection();
            }

            int ISerialize.GetSize(bool asCompact) => GetSize(asCompact);
            internal int GetSize(bool _) => _user.GetSize(IsFlexibleVersion) + _errorCode.GetSize(IsFlexibleVersion) + _errorMessage.GetSize(IsFlexibleVersion) + (IsFlexibleVersion ? CreateTagSection().GetSize() : 0);
            internal static async ValueTask<AlterUserScramCredentialsResult> FromReaderAsync(Int16 version, PipeReader reader, CancellationToken cancellationToken = default)
            {
                var instance = new AlterUserScramCredentialsResult(version);
                instance.User = await String.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                instance.ErrorCode = await Int16.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                instance.ErrorMessage = await NullableString.FromReaderAsync(reader, instance.IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                if (instance.IsFlexibleVersion)
                {
                    var tagSection = await Tags.TagSection.FromReaderAsync(reader, cancellationToken).ConfigureAwait(false);
                    await foreach (var tag in tagSection.WithCancellation(cancellationToken).ConfigureAwait(false))
                    {
                        switch (tag.Tag)
                        {
                            default:
                                throw new InvalidOperationException($"Tag '{tag.Tag}' for AlterUserScramCredentialsResult is unknown");
                        }
                    }
                }

                return instance;
            }

            ValueTask ISerialize.WriteToAsync(Stream writer, bool asCompact, CancellationToken cancellationToken) => WriteToAsync(writer, asCompact, cancellationToken);
            internal async ValueTask WriteToAsync(Stream writer, bool _, CancellationToken cancellationToken = default)
            {
                await _user.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                await _errorCode.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                await _errorMessage.WriteToAsync(writer, IsFlexibleVersion, cancellationToken).ConfigureAwait(false);
                if (IsFlexibleVersion)
                {
                    await CreateTagSection().WriteToAsync(writer, cancellationToken).ConfigureAwait(false);
                }
            }

            private String _user = String.Default;
            /// <summary>
            /// <para>The user name.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public String User
            {
                get => _user;
                private set
                {
                    _user = value;
                }
            }

            /// <summary>
            /// <para>The user name.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public AlterUserScramCredentialsResult WithUser(String user)
            {
                User = user;
                return this;
            }

            private Int16 _errorCode = Int16.Default;
            /// <summary>
            /// <para>The error code.</para>
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
            /// <para>The error code.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public AlterUserScramCredentialsResult WithErrorCode(Int16 errorCode)
            {
                ErrorCode = errorCode;
                return this;
            }

            private NullableString _errorMessage = NullableString.Default;
            /// <summary>
            /// <para>The error message, if any.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public String? ErrorMessage
            {
                get => _errorMessage;
                private set
                {
                    _errorMessage = value;
                }
            }

            /// <summary>
            /// <para>The error message, if any.</para>
            /// <para>Versions: 0+</para>
            /// </summary>
            public AlterUserScramCredentialsResult WithErrorMessage(String? errorMessage)
            {
                ErrorMessage = errorMessage;
                return this;
            }
        }
    }
}
