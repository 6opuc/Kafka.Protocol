﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>This is not the correct controller for this cluster.</para>
    /// </summary>
    public class NotControllerException : Exception
    {
        public NotControllerException()
        {
        }

        public NotControllerException(string message) : base(message)
        {
        }

        public const int ErrorCode = 41;
        public int Code => ErrorCode;
    }
}
