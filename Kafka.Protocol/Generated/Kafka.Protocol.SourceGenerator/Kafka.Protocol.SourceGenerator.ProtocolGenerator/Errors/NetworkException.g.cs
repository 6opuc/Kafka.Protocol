﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>The server disconnected before a response was received.</para>
    /// </summary>
    public class NetworkExceptionException : Exception
    {
        public NetworkExceptionException()
        {
        }

        public NetworkExceptionException(string message) : base(message)
        {
        }

        public const int ErrorCode = 13;
        public int Code => ErrorCode;
    }
}
