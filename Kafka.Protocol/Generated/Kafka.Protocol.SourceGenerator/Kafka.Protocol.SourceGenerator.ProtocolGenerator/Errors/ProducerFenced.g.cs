﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>There is a newer producer with the same transactionalId which fences the current one.</para>
    /// </summary>
    public class ProducerFencedException : Exception
    {
        public ProducerFencedException()
        {
        }

        public ProducerFencedException(string message) : base(message)
        {
        }

        public const int ErrorCode = 90;
        public int Code => ErrorCode;
    }
}
