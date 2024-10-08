﻿#nullable enable
#pragma warning disable 1591
// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;

namespace Kafka.Protocol
{
    /// <summary>
    /// <para>No partition reassignment is in progress.</para>
    /// </summary>
    public class NoReassignmentInProgressException : Exception
    {
        public NoReassignmentInProgressException()
        {
        }

        public NoReassignmentInProgressException(string message) : base(message)
        {
        }

        public const int ErrorCode = 85;
        public int Code => ErrorCode;
    }
}
