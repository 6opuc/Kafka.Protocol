﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>SASL Authentication failed.</para>
    /// </summary>
    public class SaslAuthenticationFailedException : Exception
    {
        public SaslAuthenticationFailedException()
        {
        }

        public SaslAuthenticationFailedException(string message) : base(message)
        {
        }

        public const int ErrorCode = 58;
        public int Code => ErrorCode;
    }
}
