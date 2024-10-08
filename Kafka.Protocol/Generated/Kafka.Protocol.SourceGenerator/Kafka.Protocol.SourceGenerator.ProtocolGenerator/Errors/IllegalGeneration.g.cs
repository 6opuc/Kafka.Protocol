﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>Specified group generation id is not valid.</para>
    /// </summary>
    public class IllegalGenerationException : Exception
    {
        public IllegalGenerationException()
        {
        }

        public IllegalGenerationException(string message) : base(message)
        {
        }

        public const int ErrorCode = 22;
        public int Code => ErrorCode;
    }
}
