﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>The throttling quota has been exceeded.</para>
    /// </summary>
    public class ThrottlingQuotaExceededException : Exception
    {
        public ThrottlingQuotaExceededException()
        {
        }

        public ThrottlingQuotaExceededException(string message) : base(message)
        {
        }

        public const int ErrorCode = 89;
        public int Code => ErrorCode;
    }
}
