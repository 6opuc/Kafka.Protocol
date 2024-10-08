﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>The requesting client does not support the compression type of given partition.</para>
    /// </summary>
    public class UnsupportedCompressionTypeException : Exception
    {
        public UnsupportedCompressionTypeException()
        {
        }

        public UnsupportedCompressionTypeException(string message) : base(message)
        {
        }

        public const int ErrorCode = 76;
        public int Code => ErrorCode;
    }
}
