﻿// WARNING! THIS FILE IS AUTO-GENERATED! DO NOT EDIT.
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kafka.Protocol
{
	/// <summary>
	/// Represents a boolean value in a byte. Values 0 and 1 are used to represent false and true respectively. When reading a boolean value, any non-zero value is considered true.
	/// </summary>
	public struct Boolean : ISerialize 
	{
		public System.Boolean Value { get; private set; }

		public Boolean(System.Boolean value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Boolean comparingBoolean && this == comparingBoolean;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Boolean x, Boolean y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Boolean x, Boolean y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadBoolean();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteBoolean(Value);
		}

		public static Boolean From(System.Boolean value)
		{
			return new Boolean(value);
		}

		public static Boolean Default => Boolean.From(default);
	}

	/// <summary>
	/// Represents an integer between -27 and 27-1 inclusive.
	/// </summary>
	public struct Int8 : ISerialize 
	{
		public System.SByte Value { get; private set; }

		public Int8(System.SByte value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Int8 comparingInt8 && this == comparingInt8;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Int8 x, Int8 y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Int8 x, Int8 y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadInt8();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteInt8(Value);
		}

		public static Int8 From(System.SByte value)
		{
			return new Int8(value);
		}

		public static Int8 Default => Int8.From(default);
	}

	/// <summary>
	/// Represents an integer between -215 and 215-1 inclusive. The values are encoded using two bytes in network byte order (big-endian).
	/// </summary>
	public struct Int16 : ISerialize 
	{
		public System.Int16 Value { get; private set; }

		public Int16(System.Int16 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Int16 comparingInt16 && this == comparingInt16;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Int16 x, Int16 y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Int16 x, Int16 y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadInt16();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteInt16(Value);
		}

		public static Int16 From(System.Int16 value)
		{
			return new Int16(value);
		}

		public static Int16 Default => Int16.From(default);
	}

	/// <summary>
	/// Represents an integer between -231 and 231-1 inclusive. The values are encoded using four bytes in network byte order (big-endian).
	/// </summary>
	public struct Int32 : ISerialize 
	{
		public System.Int32 Value { get; private set; }

		public Int32(System.Int32 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Int32 comparingInt32 && this == comparingInt32;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Int32 x, Int32 y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Int32 x, Int32 y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadInt32();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteInt32(Value);
		}

		public static Int32 From(System.Int32 value)
		{
			return new Int32(value);
		}

		public static Int32 Default => Int32.From(default);
	}

	/// <summary>
	/// Represents an integer between -263 and 263-1 inclusive. The values are encoded using eight bytes in network byte order (big-endian).
	/// </summary>
	public struct Int64 : ISerialize 
	{
		public System.Int64 Value { get; private set; }

		public Int64(System.Int64 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Int64 comparingInt64 && this == comparingInt64;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Int64 x, Int64 y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Int64 x, Int64 y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadInt64();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteInt64(Value);
		}

		public static Int64 From(System.Int64 value)
		{
			return new Int64(value);
		}

		public static Int64 Default => Int64.From(default);
	}

	/// <summary>
	/// Represents an integer between 0 and 232-1 inclusive. The values are encoded using four bytes in network byte order (big-endian).
	/// </summary>
	public struct UInt32 : ISerialize 
	{
		public System.UInt32 Value { get; private set; }

		public UInt32(System.UInt32 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is UInt32 comparingUInt32 && this == comparingUInt32;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (UInt32 x, UInt32 y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (UInt32 x, UInt32 y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadUInt32();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteUInt32(Value);
		}

		public static UInt32 From(System.UInt32 value)
		{
			return new UInt32(value);
		}

		public static UInt32 Default => UInt32.From(default);
	}

	/// <summary>
	/// Represents an integer between -231 and 231-1 inclusive. Encoding follows the variable-length zig-zag encoding from   Google Protocol Buffers.
	/// </summary>
	public struct VarInt : ISerialize 
	{
		public System.Int32 Value { get; private set; }

		public VarInt(System.Int32 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is VarInt comparingVarInt && this == comparingVarInt;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (VarInt x, VarInt y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (VarInt x, VarInt y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadVarInt();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteVarInt(Value);
		}

		public static VarInt From(System.Int32 value)
		{
			return new VarInt(value);
		}

		public static VarInt Default => VarInt.From(default);
	}

	/// <summary>
	/// Represents an integer between -263 and 263-1 inclusive. Encoding follows the variable-length zig-zag encoding from   Google Protocol Buffers.
	/// </summary>
	public struct VarLong : ISerialize 
	{
		public System.Int64 Value { get; private set; }

		public VarLong(System.Int64 value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is VarLong comparingVarLong && this == comparingVarLong;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (VarLong x, VarLong y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (VarLong x, VarLong y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadVarLong();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteVarLong(Value);
		}

		public static VarLong From(System.Int64 value)
		{
			return new VarLong(value);
		}

		public static VarLong Default => VarLong.From(default);
	}

	/// <summary>
	/// Represents a sequence of characters. First the length N is given as an INT16. Then N bytes follow which are the UTF-8 encoding of the character sequence. Length must not be negative.
	/// </summary>
	public struct String : ISerialize 
	{
		public System.String Value { get; private set; }

		public String(System.String value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is String comparingString && this == comparingString;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (String x, String y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (String x, String y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadString();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteString(Value);
		}

		public static String From(System.String value)
		{
			return new String(value);
		}

		public static String Default => String.From(System.String.Empty);
	}

	/// <summary>
	/// Represents a sequence of characters or null. For non-null strings, first the length N is given as an INT16. Then N bytes follow which are the UTF-8 encoding of the character sequence. A null value is encoded with length of -1 and there are no following bytes.
	/// </summary>
	public struct NullableString : ISerialize 
	{
		public System.String Value { get; private set; }

		public NullableString(System.String value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is NullableString comparingNullableString && this == comparingNullableString;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (NullableString x, NullableString y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (NullableString x, NullableString y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadNullableString();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteNullableString(Value);
		}

		public static NullableString From(System.String value)
		{
			return new NullableString(value);
		}

		public static NullableString Default => NullableString.From(System.String.Empty);
	}

	/// <summary>
	/// Represents a raw sequence of bytes. First the length N is given as an INT32. Then N bytes follow.
	/// </summary>
	public struct Bytes : ISerialize 
	{
		public System.Byte[] Value { get; private set; }

		public Bytes(System.Byte[] value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is Bytes comparingBytes && this == comparingBytes;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (Bytes x, Bytes y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (Bytes x, Bytes y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadBytes();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteBytes(Value);
		}

		public static Bytes From(System.Byte[] value)
		{
			return new Bytes(value);
		}

		public static Bytes Default => Bytes.From(new System.Byte[0]);
	}

	/// <summary>
	/// Represents a raw sequence of bytes or null. For non-null values, first the length N is given as an INT32. Then N bytes follow. A null value is encoded with length of -1 and there are no following bytes.
	/// </summary>
	public struct NullableBytes : ISerialize 
	{
		public System.Byte[] Value { get; private set; }

		public NullableBytes(System.Byte[] value)
		{
			Value = value;
		}

		public override bool Equals(object obj) 
		{
			return obj is NullableBytes comparingNullableBytes && this == comparingNullableBytes;
		}

		public override int GetHashCode() 
		{
			return Value.GetHashCode();
		}

		public override string ToString() 
		{
			return Value.ToString();
		}

		public static bool operator == (NullableBytes x, NullableBytes y)
		{
			return x.Value == y.Value;
		}

		public static bool operator != (NullableBytes x, NullableBytes y)
		{
			return !(x == y);
		}

		public void ReadFrom(IKafkaReader reader)
		{
			Value = reader.ReadNullableBytes();
		}

		public void WriteTo(IKafkaWriter writer)
		{
			writer.WriteNullableBytes(Value);
		}

		public static NullableBytes From(System.Byte[] value)
		{
			return new NullableBytes(value);
		}

		public static NullableBytes Default => NullableBytes.From(new System.Byte[0]);
	}
	/// <summary>
	/// The server experienced an unexpected error when processing the request.
	/// </summary>
	public class UnknownServerErrorException : Exception
	{
		public UnknownServerErrorException()
		{

		}

		public UnknownServerErrorException(string message) : base(message)
		{

		}

		public int Code { get; } = -1;
	}

	public class NoneException : Exception
	{
		public NoneException()
		{

		}

		public NoneException(string message) : base(message)
		{

		}

		public int Code { get; } = 0;
	}

	/// <summary>
	/// The requested offset is not within the range of offsets maintained by the server.
	/// </summary>
	public class OffsetOutOfRangeException : Exception
	{
		public OffsetOutOfRangeException()
		{

		}

		public OffsetOutOfRangeException(string message) : base(message)
		{

		}

		public int Code { get; } = 1;
	}

	/// <summary>
	/// This message has failed its CRC checksum, exceeds the valid size, has a null key for a compacted topic, or is otherwise corrupt.
	/// </summary>
	public class CorruptMessageException : Exception
	{
		public CorruptMessageException()
		{

		}

		public CorruptMessageException(string message) : base(message)
		{

		}

		public int Code { get; } = 2;
	}

	/// <summary>
	/// This server does not host this topic-partition.
	/// </summary>
	public class UnknownTopicOrPartitionException : Exception
	{
		public UnknownTopicOrPartitionException()
		{

		}

		public UnknownTopicOrPartitionException(string message) : base(message)
		{

		}

		public int Code { get; } = 3;
	}

	/// <summary>
	/// The requested fetch size is invalid.
	/// </summary>
	public class InvalidFetchSizeException : Exception
	{
		public InvalidFetchSizeException()
		{

		}

		public InvalidFetchSizeException(string message) : base(message)
		{

		}

		public int Code { get; } = 4;
	}

	/// <summary>
	/// There is no leader for this topic-partition as we are in the middle of a leadership election.
	/// </summary>
	public class LeaderNotAvailableException : Exception
	{
		public LeaderNotAvailableException()
		{

		}

		public LeaderNotAvailableException(string message) : base(message)
		{

		}

		public int Code { get; } = 5;
	}

	/// <summary>
	/// This server is not the leader for that topic-partition.
	/// </summary>
	public class NotLeaderForPartitionException : Exception
	{
		public NotLeaderForPartitionException()
		{

		}

		public NotLeaderForPartitionException(string message) : base(message)
		{

		}

		public int Code { get; } = 6;
	}

	/// <summary>
	/// The request timed out.
	/// </summary>
	public class RequestTimedOutException : Exception
	{
		public RequestTimedOutException()
		{

		}

		public RequestTimedOutException(string message) : base(message)
		{

		}

		public int Code { get; } = 7;
	}

	/// <summary>
	/// The broker is not available.
	/// </summary>
	public class BrokerNotAvailableException : Exception
	{
		public BrokerNotAvailableException()
		{

		}

		public BrokerNotAvailableException(string message) : base(message)
		{

		}

		public int Code { get; } = 8;
	}

	/// <summary>
	/// The replica is not available for the requested topic-partition.
	/// </summary>
	public class ReplicaNotAvailableException : Exception
	{
		public ReplicaNotAvailableException()
		{

		}

		public ReplicaNotAvailableException(string message) : base(message)
		{

		}

		public int Code { get; } = 9;
	}

	/// <summary>
	/// The request included a message larger than the max message size the server will accept.
	/// </summary>
	public class MessageTooLargeException : Exception
	{
		public MessageTooLargeException()
		{

		}

		public MessageTooLargeException(string message) : base(message)
		{

		}

		public int Code { get; } = 10;
	}

	/// <summary>
	/// The controller moved to another broker.
	/// </summary>
	public class StaleControllerEpochException : Exception
	{
		public StaleControllerEpochException()
		{

		}

		public StaleControllerEpochException(string message) : base(message)
		{

		}

		public int Code { get; } = 11;
	}

	/// <summary>
	/// The metadata field of the offset request was too large.
	/// </summary>
	public class OffsetMetadataTooLargeException : Exception
	{
		public OffsetMetadataTooLargeException()
		{

		}

		public OffsetMetadataTooLargeException(string message) : base(message)
		{

		}

		public int Code { get; } = 12;
	}

	/// <summary>
	/// The server disconnected before a response was received.
	/// </summary>
	public class NetworkExceptionException : Exception
	{
		public NetworkExceptionException()
		{

		}

		public NetworkExceptionException(string message) : base(message)
		{

		}

		public int Code { get; } = 13;
	}

	/// <summary>
	/// The coordinator is loading and hence can't process requests.
	/// </summary>
	public class CoordinatorLoadInProgressException : Exception
	{
		public CoordinatorLoadInProgressException()
		{

		}

		public CoordinatorLoadInProgressException(string message) : base(message)
		{

		}

		public int Code { get; } = 14;
	}

	/// <summary>
	/// The coordinator is not available.
	/// </summary>
	public class CoordinatorNotAvailableException : Exception
	{
		public CoordinatorNotAvailableException()
		{

		}

		public CoordinatorNotAvailableException(string message) : base(message)
		{

		}

		public int Code { get; } = 15;
	}

	/// <summary>
	/// This is not the correct coordinator.
	/// </summary>
	public class NotCoordinatorException : Exception
	{
		public NotCoordinatorException()
		{

		}

		public NotCoordinatorException(string message) : base(message)
		{

		}

		public int Code { get; } = 16;
	}

	/// <summary>
	/// The request attempted to perform an operation on an invalid topic.
	/// </summary>
	public class InvalidTopicExceptionException : Exception
	{
		public InvalidTopicExceptionException()
		{

		}

		public InvalidTopicExceptionException(string message) : base(message)
		{

		}

		public int Code { get; } = 17;
	}

	/// <summary>
	/// The request included message batch larger than the configured segment size on the server.
	/// </summary>
	public class RecordListTooLargeException : Exception
	{
		public RecordListTooLargeException()
		{

		}

		public RecordListTooLargeException(string message) : base(message)
		{

		}

		public int Code { get; } = 18;
	}

	/// <summary>
	/// Messages are rejected since there are fewer in-sync replicas than required.
	/// </summary>
	public class NotEnoughReplicasException : Exception
	{
		public NotEnoughReplicasException()
		{

		}

		public NotEnoughReplicasException(string message) : base(message)
		{

		}

		public int Code { get; } = 19;
	}

	/// <summary>
	/// Messages are written to the log, but to fewer in-sync replicas than required.
	/// </summary>
	public class NotEnoughReplicasAfterAppendException : Exception
	{
		public NotEnoughReplicasAfterAppendException()
		{

		}

		public NotEnoughReplicasAfterAppendException(string message) : base(message)
		{

		}

		public int Code { get; } = 20;
	}

	/// <summary>
	/// Produce request specified an invalid value for required acks.
	/// </summary>
	public class InvalidRequiredAcksException : Exception
	{
		public InvalidRequiredAcksException()
		{

		}

		public InvalidRequiredAcksException(string message) : base(message)
		{

		}

		public int Code { get; } = 21;
	}

	/// <summary>
	/// Specified group generation id is not valid.
	/// </summary>
	public class IllegalGenerationException : Exception
	{
		public IllegalGenerationException()
		{

		}

		public IllegalGenerationException(string message) : base(message)
		{

		}

		public int Code { get; } = 22;
	}

	/// <summary>
	/// The group member's supported protocols are incompatible with those of existing members or first group member tried to join with empty protocol type or empty protocol list.
	/// </summary>
	public class InconsistentGroupProtocolException : Exception
	{
		public InconsistentGroupProtocolException()
		{

		}

		public InconsistentGroupProtocolException(string message) : base(message)
		{

		}

		public int Code { get; } = 23;
	}

	/// <summary>
	/// The configured groupId is invalid.
	/// </summary>
	public class InvalidGroupIdException : Exception
	{
		public InvalidGroupIdException()
		{

		}

		public InvalidGroupIdException(string message) : base(message)
		{

		}

		public int Code { get; } = 24;
	}

	/// <summary>
	/// The coordinator is not aware of this member.
	/// </summary>
	public class UnknownMemberIdException : Exception
	{
		public UnknownMemberIdException()
		{

		}

		public UnknownMemberIdException(string message) : base(message)
		{

		}

		public int Code { get; } = 25;
	}

	/// <summary>
	/// The session timeout is not within the range allowed by the broker (as configured by group.min.session.timeout.ms and group.max.session.timeout.ms).
	/// </summary>
	public class InvalidSessionTimeoutException : Exception
	{
		public InvalidSessionTimeoutException()
		{

		}

		public InvalidSessionTimeoutException(string message) : base(message)
		{

		}

		public int Code { get; } = 26;
	}

	/// <summary>
	/// The group is rebalancing, so a rejoin is needed.
	/// </summary>
	public class RebalanceInProgressException : Exception
	{
		public RebalanceInProgressException()
		{

		}

		public RebalanceInProgressException(string message) : base(message)
		{

		}

		public int Code { get; } = 27;
	}

	/// <summary>
	/// The committing offset data size is not valid.
	/// </summary>
	public class InvalidCommitOffsetSizeException : Exception
	{
		public InvalidCommitOffsetSizeException()
		{

		}

		public InvalidCommitOffsetSizeException(string message) : base(message)
		{

		}

		public int Code { get; } = 28;
	}

	/// <summary>
	/// Not authorized to access topics: [Topic authorization failed.]
	/// </summary>
	public class TopicAuthorizationFailedException : Exception
	{
		public TopicAuthorizationFailedException()
		{

		}

		public TopicAuthorizationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 29;
	}

	/// <summary>
	/// Not authorized to access group: Group authorization failed.
	/// </summary>
	public class GroupAuthorizationFailedException : Exception
	{
		public GroupAuthorizationFailedException()
		{

		}

		public GroupAuthorizationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 30;
	}

	/// <summary>
	/// Cluster authorization failed.
	/// </summary>
	public class ClusterAuthorizationFailedException : Exception
	{
		public ClusterAuthorizationFailedException()
		{

		}

		public ClusterAuthorizationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 31;
	}

	/// <summary>
	/// The timestamp of the message is out of acceptable range.
	/// </summary>
	public class InvalidTimestampException : Exception
	{
		public InvalidTimestampException()
		{

		}

		public InvalidTimestampException(string message) : base(message)
		{

		}

		public int Code { get; } = 32;
	}

	/// <summary>
	/// The broker does not support the requested SASL mechanism.
	/// </summary>
	public class UnsupportedSaslMechanismException : Exception
	{
		public UnsupportedSaslMechanismException()
		{

		}

		public UnsupportedSaslMechanismException(string message) : base(message)
		{

		}

		public int Code { get; } = 33;
	}

	/// <summary>
	/// Request is not valid given the current SASL state.
	/// </summary>
	public class IllegalSaslStateException : Exception
	{
		public IllegalSaslStateException()
		{

		}

		public IllegalSaslStateException(string message) : base(message)
		{

		}

		public int Code { get; } = 34;
	}

	/// <summary>
	/// The version of API is not supported.
	/// </summary>
	public class UnsupportedVersionException : Exception
	{
		public UnsupportedVersionException()
		{

		}

		public UnsupportedVersionException(string message) : base(message)
		{

		}

		public int Code { get; } = 35;
	}

	/// <summary>
	/// Topic with this name already exists.
	/// </summary>
	public class TopicAlreadyExistsException : Exception
	{
		public TopicAlreadyExistsException()
		{

		}

		public TopicAlreadyExistsException(string message) : base(message)
		{

		}

		public int Code { get; } = 36;
	}

	/// <summary>
	/// Number of partitions is below 1.
	/// </summary>
	public class InvalidPartitionsException : Exception
	{
		public InvalidPartitionsException()
		{

		}

		public InvalidPartitionsException(string message) : base(message)
		{

		}

		public int Code { get; } = 37;
	}

	/// <summary>
	/// Replication factor is below 1 or larger than the number of available brokers.
	/// </summary>
	public class InvalidReplicationFactorException : Exception
	{
		public InvalidReplicationFactorException()
		{

		}

		public InvalidReplicationFactorException(string message) : base(message)
		{

		}

		public int Code { get; } = 38;
	}

	/// <summary>
	/// Replica assignment is invalid.
	/// </summary>
	public class InvalidReplicaAssignmentException : Exception
	{
		public InvalidReplicaAssignmentException()
		{

		}

		public InvalidReplicaAssignmentException(string message) : base(message)
		{

		}

		public int Code { get; } = 39;
	}

	/// <summary>
	/// Configuration is invalid.
	/// </summary>
	public class InvalidConfigException : Exception
	{
		public InvalidConfigException()
		{

		}

		public InvalidConfigException(string message) : base(message)
		{

		}

		public int Code { get; } = 40;
	}

	/// <summary>
	/// This is not the correct controller for this cluster.
	/// </summary>
	public class NotControllerException : Exception
	{
		public NotControllerException()
		{

		}

		public NotControllerException(string message) : base(message)
		{

		}

		public int Code { get; } = 41;
	}

	/// <summary>
	/// This most likely occurs because of a request being malformed by the client library or the message was sent to an incompatible broker. See the broker logs for more details.
	/// </summary>
	public class InvalidRequestException : Exception
	{
		public InvalidRequestException()
		{

		}

		public InvalidRequestException(string message) : base(message)
		{

		}

		public int Code { get; } = 42;
	}

	/// <summary>
	/// The message format version on the broker does not support the request.
	/// </summary>
	public class UnsupportedForMessageFormatException : Exception
	{
		public UnsupportedForMessageFormatException()
		{

		}

		public UnsupportedForMessageFormatException(string message) : base(message)
		{

		}

		public int Code { get; } = 43;
	}

	/// <summary>
	/// Request parameters do not satisfy the configured policy.
	/// </summary>
	public class PolicyViolationException : Exception
	{
		public PolicyViolationException()
		{

		}

		public PolicyViolationException(string message) : base(message)
		{

		}

		public int Code { get; } = 44;
	}

	/// <summary>
	/// The broker received an out of order sequence number.
	/// </summary>
	public class OutOfOrderSequenceNumberException : Exception
	{
		public OutOfOrderSequenceNumberException()
		{

		}

		public OutOfOrderSequenceNumberException(string message) : base(message)
		{

		}

		public int Code { get; } = 45;
	}

	/// <summary>
	/// The broker received a duplicate sequence number.
	/// </summary>
	public class DuplicateSequenceNumberException : Exception
	{
		public DuplicateSequenceNumberException()
		{

		}

		public DuplicateSequenceNumberException(string message) : base(message)
		{

		}

		public int Code { get; } = 46;
	}

	/// <summary>
	/// Producer attempted an operation with an old epoch. Either there is a newer producer with the same transactionalId, or the producer's transaction has been expired by the broker.
	/// </summary>
	public class InvalidProducerEpochException : Exception
	{
		public InvalidProducerEpochException()
		{

		}

		public InvalidProducerEpochException(string message) : base(message)
		{

		}

		public int Code { get; } = 47;
	}

	/// <summary>
	/// The producer attempted a transactional operation in an invalid state.
	/// </summary>
	public class InvalidTxnStateException : Exception
	{
		public InvalidTxnStateException()
		{

		}

		public InvalidTxnStateException(string message) : base(message)
		{

		}

		public int Code { get; } = 48;
	}

	/// <summary>
	/// The producer attempted to use a producer id which is not currently assigned to its transactional id.
	/// </summary>
	public class InvalidProducerIdMappingException : Exception
	{
		public InvalidProducerIdMappingException()
		{

		}

		public InvalidProducerIdMappingException(string message) : base(message)
		{

		}

		public int Code { get; } = 49;
	}

	/// <summary>
	/// The transaction timeout is larger than the maximum value allowed by the broker (as configured by transaction.max.timeout.ms).
	/// </summary>
	public class InvalidTransactionTimeoutException : Exception
	{
		public InvalidTransactionTimeoutException()
		{

		}

		public InvalidTransactionTimeoutException(string message) : base(message)
		{

		}

		public int Code { get; } = 50;
	}

	/// <summary>
	/// The producer attempted to update a transaction while another concurrent operation on the same transaction was ongoing.
	/// </summary>
	public class ConcurrentTransactionsException : Exception
	{
		public ConcurrentTransactionsException()
		{

		}

		public ConcurrentTransactionsException(string message) : base(message)
		{

		}

		public int Code { get; } = 51;
	}

	/// <summary>
	/// Indicates that the transaction coordinator sending a WriteTxnMarker is no longer the current coordinator for a given producer.
	/// </summary>
	public class TransactionCoordinatorFencedException : Exception
	{
		public TransactionCoordinatorFencedException()
		{

		}

		public TransactionCoordinatorFencedException(string message) : base(message)
		{

		}

		public int Code { get; } = 52;
	}

	/// <summary>
	/// Transactional Id authorization failed.
	/// </summary>
	public class TransactionalIdAuthorizationFailedException : Exception
	{
		public TransactionalIdAuthorizationFailedException()
		{

		}

		public TransactionalIdAuthorizationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 53;
	}

	/// <summary>
	/// Security features are disabled.
	/// </summary>
	public class SecurityDisabledException : Exception
	{
		public SecurityDisabledException()
		{

		}

		public SecurityDisabledException(string message) : base(message)
		{

		}

		public int Code { get; } = 54;
	}

	/// <summary>
	/// The broker did not attempt to execute this operation. This may happen for batched RPCs where some operations in the batch failed, causing the broker to respond without trying the rest.
	/// </summary>
	public class OperationNotAttemptedException : Exception
	{
		public OperationNotAttemptedException()
		{

		}

		public OperationNotAttemptedException(string message) : base(message)
		{

		}

		public int Code { get; } = 55;
	}

	/// <summary>
	/// Disk error when trying to access log file on the disk.
	/// </summary>
	public class KafkaStorageErrorException : Exception
	{
		public KafkaStorageErrorException()
		{

		}

		public KafkaStorageErrorException(string message) : base(message)
		{

		}

		public int Code { get; } = 56;
	}

	/// <summary>
	/// The user-specified log directory is not found in the broker config.
	/// </summary>
	public class LogDirNotFoundException : Exception
	{
		public LogDirNotFoundException()
		{

		}

		public LogDirNotFoundException(string message) : base(message)
		{

		}

		public int Code { get; } = 57;
	}

	/// <summary>
	/// SASL Authentication failed.
	/// </summary>
	public class SaslAuthenticationFailedException : Exception
	{
		public SaslAuthenticationFailedException()
		{

		}

		public SaslAuthenticationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 58;
	}

	/// <summary>
	/// This exception is raised by the broker if it could not locate the producer metadata associated with the producerId in question. This could happen if, for instance, the producer's records were deleted because their retention time had elapsed. Once the last records of the producerId are removed, the producer's metadata is removed from the broker, and future appends by the producer will return this exception.
	/// </summary>
	public class UnknownProducerIdException : Exception
	{
		public UnknownProducerIdException()
		{

		}

		public UnknownProducerIdException(string message) : base(message)
		{

		}

		public int Code { get; } = 59;
	}

	/// <summary>
	/// A partition reassignment is in progress.
	/// </summary>
	public class ReassignmentInProgressException : Exception
	{
		public ReassignmentInProgressException()
		{

		}

		public ReassignmentInProgressException(string message) : base(message)
		{

		}

		public int Code { get; } = 60;
	}

	/// <summary>
	/// Delegation Token feature is not enabled.
	/// </summary>
	public class DelegationTokenAuthDisabledException : Exception
	{
		public DelegationTokenAuthDisabledException()
		{

		}

		public DelegationTokenAuthDisabledException(string message) : base(message)
		{

		}

		public int Code { get; } = 61;
	}

	/// <summary>
	/// Delegation Token is not found on server.
	/// </summary>
	public class DelegationTokenNotFoundException : Exception
	{
		public DelegationTokenNotFoundException()
		{

		}

		public DelegationTokenNotFoundException(string message) : base(message)
		{

		}

		public int Code { get; } = 62;
	}

	/// <summary>
	/// Specified Principal is not valid Owner/Renewer.
	/// </summary>
	public class DelegationTokenOwnerMismatchException : Exception
	{
		public DelegationTokenOwnerMismatchException()
		{

		}

		public DelegationTokenOwnerMismatchException(string message) : base(message)
		{

		}

		public int Code { get; } = 63;
	}

	/// <summary>
	/// Delegation Token requests are not allowed on PLAINTEXT/1-way SSL channels and on delegation token authenticated channels.
	/// </summary>
	public class DelegationTokenRequestNotAllowedException : Exception
	{
		public DelegationTokenRequestNotAllowedException()
		{

		}

		public DelegationTokenRequestNotAllowedException(string message) : base(message)
		{

		}

		public int Code { get; } = 64;
	}

	/// <summary>
	/// Delegation Token authorization failed.
	/// </summary>
	public class DelegationTokenAuthorizationFailedException : Exception
	{
		public DelegationTokenAuthorizationFailedException()
		{

		}

		public DelegationTokenAuthorizationFailedException(string message) : base(message)
		{

		}

		public int Code { get; } = 65;
	}

	/// <summary>
	/// Delegation Token is expired.
	/// </summary>
	public class DelegationTokenExpiredException : Exception
	{
		public DelegationTokenExpiredException()
		{

		}

		public DelegationTokenExpiredException(string message) : base(message)
		{

		}

		public int Code { get; } = 66;
	}

	/// <summary>
	/// Supplied principalType is not supported.
	/// </summary>
	public class InvalidPrincipalTypeException : Exception
	{
		public InvalidPrincipalTypeException()
		{

		}

		public InvalidPrincipalTypeException(string message) : base(message)
		{

		}

		public int Code { get; } = 67;
	}

	/// <summary>
	/// The group is not empty.
	/// </summary>
	public class NonEmptyGroupException : Exception
	{
		public NonEmptyGroupException()
		{

		}

		public NonEmptyGroupException(string message) : base(message)
		{

		}

		public int Code { get; } = 68;
	}

	/// <summary>
	/// The group id does not exist.
	/// </summary>
	public class GroupIdNotFoundException : Exception
	{
		public GroupIdNotFoundException()
		{

		}

		public GroupIdNotFoundException(string message) : base(message)
		{

		}

		public int Code { get; } = 69;
	}

	/// <summary>
	/// The fetch session ID was not found.
	/// </summary>
	public class FetchSessionIdNotFoundException : Exception
	{
		public FetchSessionIdNotFoundException()
		{

		}

		public FetchSessionIdNotFoundException(string message) : base(message)
		{

		}

		public int Code { get; } = 70;
	}

	/// <summary>
	/// The fetch session epoch is invalid.
	/// </summary>
	public class InvalidFetchSessionEpochException : Exception
	{
		public InvalidFetchSessionEpochException()
		{

		}

		public InvalidFetchSessionEpochException(string message) : base(message)
		{

		}

		public int Code { get; } = 71;
	}

	/// <summary>
	/// There is no listener on the leader broker that matches the listener on which metadata request was processed.
	/// </summary>
	public class ListenerNotFoundException : Exception
	{
		public ListenerNotFoundException()
		{

		}

		public ListenerNotFoundException(string message) : base(message)
		{

		}

		public int Code { get; } = 72;
	}

	/// <summary>
	/// Topic deletion is disabled.
	/// </summary>
	public class TopicDeletionDisabledException : Exception
	{
		public TopicDeletionDisabledException()
		{

		}

		public TopicDeletionDisabledException(string message) : base(message)
		{

		}

		public int Code { get; } = 73;
	}

	/// <summary>
	/// The leader epoch in the request is older than the epoch on the broker
	/// </summary>
	public class FencedLeaderEpochException : Exception
	{
		public FencedLeaderEpochException()
		{

		}

		public FencedLeaderEpochException(string message) : base(message)
		{

		}

		public int Code { get; } = 74;
	}

	/// <summary>
	/// The leader epoch in the request is newer than the epoch on the broker
	/// </summary>
	public class UnknownLeaderEpochException : Exception
	{
		public UnknownLeaderEpochException()
		{

		}

		public UnknownLeaderEpochException(string message) : base(message)
		{

		}

		public int Code { get; } = 75;
	}

	/// <summary>
	/// The requesting client does not support the compression type of given partition.
	/// </summary>
	public class UnsupportedCompressionTypeException : Exception
	{
		public UnsupportedCompressionTypeException()
		{

		}

		public UnsupportedCompressionTypeException(string message) : base(message)
		{

		}

		public int Code { get; } = 76;
	}

	public class AddOffsetsToTxnRequest
	{
		public AddOffsetsToTxnRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AddOffsetsToTxnRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 25;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerId = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerEpoch = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ProducerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ProducerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
		}

		/// <summary>
		/// The transactional id corresponding to the transaction.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId is non-nullable.");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// Current producer id in use by the transactional id.
		/// </summary>
		private Int64 _producerId = Int64.Default;
		public Int64 ProducerId 
		{
			get => _producerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerId is non-nullable.");
				}

				_producerId = value;
			}
		}

		/// <summary>
		/// Current epoch associated with the producer id.
		/// </summary>
		private Int16 _producerEpoch = Int16.Default;
		public Int16 ProducerEpoch 
		{
			get => _producerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
				}

				_producerEpoch = value;
			}
		}

		/// <summary>
		/// The unique group identifier.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}
	}

	public class AddOffsetsToTxnResponse
	{
		public AddOffsetsToTxnResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AddOffsetsToTxnResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 25;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// Duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The response error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class AddPartitionsToTxnRequest
	{
		public AddPartitionsToTxnRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AddPartitionsToTxnRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 24;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerId = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerEpoch = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new AddPartitionsToTxnTopic(Version)).ToDictionary(field => field.Name);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ProducerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ProducerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The transactional id corresponding to the transaction.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId is non-nullable.");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// Current producer id in use by the transactional id.
		/// </summary>
		private Int64 _producerId = Int64.Default;
		public Int64 ProducerId 
		{
			get => _producerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerId is non-nullable.");
				}

				_producerId = value;
			}
		}

		/// <summary>
		/// Current epoch associated with the producer id.
		/// </summary>
		private Int16 _producerEpoch = Int16.Default;
		public Int16 ProducerEpoch 
		{
			get => _producerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
				}

				_producerEpoch = value;
			}
		}

		/// <summary>
		/// The partitions to add to the transation.
		/// </summary>
		private Dictionary<String, AddPartitionsToTxnTopic> _topicsCollection = new Dictionary<String, AddPartitionsToTxnTopic>();
		public Dictionary<String, AddPartitionsToTxnTopic> TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public AddPartitionsToTxnTopic CreateAddPartitionsToTxnTopic()
		{
			return new AddPartitionsToTxnTopic(Version);
		}

		public class AddPartitionsToTxnTopic : ISerialize
		{
			internal AddPartitionsToTxnTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The name of the topic.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partition indexes to add to the transaction
			/// </summary>
			private Int32[] _partitionsCollection = System.Array.Empty<Int32>();
			public Int32[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}
		}
	}

	public class AddPartitionsToTxnResponse
	{
		public AddPartitionsToTxnResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AddPartitionsToTxnResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 24;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new AddPartitionsToTxnTopicResult(Version)).ToDictionary(field => field.Name);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// Duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each topic.
		/// </summary>
		private Dictionary<String, AddPartitionsToTxnTopicResult> _resultsCollection = new Dictionary<String, AddPartitionsToTxnTopicResult>();
		public Dictionary<String, AddPartitionsToTxnTopicResult> ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public AddPartitionsToTxnTopicResult CreateAddPartitionsToTxnTopicResult()
		{
			return new AddPartitionsToTxnTopicResult(Version);
		}

		public class AddPartitionsToTxnTopicResult : ISerialize
		{
			internal AddPartitionsToTxnTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResultsCollection = reader.Read(() => new AddPartitionsToTxnPartitionResult(Version)).ToDictionary(field => field.PartitionIndex);
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(ResultsCollection.Values.ToArray());
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The results for each partition
			/// </summary>
			private Dictionary<Int32, AddPartitionsToTxnPartitionResult> _resultsCollection = new Dictionary<Int32, AddPartitionsToTxnPartitionResult>();
			public Dictionary<Int32, AddPartitionsToTxnPartitionResult> ResultsCollection 
			{
				get => _resultsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
					}

					_resultsCollection = value;
				}
			}

			public AddPartitionsToTxnPartitionResult CreateAddPartitionsToTxnPartitionResult()
			{
				return new AddPartitionsToTxnPartitionResult(Version);
			}

			public class AddPartitionsToTxnPartitionResult : ISerialize
			{
				internal AddPartitionsToTxnPartitionResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partition indexes.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The response error code.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}
	}

	public class AlterConfigsRequest
	{
		public AlterConfigsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AlterConfigsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 33;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourcesCollection = reader.Read(() => new AlterConfigsResource(Version)).ToDictionary(field => field.ResourceType);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ValidateOnly = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResourcesCollection.Values.ToArray());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBoolean(ValidateOnly.Value);
			}
		}

		/// <summary>
		/// The updates for each resource.
		/// </summary>
		private Dictionary<Int8, AlterConfigsResource> _resourcesCollection = new Dictionary<Int8, AlterConfigsResource>();
		public Dictionary<Int8, AlterConfigsResource> ResourcesCollection 
		{
			get => _resourcesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection is non-nullable.");
				}

				_resourcesCollection = value;
			}
		}

		public AlterConfigsResource CreateAlterConfigsResource()
		{
			return new AlterConfigsResource(Version);
		}

		public class AlterConfigsResource : ISerialize
		{
			internal AlterConfigsResource(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ConfigsCollection = reader.Read(() => new AlterableConfig(Version)).ToDictionary(field => field.Name);
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(ConfigsCollection.Values.ToArray());
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _resourceType = Int8.Default;
			public Int8 ResourceType 
			{
				get => _resourceType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceType is non-nullable.");
					}

					_resourceType = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _resourceName = String.Default;
			public String ResourceName 
			{
				get => _resourceName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceName is non-nullable.");
					}

					_resourceName = value;
				}
			}

			/// <summary>
			/// The configurations.
			/// </summary>
			private Dictionary<String, AlterableConfig> _configsCollection = new Dictionary<String, AlterableConfig>();
			public Dictionary<String, AlterableConfig> ConfigsCollection 
			{
				get => _configsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection is non-nullable.");
					}

					_configsCollection = value;
				}
			}

			public AlterableConfig CreateAlterableConfig()
			{
				return new AlterableConfig(Version);
			}

			public class AlterableConfig : ISerialize
			{
				internal AlterableConfig(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Value = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Value.Value);
					}
				}

				/// <summary>
				/// The configuration key name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The value to set for the configuration key.
				/// </summary>
				private String _value = String.Default;
				public String Value 
				{
					get => _value;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Value does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Value does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_value = value;
					}
				}
			}
		}

		/// <summary>
		/// True if we should validate the request, but not change the configurations.
		/// </summary>
		private Boolean _validateOnly = Boolean.Default;
		public Boolean ValidateOnly 
		{
			get => _validateOnly;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ValidateOnly does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ValidateOnly is non-nullable.");
				}

				_validateOnly = value;
			}
		}
	}

	public class AlterConfigsResponse
	{
		public AlterConfigsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AlterConfigsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 33;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourcesCollection = reader.Read(() => new AlterConfigsResourceResponse(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResourcesCollection);
			}
		}

		/// <summary>
		/// Duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The responses for each resource.
		/// </summary>
		private AlterConfigsResourceResponse[] _resourcesCollection = System.Array.Empty<AlterConfigsResourceResponse>();
		public AlterConfigsResourceResponse[] ResourcesCollection 
		{
			get => _resourcesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection is non-nullable.");
				}

				_resourcesCollection = value;
			}
		}

		public AlterConfigsResourceResponse CreateAlterConfigsResourceResponse()
		{
			return new AlterConfigsResourceResponse(Version);
		}

		public class AlterConfigsResourceResponse : ISerialize
		{
			internal AlterConfigsResourceResponse(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceName = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceName.Value);
				}
			}

			/// <summary>
			/// The resource error code.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The resource error message, or null if there was no error.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _resourceType = Int8.Default;
			public Int8 ResourceType 
			{
				get => _resourceType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceType is non-nullable.");
					}

					_resourceType = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _resourceName = String.Default;
			public String ResourceName 
			{
				get => _resourceName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceName is non-nullable.");
					}

					_resourceName = value;
				}
			}
		}
	}

	public class AlterReplicaLogDirsRequest
	{
		public AlterReplicaLogDirsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AlterReplicaLogDirsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 34;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				DirsCollection = reader.Read(() => new AlterReplicaLogDir(Version)).ToDictionary(field => field.Path);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(DirsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The alterations to make for each directory.
		/// </summary>
		private Dictionary<String, AlterReplicaLogDir> _dirsCollection = new Dictionary<String, AlterReplicaLogDir>();
		public Dictionary<String, AlterReplicaLogDir> DirsCollection 
		{
			get => _dirsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"DirsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"DirsCollection is non-nullable.");
				}

				_dirsCollection = value;
			}
		}

		public AlterReplicaLogDir CreateAlterReplicaLogDir()
		{
			return new AlterReplicaLogDir(Version);
		}

		public class AlterReplicaLogDir : ISerialize
		{
			internal AlterReplicaLogDir(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Path = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicsCollection = reader.Read(() => new AlterReplicaLogDirTopic(Version)).ToDictionary(field => field.Name);
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Path.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(TopicsCollection.Values.ToArray());
				}
			}

			/// <summary>
			/// The absolute directory path.
			/// </summary>
			private String _path = String.Default;
			public String Path 
			{
				get => _path;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Path does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Path is non-nullable.");
					}

					_path = value;
				}
			}

			/// <summary>
			/// The topics to add to the directory.
			/// </summary>
			private Dictionary<String, AlterReplicaLogDirTopic> _topicsCollection = new Dictionary<String, AlterReplicaLogDirTopic>();
			public Dictionary<String, AlterReplicaLogDirTopic> TopicsCollection 
			{
				get => _topicsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
					}

					_topicsCollection = value;
				}
			}

			public AlterReplicaLogDirTopic CreateAlterReplicaLogDirTopic()
			{
				return new AlterReplicaLogDirTopic(Version);
			}

			public class AlterReplicaLogDirTopic : ISerialize
			{
				internal AlterReplicaLogDirTopic(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionsCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(PartitionsCollection);
					}
				}

				/// <summary>
				/// The topic name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The partition indexes.
				/// </summary>
				private Int32[] _partitionsCollection = System.Array.Empty<Int32>();
				public Int32[] PartitionsCollection 
				{
					get => _partitionsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
						}

						_partitionsCollection = value;
					}
				}
			}
		}
	}

	public class AlterReplicaLogDirsResponse
	{
		public AlterReplicaLogDirsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"AlterReplicaLogDirsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 34;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new AlterReplicaLogDirTopicResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection);
			}
		}

		/// <summary>
		/// Duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each topic.
		/// </summary>
		private AlterReplicaLogDirTopicResult[] _resultsCollection = System.Array.Empty<AlterReplicaLogDirTopicResult>();
		public AlterReplicaLogDirTopicResult[] ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public AlterReplicaLogDirTopicResult CreateAlterReplicaLogDirTopicResult()
		{
			return new AlterReplicaLogDirTopicResult(Version);
		}

		public class AlterReplicaLogDirTopicResult : ISerialize
		{
			internal AlterReplicaLogDirTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new AlterReplicaLogDirPartitionResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The name of the topic.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The results for each partition.
			/// </summary>
			private AlterReplicaLogDirPartitionResult[] _partitionsCollection = System.Array.Empty<AlterReplicaLogDirPartitionResult>();
			public AlterReplicaLogDirPartitionResult[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public AlterReplicaLogDirPartitionResult CreateAlterReplicaLogDirPartitionResult()
			{
				return new AlterReplicaLogDirPartitionResult(Version);
			}

			public class AlterReplicaLogDirPartitionResult : ISerialize
			{
				internal AlterReplicaLogDirPartitionResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}
	}

	public class ApiVersionsRequest
	{
		public ApiVersionsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ApiVersionsRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 18;

		public void ReadFrom(IKafkaReader reader)
		{

		}

		public void WriteTo(IKafkaWriter writer)
		{

		}


	}

	public class ApiVersionsResponse
	{
		public ApiVersionsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ApiVersionsResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 18;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ApiKeysCollection = reader.Read(() => new ApiVersionsResponseKey(Version)).ToDictionary(field => field.Index);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ApiKeysCollection.Values.ToArray());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// The top-level error code.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The APIs supported by the broker.
		/// </summary>
		private Dictionary<Int16, ApiVersionsResponseKey> _apiKeysCollection = new Dictionary<Int16, ApiVersionsResponseKey>();
		public Dictionary<Int16, ApiVersionsResponseKey> ApiKeysCollection 
		{
			get => _apiKeysCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ApiKeysCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ApiKeysCollection is non-nullable.");
				}

				_apiKeysCollection = value;
			}
		}

		public ApiVersionsResponseKey CreateApiVersionsResponseKey()
		{
			return new ApiVersionsResponseKey(Version);
		}

		public class ApiVersionsResponseKey : ISerialize
		{
			internal ApiVersionsResponseKey(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Index = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MinVersion = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MaxVersion = new Int16(reader.ReadInt16());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(Index.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(MinVersion.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(MaxVersion.Value);
				}
			}

			/// <summary>
			/// The API index.
			/// </summary>
			private Int16 _index = Int16.Default;
			public Int16 Index 
			{
				get => _index;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Index does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Index is non-nullable.");
					}

					_index = value;
				}
			}

			/// <summary>
			/// The minimum supported version, inclusive.
			/// </summary>
			private Int16 _minVersion = Int16.Default;
			public Int16 MinVersion 
			{
				get => _minVersion;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MinVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MinVersion is non-nullable.");
					}

					_minVersion = value;
				}
			}

			/// <summary>
			/// The maximum supported version, inclusive.
			/// </summary>
			private Int16 _maxVersion = Int16.Default;
			public Int16 MaxVersion 
			{
				get => _maxVersion;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MaxVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MaxVersion is non-nullable.");
					}

					_maxVersion = value;
				}
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class ControlledShutdownRequest
	{
		public ControlledShutdownRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ControlledShutdownRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 7;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				BrokerId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				BrokerEpoch = new Int64(reader.ReadInt64());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(BrokerId.Value);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt64(BrokerEpoch.Value);
			}
		}

		/// <summary>
		/// The id of the broker for which controlled shutdown has been requested.
		/// </summary>
		private Int32 _brokerId = Int32.Default;
		public Int32 BrokerId 
		{
			get => _brokerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"BrokerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokerId is non-nullable.");
				}

				_brokerId = value;
			}
		}

		/// <summary>
		/// The broker epoch.
		/// </summary>
		private Int64 _brokerEpoch = new Int64(-1);
		public Int64 BrokerEpoch 
		{
			get => _brokerEpoch;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokerEpoch is non-nullable.");
				}

				_brokerEpoch = value;
			}
		}
	}

	public class ControlledShutdownResponse
	{
		public ControlledShutdownResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ControlledShutdownResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 7;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				RemainingPartitionsCollection = reader.Read(() => new RemainingPartition(Version)).ToDictionary(field => field.TopicName);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(RemainingPartitionsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The top-level error code.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The partitions that the broker still leads.
		/// </summary>
		private Dictionary<String, RemainingPartition> _remainingPartitionsCollection = new Dictionary<String, RemainingPartition>();
		public Dictionary<String, RemainingPartition> RemainingPartitionsCollection 
		{
			get => _remainingPartitionsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"RemainingPartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"RemainingPartitionsCollection is non-nullable.");
				}

				_remainingPartitionsCollection = value;
			}
		}

		public RemainingPartition CreateRemainingPartition()
		{
			return new RemainingPartition(Version);
		}

		public class RemainingPartition : ISerialize
		{
			internal RemainingPartition(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
			}

			/// <summary>
			/// The name of the topic.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The index of the partition.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}
		}
	}

	public class CreateAclsRequest
	{
		public CreateAclsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreateAclsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 30;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				CreationsCollection = reader.Read(() => new CreatableAcl(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(CreationsCollection);
			}
		}

		/// <summary>
		/// The ACLs that we want to create.
		/// </summary>
		private CreatableAcl[] _creationsCollection = System.Array.Empty<CreatableAcl>();
		public CreatableAcl[] CreationsCollection 
		{
			get => _creationsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"CreationsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"CreationsCollection is non-nullable.");
				}

				_creationsCollection = value;
			}
		}

		public CreatableAcl CreateCreatableAcl()
		{
			return new CreatableAcl(Version);
		}

		public class CreatableAcl : ISerialize
		{
			internal CreatableAcl(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					ResourcePatternType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Principal = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Host = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Operation = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PermissionType = new Int8(reader.ReadInt8());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceName.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteInt8(ResourcePatternType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Principal.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Host.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(Operation.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(PermissionType.Value);
				}
			}

			/// <summary>
			/// The type of the resource.
			/// </summary>
			private Int8 _resourceType = Int8.Default;
			public Int8 ResourceType 
			{
				get => _resourceType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceType is non-nullable.");
					}

					_resourceType = value;
				}
			}

			/// <summary>
			/// The resource name for the ACL.
			/// </summary>
			private String _resourceName = String.Default;
			public String ResourceName 
			{
				get => _resourceName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceName is non-nullable.");
					}

					_resourceName = value;
				}
			}

			/// <summary>
			/// The pattern type for the ACL.
			/// </summary>
			private Int8 _resourcePatternType = new Int8(3);
			public Int8 ResourcePatternType 
			{
				get => _resourcePatternType;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourcePatternType does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourcePatternType is non-nullable.");
					}

					_resourcePatternType = value;
				}
			}

			/// <summary>
			/// The principal for the ACL.
			/// </summary>
			private String _principal = String.Default;
			public String Principal 
			{
				get => _principal;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Principal does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Principal is non-nullable.");
					}

					_principal = value;
				}
			}

			/// <summary>
			/// The host for the ACL.
			/// </summary>
			private String _host = String.Default;
			public String Host 
			{
				get => _host;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Host is non-nullable.");
					}

					_host = value;
				}
			}

			/// <summary>
			/// The operation type for the ACL (read, write, etc.).
			/// </summary>
			private Int8 _operation = Int8.Default;
			public Int8 Operation 
			{
				get => _operation;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Operation does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Operation is non-nullable.");
					}

					_operation = value;
				}
			}

			/// <summary>
			/// The permission type for the ACL (allow, deny, etc.).
			/// </summary>
			private Int8 _permissionType = Int8.Default;
			public Int8 PermissionType 
			{
				get => _permissionType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PermissionType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PermissionType is non-nullable.");
					}

					_permissionType = value;
				}
			}
		}
	}

	public class CreateAclsResponse
	{
		public CreateAclsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreateAclsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 30;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new CreatableAclResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each ACL creation.
		/// </summary>
		private CreatableAclResult[] _resultsCollection = System.Array.Empty<CreatableAclResult>();
		public CreatableAclResult[] ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public CreatableAclResult CreateCreatableAclResult()
		{
			return new CreatableAclResult(Version);
		}

		public class CreatableAclResult : ISerialize
		{
			internal CreatableAclResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
			}

			/// <summary>
			/// The result error, or zero if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The result message, or null if there was no error.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}
		}
	}

	public class CreateDelegationTokenRequest
	{
		public CreateDelegationTokenRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreateDelegationTokenRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 38;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				RenewersCollection = reader.Read(() => new CreatableRenewers(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MaxLifetimeMs = new Int64(reader.ReadInt64());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(RenewersCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(MaxLifetimeMs.Value);
			}
		}

		/// <summary>
		/// A list of those who are allowed to renew this token before it expires.
		/// </summary>
		private CreatableRenewers[] _renewersCollection = System.Array.Empty<CreatableRenewers>();
		public CreatableRenewers[] RenewersCollection 
		{
			get => _renewersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"RenewersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"RenewersCollection is non-nullable.");
				}

				_renewersCollection = value;
			}
		}

		public CreatableRenewers CreateCreatableRenewers()
		{
			return new CreatableRenewers(Version);
		}

		public class CreatableRenewers : ISerialize
		{
			internal CreatableRenewers(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalType = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalName = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalName.Value);
				}
			}

			/// <summary>
			/// The type of the Kafka principal.
			/// </summary>
			private String _principalType = String.Default;
			public String PrincipalType 
			{
				get => _principalType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalType is non-nullable.");
					}

					_principalType = value;
				}
			}

			/// <summary>
			/// The name of the Kafka principal.
			/// </summary>
			private String _principalName = String.Default;
			public String PrincipalName 
			{
				get => _principalName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalName is non-nullable.");
					}

					_principalName = value;
				}
			}
		}

		/// <summary>
		/// The maximum lifetime of the token in milliseconds, or -1 to use the server side default.
		/// </summary>
		private Int64 _maxLifetimeMs = Int64.Default;
		public Int64 MaxLifetimeMs 
		{
			get => _maxLifetimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MaxLifetimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MaxLifetimeMs is non-nullable.");
				}

				_maxLifetimeMs = value;
			}
		}
	}

	public class CreateDelegationTokenResponse
	{
		public CreateDelegationTokenResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreateDelegationTokenResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 38;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PrincipalType = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PrincipalName = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				IssueTimestampMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ExpiryTimestampMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MaxTimestampMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TokenId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Hmac = new Bytes(reader.ReadBytes());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(PrincipalType.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(PrincipalName.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(IssueTimestampMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ExpiryTimestampMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(MaxTimestampMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TokenId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(Hmac.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// The top-level error, or zero if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The principal type of the token owner.
		/// </summary>
		private String _principalType = String.Default;
		public String PrincipalType 
		{
			get => _principalType;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PrincipalType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PrincipalType is non-nullable.");
				}

				_principalType = value;
			}
		}

		/// <summary>
		/// The name of the token owner.
		/// </summary>
		private String _principalName = String.Default;
		public String PrincipalName 
		{
			get => _principalName;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PrincipalName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PrincipalName is non-nullable.");
				}

				_principalName = value;
			}
		}

		/// <summary>
		/// When this token was generated.
		/// </summary>
		private Int64 _issueTimestampMs = Int64.Default;
		public Int64 IssueTimestampMs 
		{
			get => _issueTimestampMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IssueTimestampMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IssueTimestampMs is non-nullable.");
				}

				_issueTimestampMs = value;
			}
		}

		/// <summary>
		/// When this token expires.
		/// </summary>
		private Int64 _expiryTimestampMs = Int64.Default;
		public Int64 ExpiryTimestampMs 
		{
			get => _expiryTimestampMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs is non-nullable.");
				}

				_expiryTimestampMs = value;
			}
		}

		/// <summary>
		/// The maximum lifetime of this token.
		/// </summary>
		private Int64 _maxTimestampMs = Int64.Default;
		public Int64 MaxTimestampMs 
		{
			get => _maxTimestampMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MaxTimestampMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MaxTimestampMs is non-nullable.");
				}

				_maxTimestampMs = value;
			}
		}

		/// <summary>
		/// The token UUID.
		/// </summary>
		private String _tokenId = String.Default;
		public String TokenId 
		{
			get => _tokenId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TokenId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TokenId is non-nullable.");
				}

				_tokenId = value;
			}
		}

		/// <summary>
		/// HMAC of the delegation token.
		/// </summary>
		private Bytes _hmac = Bytes.Default;
		public Bytes Hmac 
		{
			get => _hmac;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Hmac does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Hmac is non-nullable.");
				}

				_hmac = value;
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class CreatePartitionsRequest
	{
		public CreatePartitionsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreatePartitionsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 37;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new CreatePartitionsTopic(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TimeoutMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ValidateOnly = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TimeoutMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBoolean(ValidateOnly.Value);
			}
		}

		/// <summary>
		/// Each topic that we want to create new partitions inside.
		/// </summary>
		private CreatePartitionsTopic[] _topicsCollection = System.Array.Empty<CreatePartitionsTopic>();
		public CreatePartitionsTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public CreatePartitionsTopic CreateCreatePartitionsTopic()
		{
			return new CreatePartitionsTopic(Version);
		}

		public class CreatePartitionsTopic : ISerialize
		{
			internal CreatePartitionsTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Count = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					AssignmentsCollection = reader.Read(() => new CreatePartitionsAssignment(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(Count.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(AssignmentsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The new partition count.
			/// </summary>
			private Int32 _count = Int32.Default;
			public Int32 Count 
			{
				get => _count;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Count does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Count is non-nullable.");
					}

					_count = value;
				}
			}

			/// <summary>
			/// The new partition assignments.
			/// </summary>
			private CreatePartitionsAssignment[] _assignmentsCollection = System.Array.Empty<CreatePartitionsAssignment>();
			public CreatePartitionsAssignment[] AssignmentsCollection 
			{
				get => _assignmentsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"AssignmentsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"AssignmentsCollection does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_assignmentsCollection = value;
				}
			}

			public CreatePartitionsAssignment CreateCreatePartitionsAssignment()
			{
				return new CreatePartitionsAssignment(Version);
			}

			public class CreatePartitionsAssignment : ISerialize
			{
				internal CreatePartitionsAssignment(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						BrokerIdsCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(BrokerIdsCollection);
					}
				}

				/// <summary>
				/// The assigned broker IDs.
				/// </summary>
				private Int32[] _brokerIdsCollection = System.Array.Empty<Int32>();
				public Int32[] BrokerIdsCollection 
				{
					get => _brokerIdsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"BrokerIdsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"BrokerIdsCollection is non-nullable.");
						}

						_brokerIdsCollection = value;
					}
				}
			}
		}

		/// <summary>
		/// The time in ms to wait for the partitions to be created.
		/// </summary>
		private Int32 _timeoutMs = Int32.Default;
		public Int32 TimeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TimeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}

		/// <summary>
		/// If true, then validate the request, but don't actually increase the number of partitions.
		/// </summary>
		private Boolean _validateOnly = Boolean.Default;
		public Boolean ValidateOnly 
		{
			get => _validateOnly;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ValidateOnly does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ValidateOnly is non-nullable.");
				}

				_validateOnly = value;
			}
		}
	}

	public class CreatePartitionsResponse
	{
		public CreatePartitionsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"CreatePartitionsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 37;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new CreatePartitionsTopicResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The partition creation results for each topic.
		/// </summary>
		private CreatePartitionsTopicResult[] _resultsCollection = System.Array.Empty<CreatePartitionsTopicResult>();
		public CreatePartitionsTopicResult[] ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public CreatePartitionsTopicResult CreateCreatePartitionsTopicResult()
		{
			return new CreatePartitionsTopicResult(Version);
		}

		public class CreatePartitionsTopicResult : ISerialize
		{
			internal CreatePartitionsTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The result error, or zero if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The result message, or null if there was no error.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}
		}
	}

	public class CreateTopicsRequest
	{
		public CreateTopicsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"CreateTopicsRequest does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 19;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new CreatableTopic(Version)).ToDictionary(field => field.Name);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				timeoutMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				validateOnly = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection.Values.ToArray());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(timeoutMs.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteBoolean(validateOnly.Value);
			}
		}

		/// <summary>
		/// The topics to create.
		/// </summary>
		private Dictionary<String, CreatableTopic> _topicsCollection = new Dictionary<String, CreatableTopic>();
		public Dictionary<String, CreatableTopic> TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public CreatableTopic CreateCreatableTopic()
		{
			return new CreatableTopic(Version);
		}

		public class CreatableTopic : ISerialize
		{
			internal CreatableTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					NumPartitions = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ReplicationFactor = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					AssignmentsCollection = reader.Read(() => new CreatableReplicaAssignment(Version)).ToDictionary(field => field.PartitionIndex);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ConfigsCollection = reader.Read(() => new CreateableTopicConfig(Version)).ToDictionary(field => field.Name);
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(NumPartitions.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ReplicationFactor.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(AssignmentsCollection.Values.ToArray());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(ConfigsCollection.Values.ToArray());
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The number of partitions to create in the topic, or -1 if we are specifying a manual partition assignment.
			/// </summary>
			private Int32 _numPartitions = Int32.Default;
			public Int32 NumPartitions 
			{
				get => _numPartitions;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"NumPartitions does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"NumPartitions is non-nullable.");
					}

					_numPartitions = value;
				}
			}

			/// <summary>
			/// The number of replicas to create for each partition in the topic, or -1 if we are specifying a manual partition assignment.
			/// </summary>
			private Int16 _replicationFactor = Int16.Default;
			public Int16 ReplicationFactor 
			{
				get => _replicationFactor;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ReplicationFactor does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ReplicationFactor is non-nullable.");
					}

					_replicationFactor = value;
				}
			}

			/// <summary>
			/// The manual partition assignment, or the empty array if we are using automatic assignment.
			/// </summary>
			private Dictionary<Int32, CreatableReplicaAssignment> _assignmentsCollection = new Dictionary<Int32, CreatableReplicaAssignment>();
			public Dictionary<Int32, CreatableReplicaAssignment> AssignmentsCollection 
			{
				get => _assignmentsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"AssignmentsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"AssignmentsCollection is non-nullable.");
					}

					_assignmentsCollection = value;
				}
			}

			public CreatableReplicaAssignment CreateCreatableReplicaAssignment()
			{
				return new CreatableReplicaAssignment(Version);
			}

			public class CreatableReplicaAssignment : ISerialize
			{
				internal CreatableReplicaAssignment(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						BrokerIdsCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(BrokerIdsCollection);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The brokers to place the partition on.
				/// </summary>
				private Int32[] _brokerIdsCollection = System.Array.Empty<Int32>();
				public Int32[] BrokerIdsCollection 
				{
					get => _brokerIdsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"BrokerIdsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"BrokerIdsCollection is non-nullable.");
						}

						_brokerIdsCollection = value;
					}
				}
			}

			/// <summary>
			/// The custom topic configurations to set.
			/// </summary>
			private Dictionary<String, CreateableTopicConfig> _configsCollection = new Dictionary<String, CreateableTopicConfig>();
			public Dictionary<String, CreateableTopicConfig> ConfigsCollection 
			{
				get => _configsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection is non-nullable.");
					}

					_configsCollection = value;
				}
			}

			public CreateableTopicConfig CreateCreateableTopicConfig()
			{
				return new CreateableTopicConfig(Version);
			}

			public class CreateableTopicConfig : ISerialize
			{
				internal CreateableTopicConfig(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Value = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Value.Value);
					}
				}

				/// <summary>
				/// The configuration name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The configuration value.
				/// </summary>
				private String _value = String.Default;
				public String Value 
				{
					get => _value;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Value does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Value does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_value = value;
					}
				}
			}
		}

		/// <summary>
		/// How long to wait in milliseconds before timing out the request.
		/// </summary>
		private Int32 _timeoutMs = new Int32(60000);
		public Int32 timeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"timeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"timeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}

		/// <summary>
		/// If true, check that the topics can be created as specified, but don't create anything.
		/// </summary>
		private Boolean _validateOnly = new Boolean(false);
		public Boolean validateOnly 
		{
			get => _validateOnly;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"validateOnly does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"validateOnly is non-nullable.");
				}

				_validateOnly = value;
			}
		}
	}

	public class CreateTopicsResponse
	{
		public CreateTopicsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"CreateTopicsResponse does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 19;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new CreatableTopicResult(Version)).ToDictionary(field => field.Name);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Results for each topic we tried to create.
		/// </summary>
		private Dictionary<String, CreatableTopicResult> _topicsCollection = new Dictionary<String, CreatableTopicResult>();
		public Dictionary<String, CreatableTopicResult> TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public CreatableTopicResult CreateCreatableTopicResult()
		{
			return new CreatableTopicResult(Version);
		}

		public class CreatableTopicResult : ISerialize
		{
			internal CreatableTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The error code, or 0 if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The error message, or null if there was no error.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}
		}
	}

	public class DeleteAclsRequest
	{
		public DeleteAclsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteAclsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 31;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				FiltersCollection = reader.Read(() => new DeleteAclsFilter(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(FiltersCollection);
			}
		}

		/// <summary>
		/// The filters to use when deleting ACLs.
		/// </summary>
		private DeleteAclsFilter[] _filtersCollection = System.Array.Empty<DeleteAclsFilter>();
		public DeleteAclsFilter[] FiltersCollection 
		{
			get => _filtersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"FiltersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"FiltersCollection is non-nullable.");
				}

				_filtersCollection = value;
			}
		}

		public DeleteAclsFilter CreateDeleteAclsFilter()
		{
			return new DeleteAclsFilter(Version);
		}

		public class DeleteAclsFilter : ISerialize
		{
			internal DeleteAclsFilter(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceTypeFilter = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceNameFilter = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					PatternTypeFilter = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalFilter = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					HostFilter = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Operation = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PermissionType = new Int8(reader.ReadInt8());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceTypeFilter.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceNameFilter.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteInt8(PatternTypeFilter.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalFilter.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(HostFilter.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(Operation.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(PermissionType.Value);
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _resourceTypeFilter = Int8.Default;
			public Int8 ResourceTypeFilter 
			{
				get => _resourceTypeFilter;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceTypeFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceTypeFilter is non-nullable.");
					}

					_resourceTypeFilter = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _resourceNameFilter = String.Default;
			public String ResourceNameFilter 
			{
				get => _resourceNameFilter;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceNameFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ResourceNameFilter does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_resourceNameFilter = value;
				}
			}

			/// <summary>
			/// The pattern type.
			/// </summary>
			private Int8 _patternTypeFilter = new Int8(3);
			public Int8 PatternTypeFilter 
			{
				get => _patternTypeFilter;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PatternTypeFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PatternTypeFilter is non-nullable.");
					}

					_patternTypeFilter = value;
				}
			}

			/// <summary>
			/// The principal filter, or null to accept all principals.
			/// </summary>
			private String _principalFilter = String.Default;
			public String PrincipalFilter 
			{
				get => _principalFilter;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalFilter does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_principalFilter = value;
				}
			}

			/// <summary>
			/// The host filter, or null to accept all hosts.
			/// </summary>
			private String _hostFilter = String.Default;
			public String HostFilter 
			{
				get => _hostFilter;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"HostFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"HostFilter does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_hostFilter = value;
				}
			}

			/// <summary>
			/// The ACL operation.
			/// </summary>
			private Int8 _operation = Int8.Default;
			public Int8 Operation 
			{
				get => _operation;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Operation does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Operation is non-nullable.");
					}

					_operation = value;
				}
			}

			/// <summary>
			/// The permission type.
			/// </summary>
			private Int8 _permissionType = Int8.Default;
			public Int8 PermissionType 
			{
				get => _permissionType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PermissionType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PermissionType is non-nullable.");
					}

					_permissionType = value;
				}
			}
		}
	}

	public class DeleteAclsResponse
	{
		public DeleteAclsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteAclsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 31;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				FilterResultsCollection = reader.Read(() => new DeleteAclsFilterResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(FilterResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each filter.
		/// </summary>
		private DeleteAclsFilterResult[] _filterResultsCollection = System.Array.Empty<DeleteAclsFilterResult>();
		public DeleteAclsFilterResult[] FilterResultsCollection 
		{
			get => _filterResultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"FilterResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"FilterResultsCollection is non-nullable.");
				}

				_filterResultsCollection = value;
			}
		}

		public DeleteAclsFilterResult CreateDeleteAclsFilterResult()
		{
			return new DeleteAclsFilterResult(Version);
		}

		public class DeleteAclsFilterResult : ISerialize
		{
			internal DeleteAclsFilterResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MatchingAclsCollection = reader.Read(() => new DeleteAclsMatchingAcl(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(MatchingAclsCollection);
				}
			}

			/// <summary>
			/// The error code, or 0 if the filter succeeded.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The error message, or null if the filter succeeded.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}

			/// <summary>
			/// The ACLs which matched this filter.
			/// </summary>
			private DeleteAclsMatchingAcl[] _matchingAclsCollection = System.Array.Empty<DeleteAclsMatchingAcl>();
			public DeleteAclsMatchingAcl[] MatchingAclsCollection 
			{
				get => _matchingAclsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MatchingAclsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MatchingAclsCollection is non-nullable.");
					}

					_matchingAclsCollection = value;
				}
			}

			public DeleteAclsMatchingAcl CreateDeleteAclsMatchingAcl()
			{
				return new DeleteAclsMatchingAcl(Version);
			}

			public class DeleteAclsMatchingAcl : ISerialize
			{
				internal DeleteAclsMatchingAcl(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorMessage = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ResourceType = new Int8(reader.ReadInt8());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ResourceName = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						PatternType = new Int8(reader.ReadInt8());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Principal = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Host = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Operation = new Int8(reader.ReadInt8());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PermissionType = new Int8(reader.ReadInt8());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(ErrorMessage.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt8(ResourceType.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(ResourceName.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt8(PatternType.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Principal.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Host.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt8(Operation.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt8(PermissionType.Value);
					}
				}

				/// <summary>
				/// The deletion error code, or 0 if the deletion succeeded.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The deletion error message, or null if the deletion succeeded.
				/// </summary>
				private String _errorMessage = String.Default;
				public String ErrorMessage 
				{
					get => _errorMessage;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_errorMessage = value;
					}
				}

				/// <summary>
				/// The ACL resource type.
				/// </summary>
				private Int8 _resourceType = Int8.Default;
				public Int8 ResourceType 
				{
					get => _resourceType;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ResourceType is non-nullable.");
						}

						_resourceType = value;
					}
				}

				/// <summary>
				/// The ACL resource name.
				/// </summary>
				private String _resourceName = String.Default;
				public String ResourceName 
				{
					get => _resourceName;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ResourceName is non-nullable.");
						}

						_resourceName = value;
					}
				}

				/// <summary>
				/// The ACL resource pattern type.
				/// </summary>
				private Int8 _patternType = new Int8(3);
				public Int8 PatternType 
				{
					get => _patternType;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PatternType does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PatternType is non-nullable.");
						}

						_patternType = value;
					}
				}

				/// <summary>
				/// The ACL principal.
				/// </summary>
				private String _principal = String.Default;
				public String Principal 
				{
					get => _principal;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Principal does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Principal is non-nullable.");
						}

						_principal = value;
					}
				}

				/// <summary>
				/// The ACL host.
				/// </summary>
				private String _host = String.Default;
				public String Host 
				{
					get => _host;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Host is non-nullable.");
						}

						_host = value;
					}
				}

				/// <summary>
				/// The ACL operation.
				/// </summary>
				private Int8 _operation = Int8.Default;
				public Int8 Operation 
				{
					get => _operation;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Operation does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Operation is non-nullable.");
						}

						_operation = value;
					}
				}

				/// <summary>
				/// The ACL permission type.
				/// </summary>
				private Int8 _permissionType = Int8.Default;
				public Int8 PermissionType 
				{
					get => _permissionType;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PermissionType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PermissionType is non-nullable.");
						}

						_permissionType = value;
					}
				}
			}
		}
	}

	public class DeleteGroupsRequest
	{
		public DeleteGroupsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteGroupsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 42;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupsNamesCollection = reader.Read(() => new String(reader.ReadString()));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(GroupsNamesCollection);
			}
		}

		/// <summary>
		/// The group names to delete.
		/// </summary>
		private String[] _groupsNamesCollection = System.Array.Empty<String>();
		public String[] GroupsNamesCollection 
		{
			get => _groupsNamesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupsNamesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupsNamesCollection is non-nullable.");
				}

				_groupsNamesCollection = value;
			}
		}
	}

	public class DeleteGroupsResponse
	{
		public DeleteGroupsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteGroupsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 42;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new DeletableGroupResult(Version)).ToDictionary(field => field.GroupId);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The deletion results
		/// </summary>
		private Dictionary<String, DeletableGroupResult> _resultsCollection = new Dictionary<String, DeletableGroupResult>();
		public Dictionary<String, DeletableGroupResult> ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public DeletableGroupResult CreateDeletableGroupResult()
		{
			return new DeletableGroupResult(Version);
		}

		public class DeletableGroupResult : ISerialize
		{
			internal DeletableGroupResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					GroupId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(GroupId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
			}

			/// <summary>
			/// The group id
			/// </summary>
			private String _groupId = String.Default;
			public String GroupId 
			{
				get => _groupId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"GroupId is non-nullable.");
					}

					_groupId = value;
				}
			}

			/// <summary>
			/// The deletion error, or 0 if the deletion succeeded.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}
		}
	}

	public class DeleteRecordsRequest
	{
		public DeleteRecordsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteRecordsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 21;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new DeleteRecordsTopic(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TimeoutMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TimeoutMs.Value);
			}
		}

		/// <summary>
		/// Each topic that we want to delete records from.
		/// </summary>
		private DeleteRecordsTopic[] _topicsCollection = System.Array.Empty<DeleteRecordsTopic>();
		public DeleteRecordsTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public DeleteRecordsTopic CreateDeleteRecordsTopic()
		{
			return new DeleteRecordsTopic(Version);
		}

		public class DeleteRecordsTopic : ISerialize
		{
			internal DeleteRecordsTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new DeleteRecordsPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition that we want to delete records from.
			/// </summary>
			private DeleteRecordsPartition[] _partitionsCollection = System.Array.Empty<DeleteRecordsPartition>();
			public DeleteRecordsPartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public DeleteRecordsPartition CreateDeleteRecordsPartition()
			{
				return new DeleteRecordsPartition(Version);
			}

			public class DeleteRecordsPartition : ISerialize
			{
				internal DeleteRecordsPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Offset = new Int64(reader.ReadInt64());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(Offset.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The deletion offset.
				/// </summary>
				private Int64 _offset = Int64.Default;
				public Int64 Offset 
				{
					get => _offset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Offset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Offset is non-nullable.");
						}

						_offset = value;
					}
				}
			}
		}

		/// <summary>
		/// How long to wait for the deletion to complete, in milliseconds.
		/// </summary>
		private Int32 _timeoutMs = Int32.Default;
		public Int32 TimeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TimeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}
	}

	public class DeleteRecordsResponse
	{
		public DeleteRecordsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteRecordsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 21;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new DeleteRecordsTopicResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Each topic that we wanted to delete records from.
		/// </summary>
		private DeleteRecordsTopicResult[] _topicsCollection = System.Array.Empty<DeleteRecordsTopicResult>();
		public DeleteRecordsTopicResult[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public DeleteRecordsTopicResult CreateDeleteRecordsTopicResult()
		{
			return new DeleteRecordsTopicResult(Version);
		}

		public class DeleteRecordsTopicResult : ISerialize
		{
			internal DeleteRecordsTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new DeleteRecordsPartitionResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition that we wanted to delete records from.
			/// </summary>
			private DeleteRecordsPartitionResult[] _partitionsCollection = System.Array.Empty<DeleteRecordsPartitionResult>();
			public DeleteRecordsPartitionResult[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public DeleteRecordsPartitionResult CreateDeleteRecordsPartitionResult()
			{
				return new DeleteRecordsPartitionResult(Version);
			}

			public class DeleteRecordsPartitionResult : ISerialize
			{
				internal DeleteRecordsPartitionResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						LowWatermark = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(LowWatermark.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The partition low water mark.
				/// </summary>
				private Int64 _lowWatermark = Int64.Default;
				public Int64 LowWatermark 
				{
					get => _lowWatermark;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LowWatermark does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LowWatermark is non-nullable.");
						}

						_lowWatermark = value;
					}
				}

				/// <summary>
				/// The deletion error code, or 0 if the deletion succeeded.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}
	}

	public class DeleteTopicsRequest
	{
		public DeleteTopicsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteTopicsRequest does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 20;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicNamesCollection = reader.Read(() => new String(reader.ReadString()));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TimeoutMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicNamesCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TimeoutMs.Value);
			}
		}

		/// <summary>
		/// The names of the topics to delete
		/// </summary>
		private String[] _topicNamesCollection = System.Array.Empty<String>();
		public String[] TopicNamesCollection 
		{
			get => _topicNamesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicNamesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicNamesCollection is non-nullable.");
				}

				_topicNamesCollection = value;
			}
		}

		/// <summary>
		/// The length of time in milliseconds to wait for the deletions to complete.
		/// </summary>
		private Int32 _timeoutMs = Int32.Default;
		public Int32 TimeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TimeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}
	}

	public class DeleteTopicsResponse
	{
		public DeleteTopicsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"DeleteTopicsResponse does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 20;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResponsesCollection = reader.Read(() => new DeletableTopicResult(Version)).ToDictionary(field => field.Name);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResponsesCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each topic we tried to delete.
		/// </summary>
		private Dictionary<String, DeletableTopicResult> _responsesCollection = new Dictionary<String, DeletableTopicResult>();
		public Dictionary<String, DeletableTopicResult> ResponsesCollection 
		{
			get => _responsesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResponsesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResponsesCollection is non-nullable.");
				}

				_responsesCollection = value;
			}
		}

		public DeletableTopicResult CreateDeletableTopicResult()
		{
			return new DeletableTopicResult(Version);
		}

		public class DeletableTopicResult : ISerialize
		{
			internal DeletableTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
			}

			/// <summary>
			/// The topic name
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The deletion error, or 0 if the deletion succeeded.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}
		}
	}

	public class DescribeAclsRequest
	{
		public DescribeAclsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeAclsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 29;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourceType = new Int8(reader.ReadInt8());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourceNameFilter = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ResourcePatternType = new Int8(reader.ReadInt8());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PrincipalFilter = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				HostFilter = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Operation = new Int8(reader.ReadInt8());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PermissionType = new Int8(reader.ReadInt8());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt8(ResourceType.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ResourceNameFilter.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt8(ResourcePatternType.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(PrincipalFilter.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(HostFilter.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt8(Operation.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt8(PermissionType.Value);
			}
		}

		/// <summary>
		/// The resource type.
		/// </summary>
		private Int8 _resourceType = Int8.Default;
		public Int8 ResourceType 
		{
			get => _resourceType;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourceType is non-nullable.");
				}

				_resourceType = value;
			}
		}

		/// <summary>
		/// The resource name, or null to match any resource name.
		/// </summary>
		private String _resourceNameFilter = String.Default;
		public String ResourceNameFilter 
		{
			get => _resourceNameFilter;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourceNameFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"ResourceNameFilter does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_resourceNameFilter = value;
			}
		}

		/// <summary>
		/// The resource pattern to match.
		/// </summary>
		private Int8 _resourcePatternType = new Int8(3);
		public Int8 ResourcePatternType 
		{
			get => _resourcePatternType;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourcePatternType does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourcePatternType is non-nullable.");
				}

				_resourcePatternType = value;
			}
		}

		/// <summary>
		/// The principal to match, or null to match any principal.
		/// </summary>
		private String _principalFilter = String.Default;
		public String PrincipalFilter 
		{
			get => _principalFilter;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PrincipalFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"PrincipalFilter does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_principalFilter = value;
			}
		}

		/// <summary>
		/// The host to match, or null to match any host.
		/// </summary>
		private String _hostFilter = String.Default;
		public String HostFilter 
		{
			get => _hostFilter;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"HostFilter does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"HostFilter does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_hostFilter = value;
			}
		}

		/// <summary>
		/// The operation to match.
		/// </summary>
		private Int8 _operation = Int8.Default;
		public Int8 Operation 
		{
			get => _operation;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Operation does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Operation is non-nullable.");
				}

				_operation = value;
			}
		}

		/// <summary>
		/// The permission type to match.
		/// </summary>
		private Int8 _permissionType = Int8.Default;
		public Int8 PermissionType 
		{
			get => _permissionType;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PermissionType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PermissionType is non-nullable.");
				}

				_permissionType = value;
			}
		}
	}

	public class DescribeAclsResponse
	{
		public DescribeAclsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeAclsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 29;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorMessage = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourcesCollection = reader.Read(() => new DescribeAclsResource(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ErrorMessage.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResourcesCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The error message, or null if there was no error.
		/// </summary>
		private String _errorMessage = String.Default;
		public String ErrorMessage 
		{
			get => _errorMessage;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_errorMessage = value;
			}
		}

		/// <summary>
		/// Each Resource that is referenced in an ACL.
		/// </summary>
		private DescribeAclsResource[] _resourcesCollection = System.Array.Empty<DescribeAclsResource>();
		public DescribeAclsResource[] ResourcesCollection 
		{
			get => _resourcesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection is non-nullable.");
				}

				_resourcesCollection = value;
			}
		}

		public DescribeAclsResource CreateDescribeAclsResource()
		{
			return new DescribeAclsResource(Version);
		}

		public class DescribeAclsResource : ISerialize
		{
			internal DescribeAclsResource(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Type = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					PatternType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					AclsCollection = reader.Read(() => new AclDescription(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(Type.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteInt8(PatternType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(AclsCollection);
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _type = Int8.Default;
			public Int8 Type 
			{
				get => _type;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Type does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Type is non-nullable.");
					}

					_type = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The resource pattern type.
			/// </summary>
			private Int8 _patternType = new Int8(3);
			public Int8 PatternType 
			{
				get => _patternType;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PatternType does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PatternType is non-nullable.");
					}

					_patternType = value;
				}
			}

			/// <summary>
			/// The ACLs.
			/// </summary>
			private AclDescription[] _aclsCollection = System.Array.Empty<AclDescription>();
			public AclDescription[] AclsCollection 
			{
				get => _aclsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"AclsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"AclsCollection is non-nullable.");
					}

					_aclsCollection = value;
				}
			}

			public AclDescription CreateAclDescription()
			{
				return new AclDescription(Version);
			}

			public class AclDescription : ISerialize
			{
				internal AclDescription(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Principal = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Host = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Operation = new Int8(reader.ReadInt8());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PermissionType = new Int8(reader.ReadInt8());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Principal.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Host.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt8(Operation.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt8(PermissionType.Value);
					}
				}

				/// <summary>
				/// The ACL principal.
				/// </summary>
				private String _principal = String.Default;
				public String Principal 
				{
					get => _principal;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Principal does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Principal is non-nullable.");
						}

						_principal = value;
					}
				}

				/// <summary>
				/// The ACL host.
				/// </summary>
				private String _host = String.Default;
				public String Host 
				{
					get => _host;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Host is non-nullable.");
						}

						_host = value;
					}
				}

				/// <summary>
				/// The ACL operation.
				/// </summary>
				private Int8 _operation = Int8.Default;
				public Int8 Operation 
				{
					get => _operation;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Operation does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Operation is non-nullable.");
						}

						_operation = value;
					}
				}

				/// <summary>
				/// The ACL permission type.
				/// </summary>
				private Int8 _permissionType = Int8.Default;
				public Int8 PermissionType 
				{
					get => _permissionType;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PermissionType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PermissionType is non-nullable.");
						}

						_permissionType = value;
					}
				}
			}
		}
	}

	public class DescribeConfigsRequest
	{
		public DescribeConfigsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeConfigsRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 32;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResourcesCollection = reader.Read(() => new DescribeConfigsResource(Version));
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				IncludeSynoyms = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResourcesCollection);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteBoolean(IncludeSynoyms.Value);
			}
		}

		/// <summary>
		/// The resources whose configurations we want to describe.
		/// </summary>
		private DescribeConfigsResource[] _resourcesCollection = System.Array.Empty<DescribeConfigsResource>();
		public DescribeConfigsResource[] ResourcesCollection 
		{
			get => _resourcesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResourcesCollection is non-nullable.");
				}

				_resourcesCollection = value;
			}
		}

		public DescribeConfigsResource CreateDescribeConfigsResource()
		{
			return new DescribeConfigsResource(Version);
		}

		public class DescribeConfigsResource : ISerialize
		{
			internal DescribeConfigsResource(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ConfigurationKeysCollection = reader.Read(() => new String(reader.ReadString()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(ConfigurationKeysCollection);
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _resourceType = Int8.Default;
			public Int8 ResourceType 
			{
				get => _resourceType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceType is non-nullable.");
					}

					_resourceType = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _resourceName = String.Default;
			public String ResourceName 
			{
				get => _resourceName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceName is non-nullable.");
					}

					_resourceName = value;
				}
			}

			/// <summary>
			/// The configuration keys to list, or null to list all configuration keys.
			/// </summary>
			private String[] _configurationKeysCollection = System.Array.Empty<String>();
			public String[] ConfigurationKeysCollection 
			{
				get => _configurationKeysCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ConfigurationKeysCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ConfigurationKeysCollection does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_configurationKeysCollection = value;
				}
			}
		}

		/// <summary>
		/// True if we should include all synonyms.
		/// </summary>
		private Boolean _includeSynoyms = new Boolean(false);
		public Boolean IncludeSynoyms 
		{
			get => _includeSynoyms;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IncludeSynoyms does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IncludeSynoyms is non-nullable.");
				}

				_includeSynoyms = value;
			}
		}
	}

	public class DescribeConfigsResponse
	{
		public DescribeConfigsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeConfigsResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 32;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new DescribeConfigsResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The results for each resource.
		/// </summary>
		private DescribeConfigsResult[] _resultsCollection = System.Array.Empty<DescribeConfigsResult>();
		public DescribeConfigsResult[] ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public DescribeConfigsResult CreateDescribeConfigsResult()
		{
			return new DescribeConfigsResult(Version);
		}

		public class DescribeConfigsResult : ISerialize
		{
			internal DescribeConfigsResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorMessage = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceType = new Int8(reader.ReadInt8());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ResourceName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ConfigsCollection = reader.Read(() => new DescribeConfigsResourceResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ErrorMessage.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt8(ResourceType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ResourceName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(ConfigsCollection);
				}
			}

			/// <summary>
			/// The error code, or 0 if we were able to successfully describe the configurations.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The error message, or null if we were able to successfully describe the configurations.
			/// </summary>
			private String _errorMessage = String.Default;
			public String ErrorMessage 
			{
				get => _errorMessage;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_errorMessage = value;
				}
			}

			/// <summary>
			/// The resource type.
			/// </summary>
			private Int8 _resourceType = Int8.Default;
			public Int8 ResourceType 
			{
				get => _resourceType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceType is non-nullable.");
					}

					_resourceType = value;
				}
			}

			/// <summary>
			/// The resource name.
			/// </summary>
			private String _resourceName = String.Default;
			public String ResourceName 
			{
				get => _resourceName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ResourceName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ResourceName is non-nullable.");
					}

					_resourceName = value;
				}
			}

			/// <summary>
			/// Each listed configuration.
			/// </summary>
			private DescribeConfigsResourceResult[] _configsCollection = System.Array.Empty<DescribeConfigsResourceResult>();
			public DescribeConfigsResourceResult[] ConfigsCollection 
			{
				get => _configsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ConfigsCollection is non-nullable.");
					}

					_configsCollection = value;
				}
			}

			public DescribeConfigsResourceResult CreateDescribeConfigsResourceResult()
			{
				return new DescribeConfigsResourceResult(Version);
			}

			public class DescribeConfigsResourceResult : ISerialize
			{
				internal DescribeConfigsResourceResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Value = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ReadOnly = new Boolean(reader.ReadBoolean());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						IsDefault = new Boolean(reader.ReadBoolean());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						ConfigSource = new Int8(reader.ReadInt8());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						IsSensitive = new Boolean(reader.ReadBoolean());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						SynonymsCollection = reader.Read(() => new DescribeConfigsSynonym(Version));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Value.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBoolean(ReadOnly.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBoolean(IsDefault.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt8(ConfigSource.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBoolean(IsSensitive.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.Write(SynonymsCollection);
					}
				}

				/// <summary>
				/// The configuration name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The configuration value.
				/// </summary>
				private String _value = String.Default;
				public String Value 
				{
					get => _value;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Value does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Value does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_value = value;
					}
				}

				/// <summary>
				/// True if the configuration is read-only.
				/// </summary>
				private Boolean _readOnly = Boolean.Default;
				public Boolean ReadOnly 
				{
					get => _readOnly;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ReadOnly does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ReadOnly is non-nullable.");
						}

						_readOnly = value;
					}
				}

				/// <summary>
				/// True if the configuration is not set.
				/// </summary>
				private Boolean _isDefault = Boolean.Default;
				public Boolean IsDefault 
				{
					get => _isDefault;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"IsDefault does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsDefault is non-nullable.");
						}

						_isDefault = value;
					}
				}

				/// <summary>
				/// The configuration source.
				/// </summary>
				private Int8 _configSource = new Int8(-1);
				public Int8 ConfigSource 
				{
					get => _configSource;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"ConfigSource is non-nullable.");
						}

						_configSource = value;
					}
				}

				/// <summary>
				/// True if this configuration is sensitive.
				/// </summary>
				private Boolean _isSensitive = Boolean.Default;
				public Boolean IsSensitive 
				{
					get => _isSensitive;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"IsSensitive does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsSensitive is non-nullable.");
						}

						_isSensitive = value;
					}
				}

				/// <summary>
				/// The synonyms for this configuration key.
				/// </summary>
				private DescribeConfigsSynonym[] _synonymsCollection = System.Array.Empty<DescribeConfigsSynonym>();
				public DescribeConfigsSynonym[] SynonymsCollection 
				{
					get => _synonymsCollection;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"SynonymsCollection is non-nullable.");
						}

						_synonymsCollection = value;
					}
				}

				public DescribeConfigsSynonym CreateDescribeConfigsSynonym()
				{
					return new DescribeConfigsSynonym(Version);
				}

				public class DescribeConfigsSynonym : ISerialize
				{
					internal DescribeConfigsSynonym(int version)
					{
						Version = version;
					}

					internal int Version { get; }

					public void ReadFrom(IKafkaReader reader)
					{
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							Name = new String(reader.ReadString());
						}
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							Value = new String(reader.ReadString());
						}
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							Source = new Int8(reader.ReadInt8());
						}
					}

					public void WriteTo(IKafkaWriter writer)
					{
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							writer.WriteString(Name.Value);
						}
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							writer.WriteString(Value.Value);
						}
						if (Version.InRange(new VersionRange(1, 2147483647))) 
						{
							writer.WriteInt8(Source.Value);
						}
					}

					/// <summary>
					/// The synonym name.
					/// </summary>
					private String _name = String.Default;
					public String Name 
					{
						get => _name;
						set 
						{
							if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"Name is non-nullable.");
							}

							_name = value;
						}
					}

					/// <summary>
					/// The synonym value.
					/// </summary>
					private String _value = String.Default;
					public String Value 
					{
						get => _value;
						set 
						{
							if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"Value does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
							}

							if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
								value == null) 
							{
								throw new UnsupportedVersionException($"Value does not support null for version {Version}. Supported versions for null value: 0+");
							}

							_value = value;
						}
					}

					/// <summary>
					/// The synonym source.
					/// </summary>
					private Int8 _source = Int8.Default;
					public Int8 Source 
					{
						get => _source;
						set 
						{
							if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"Source does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"Source is non-nullable.");
							}

							_source = value;
						}
					}
				}
			}
		}
	}

	public class DescribeDelegationTokenRequest
	{
		public DescribeDelegationTokenRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeDelegationTokenRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 41;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				OwnersCollection = reader.Read(() => new DescribeDelegationTokenOwner(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(OwnersCollection);
			}
		}

		/// <summary>
		/// Each owner that we want to describe delegation tokens for, or null to describe all tokens.
		/// </summary>
		private DescribeDelegationTokenOwner[] _ownersCollection = System.Array.Empty<DescribeDelegationTokenOwner>();
		public DescribeDelegationTokenOwner[] OwnersCollection 
		{
			get => _ownersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"OwnersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"OwnersCollection does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_ownersCollection = value;
			}
		}

		public DescribeDelegationTokenOwner CreateDescribeDelegationTokenOwner()
		{
			return new DescribeDelegationTokenOwner(Version);
		}

		public class DescribeDelegationTokenOwner : ISerialize
		{
			internal DescribeDelegationTokenOwner(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalType = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalName = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalName.Value);
				}
			}

			/// <summary>
			/// The owner principal type.
			/// </summary>
			private String _principalType = String.Default;
			public String PrincipalType 
			{
				get => _principalType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalType is non-nullable.");
					}

					_principalType = value;
				}
			}

			/// <summary>
			/// The owner principal name.
			/// </summary>
			private String _principalName = String.Default;
			public String PrincipalName 
			{
				get => _principalName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalName is non-nullable.");
					}

					_principalName = value;
				}
			}
		}
	}

	public class DescribeDelegationTokenResponse
	{
		public DescribeDelegationTokenResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeDelegationTokenResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 41;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TokensCollection = reader.Read(() => new DescribedDelegationToken(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TokensCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The tokens.
		/// </summary>
		private DescribedDelegationToken[] _tokensCollection = System.Array.Empty<DescribedDelegationToken>();
		public DescribedDelegationToken[] TokensCollection 
		{
			get => _tokensCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TokensCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TokensCollection is non-nullable.");
				}

				_tokensCollection = value;
			}
		}

		public DescribedDelegationToken CreateDescribedDelegationToken()
		{
			return new DescribedDelegationToken(Version);
		}

		public class DescribedDelegationToken : ISerialize
		{
			internal DescribedDelegationToken(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalType = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PrincipalName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					IssueTimestamp = new Int64(reader.ReadInt64());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ExpiryTimestamp = new Int64(reader.ReadInt64());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MaxTimestamp = new Int64(reader.ReadInt64());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TokenId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Hmac = new Bytes(reader.ReadBytes());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					RenewersCollection = reader.Read(() => new DescribedDelegationTokenRenewer(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(PrincipalName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt64(IssueTimestamp.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt64(ExpiryTimestamp.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt64(MaxTimestamp.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TokenId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteBytes(Hmac.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(RenewersCollection);
				}
			}

			/// <summary>
			/// The token principal type.
			/// </summary>
			private String _principalType = String.Default;
			public String PrincipalType 
			{
				get => _principalType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalType is non-nullable.");
					}

					_principalType = value;
				}
			}

			/// <summary>
			/// The token principal name.
			/// </summary>
			private String _principalName = String.Default;
			public String PrincipalName 
			{
				get => _principalName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PrincipalName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PrincipalName is non-nullable.");
					}

					_principalName = value;
				}
			}

			/// <summary>
			/// The token issue timestamp in milliseconds.
			/// </summary>
			private Int64 _issueTimestamp = Int64.Default;
			public Int64 IssueTimestamp 
			{
				get => _issueTimestamp;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"IssueTimestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"IssueTimestamp is non-nullable.");
					}

					_issueTimestamp = value;
				}
			}

			/// <summary>
			/// The token expiry timestamp in milliseconds.
			/// </summary>
			private Int64 _expiryTimestamp = Int64.Default;
			public Int64 ExpiryTimestamp 
			{
				get => _expiryTimestamp;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ExpiryTimestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ExpiryTimestamp is non-nullable.");
					}

					_expiryTimestamp = value;
				}
			}

			/// <summary>
			/// The token maximum timestamp length in milliseconds.
			/// </summary>
			private Int64 _maxTimestamp = Int64.Default;
			public Int64 MaxTimestamp 
			{
				get => _maxTimestamp;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MaxTimestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MaxTimestamp is non-nullable.");
					}

					_maxTimestamp = value;
				}
			}

			/// <summary>
			/// The token ID.
			/// </summary>
			private String _tokenId = String.Default;
			public String TokenId 
			{
				get => _tokenId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TokenId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TokenId is non-nullable.");
					}

					_tokenId = value;
				}
			}

			/// <summary>
			/// The token HMAC.
			/// </summary>
			private Bytes _hmac = Bytes.Default;
			public Bytes Hmac 
			{
				get => _hmac;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Hmac does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Hmac is non-nullable.");
					}

					_hmac = value;
				}
			}

			/// <summary>
			/// Those who are able to renew this token before it expires.
			/// </summary>
			private DescribedDelegationTokenRenewer[] _renewersCollection = System.Array.Empty<DescribedDelegationTokenRenewer>();
			public DescribedDelegationTokenRenewer[] RenewersCollection 
			{
				get => _renewersCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"RenewersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"RenewersCollection is non-nullable.");
					}

					_renewersCollection = value;
				}
			}

			public DescribedDelegationTokenRenewer CreateDescribedDelegationTokenRenewer()
			{
				return new DescribedDelegationTokenRenewer(Version);
			}

			public class DescribedDelegationTokenRenewer : ISerialize
			{
				internal DescribedDelegationTokenRenewer(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PrincipalType = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PrincipalName = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(PrincipalType.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(PrincipalName.Value);
					}
				}

				/// <summary>
				/// The renewer principal type
				/// </summary>
				private String _principalType = String.Default;
				public String PrincipalType 
				{
					get => _principalType;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PrincipalType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PrincipalType is non-nullable.");
						}

						_principalType = value;
					}
				}

				/// <summary>
				/// The renewer principal name
				/// </summary>
				private String _principalName = String.Default;
				public String PrincipalName 
				{
					get => _principalName;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PrincipalName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PrincipalName is non-nullable.");
						}

						_principalName = value;
					}
				}
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class DescribeGroupsRequest
	{
		public DescribeGroupsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeGroupsRequest does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 15;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupsCollection = reader.Read(() => new String(reader.ReadString()));
			}
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				IncludeAuthorizedOperations = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(GroupsCollection);
			}
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteBoolean(IncludeAuthorizedOperations.Value);
			}
		}

		/// <summary>
		/// The names of the groups to describe
		/// </summary>
		private String[] _groupsCollection = System.Array.Empty<String>();
		public String[] GroupsCollection 
		{
			get => _groupsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupsCollection is non-nullable.");
				}

				_groupsCollection = value;
			}
		}

		/// <summary>
		/// Whether to include authorized operations.
		/// </summary>
		private Boolean _includeAuthorizedOperations = Boolean.Default;
		public Boolean IncludeAuthorizedOperations 
		{
			get => _includeAuthorizedOperations;
			set 
			{
				if (Version.InRange(new VersionRange(3, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IncludeAuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 3+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IncludeAuthorizedOperations is non-nullable.");
				}

				_includeAuthorizedOperations = value;
			}
		}
	}

	public class DescribeGroupsResponse
	{
		public DescribeGroupsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 3)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeGroupsResponse does not support version {version}. Valid versions are: 0-3");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 15;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupsCollection = reader.Read(() => new DescribedGroup(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(GroupsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Each described group.
		/// </summary>
		private DescribedGroup[] _groupsCollection = System.Array.Empty<DescribedGroup>();
		public DescribedGroup[] GroupsCollection 
		{
			get => _groupsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupsCollection is non-nullable.");
				}

				_groupsCollection = value;
			}
		}

		public DescribedGroup CreateDescribedGroup()
		{
			return new DescribedGroup(Version);
		}

		public class DescribedGroup : ISerialize
		{
			internal DescribedGroup(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					GroupId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					GroupState = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProtocolType = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProtocolData = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MembersCollection = reader.Read(() => new DescribedGroupMember(Version));
				}
				if (Version.InRange(new VersionRange(3, 2147483647))) 
				{
					AuthorizedOperations = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(GroupId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(GroupState.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ProtocolType.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ProtocolData.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(MembersCollection);
				}
				if (Version.InRange(new VersionRange(3, 2147483647))) 
				{
					writer.WriteInt32(AuthorizedOperations.Value);
				}
			}

			/// <summary>
			/// The describe error, or 0 if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The group ID string.
			/// </summary>
			private String _groupId = String.Default;
			public String GroupId 
			{
				get => _groupId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"GroupId is non-nullable.");
					}

					_groupId = value;
				}
			}

			/// <summary>
			/// The group state string, or the empty string.
			/// </summary>
			private String _groupState = String.Default;
			public String GroupState 
			{
				get => _groupState;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"GroupState does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"GroupState is non-nullable.");
					}

					_groupState = value;
				}
			}

			/// <summary>
			/// The group protocol type, or the empty string.
			/// </summary>
			private String _protocolType = String.Default;
			public String ProtocolType 
			{
				get => _protocolType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProtocolType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProtocolType is non-nullable.");
					}

					_protocolType = value;
				}
			}

			/// <summary>
			/// The group protocol data, or the empty string.
			/// </summary>
			private String _protocolData = String.Default;
			public String ProtocolData 
			{
				get => _protocolData;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProtocolData does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProtocolData is non-nullable.");
					}

					_protocolData = value;
				}
			}

			/// <summary>
			/// The group members.
			/// </summary>
			private DescribedGroupMember[] _membersCollection = System.Array.Empty<DescribedGroupMember>();
			public DescribedGroupMember[] MembersCollection 
			{
				get => _membersCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MembersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MembersCollection is non-nullable.");
					}

					_membersCollection = value;
				}
			}

			public DescribedGroupMember CreateDescribedGroupMember()
			{
				return new DescribedGroupMember(Version);
			}

			public class DescribedGroupMember : ISerialize
			{
				internal DescribedGroupMember(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						MemberId = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ClientId = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ClientHost = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						MemberMetadata = new Bytes(reader.ReadBytes());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						MemberAssignment = new Bytes(reader.ReadBytes());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(MemberId.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(ClientId.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(ClientHost.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBytes(MemberMetadata.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBytes(MemberAssignment.Value);
					}
				}

				/// <summary>
				/// The member ID assigned by the group coordinator.
				/// </summary>
				private String _memberId = String.Default;
				public String MemberId 
				{
					get => _memberId;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"MemberId is non-nullable.");
						}

						_memberId = value;
					}
				}

				/// <summary>
				/// The client ID used in the member's latest join group request.
				/// </summary>
				private String _clientId = String.Default;
				public String ClientId 
				{
					get => _clientId;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ClientId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ClientId is non-nullable.");
						}

						_clientId = value;
					}
				}

				/// <summary>
				/// The client host.
				/// </summary>
				private String _clientHost = String.Default;
				public String ClientHost 
				{
					get => _clientHost;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ClientHost does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ClientHost is non-nullable.");
						}

						_clientHost = value;
					}
				}

				/// <summary>
				/// The metadata corresponding to the current group protocol in use.
				/// </summary>
				private Bytes _memberMetadata = Bytes.Default;
				public Bytes MemberMetadata 
				{
					get => _memberMetadata;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"MemberMetadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"MemberMetadata is non-nullable.");
						}

						_memberMetadata = value;
					}
				}

				/// <summary>
				/// The current assignment provided by the group leader.
				/// </summary>
				private Bytes _memberAssignment = Bytes.Default;
				public Bytes MemberAssignment 
				{
					get => _memberAssignment;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"MemberAssignment does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"MemberAssignment is non-nullable.");
						}

						_memberAssignment = value;
					}
				}
			}

			/// <summary>
			/// 32-bit bitfield to represent authorized operations for this group.
			/// </summary>
			private Int32 _authorizedOperations = Int32.Default;
			public Int32 AuthorizedOperations 
			{
				get => _authorizedOperations;
				set 
				{
					if (Version.InRange(new VersionRange(3, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"AuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 3+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"AuthorizedOperations is non-nullable.");
					}

					_authorizedOperations = value;
				}
			}
		}
	}

	public class DescribeLogDirsRequest
	{
		public DescribeLogDirsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeLogDirsRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 35;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new DescribableLogDirTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// Each topic that we want to describe log directories for, or null for all topics.
		/// </summary>
		private DescribableLogDirTopic[] _topicsCollection = System.Array.Empty<DescribableLogDirTopic>();
		public DescribableLogDirTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_topicsCollection = value;
			}
		}

		public DescribableLogDirTopic CreateDescribableLogDirTopic()
		{
			return new DescribableLogDirTopic(Version);
		}

		public class DescribableLogDirTopic : ISerialize
		{
			internal DescribableLogDirTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Topic = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndexCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Topic.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionIndexCollection);
				}
			}

			/// <summary>
			/// The topic name
			/// </summary>
			private String _topic = String.Default;
			public String Topic 
			{
				get => _topic;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Topic does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Topic is non-nullable.");
					}

					_topic = value;
				}
			}

			/// <summary>
			/// The partition indxes.
			/// </summary>
			private Int32[] _partitionIndexCollection = System.Array.Empty<Int32>();
			public Int32[] PartitionIndexCollection 
			{
				get => _partitionIndexCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndexCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndexCollection is non-nullable.");
					}

					_partitionIndexCollection = value;
				}
			}
		}
	}

	public class DescribeLogDirsResponse
	{
		public DescribeLogDirsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"DescribeLogDirsResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 35;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResultsCollection = reader.Read(() => new DescribeLogDirsResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The log directories.
		/// </summary>
		private DescribeLogDirsResult[] _resultsCollection = System.Array.Empty<DescribeLogDirsResult>();
		public DescribeLogDirsResult[] ResultsCollection 
		{
			get => _resultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResultsCollection is non-nullable.");
				}

				_resultsCollection = value;
			}
		}

		public DescribeLogDirsResult CreateDescribeLogDirsResult()
		{
			return new DescribeLogDirsResult(Version);
		}

		public class DescribeLogDirsResult : ISerialize
		{
			internal DescribeLogDirsResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					LogDir = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicsCollection = reader.Read(() => new DescribeLogDirsTopic(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(LogDir.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(TopicsCollection);
				}
			}

			/// <summary>
			/// The error code, or 0 if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The absolute log directory path.
			/// </summary>
			private String _logDir = String.Default;
			public String LogDir 
			{
				get => _logDir;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"LogDir does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"LogDir is non-nullable.");
					}

					_logDir = value;
				}
			}

			/// <summary>
			/// Each topic.
			/// </summary>
			private DescribeLogDirsTopic[] _topicsCollection = System.Array.Empty<DescribeLogDirsTopic>();
			public DescribeLogDirsTopic[] TopicsCollection 
			{
				get => _topicsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
					}

					_topicsCollection = value;
				}
			}

			public DescribeLogDirsTopic CreateDescribeLogDirsTopic()
			{
				return new DescribeLogDirsTopic(Version);
			}

			public class DescribeLogDirsTopic : ISerialize
			{
				internal DescribeLogDirsTopic(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionsCollection = reader.Read(() => new DescribeLogDirsPartition(Version));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(PartitionsCollection);
					}
				}

				/// <summary>
				/// The topic name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				private DescribeLogDirsPartition[] _partitionsCollection = System.Array.Empty<DescribeLogDirsPartition>();
				public DescribeLogDirsPartition[] PartitionsCollection 
				{
					get => _partitionsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
						}

						_partitionsCollection = value;
					}
				}

				public DescribeLogDirsPartition CreateDescribeLogDirsPartition()
				{
					return new DescribeLogDirsPartition(Version);
				}

				public class DescribeLogDirsPartition : ISerialize
				{
					internal DescribeLogDirsPartition(int version)
					{
						Version = version;
					}

					internal int Version { get; }

					public void ReadFrom(IKafkaReader reader)
					{
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							PartitionIndex = new Int32(reader.ReadInt32());
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							PartitionSize = new Int64(reader.ReadInt64());
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							OffsetLag = new Int64(reader.ReadInt64());
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							IsFutureKey = new Boolean(reader.ReadBoolean());
						}
					}

					public void WriteTo(IKafkaWriter writer)
					{
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteInt32(PartitionIndex.Value);
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteInt64(PartitionSize.Value);
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteInt64(OffsetLag.Value);
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteBoolean(IsFutureKey.Value);
						}
					}

					/// <summary>
					/// The partition index.
					/// </summary>
					private Int32 _partitionIndex = Int32.Default;
					public Int32 PartitionIndex 
					{
						get => _partitionIndex;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
							}

							_partitionIndex = value;
						}
					}

					/// <summary>
					/// The size of the log segments in this partition in bytes.
					/// </summary>
					private Int64 _partitionSize = Int64.Default;
					public Int64 PartitionSize 
					{
						get => _partitionSize;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"PartitionSize does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"PartitionSize is non-nullable.");
							}

							_partitionSize = value;
						}
					}

					/// <summary>
					/// The lag of the log's LEO w.r.t. partition's HW (if it is the current log for the partition) or current replica's LEO (if it is the future log for the partition)
					/// </summary>
					private Int64 _offsetLag = Int64.Default;
					public Int64 OffsetLag 
					{
						get => _offsetLag;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"OffsetLag does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"OffsetLag is non-nullable.");
							}

							_offsetLag = value;
						}
					}

					/// <summary>
					/// True if this log is created by AlterReplicaLogDirsRequest and will replace the current log of the replica in the future.
					/// </summary>
					private Boolean _isFutureKey = Boolean.Default;
					public Boolean IsFutureKey 
					{
						get => _isFutureKey;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"IsFutureKey does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"IsFutureKey is non-nullable.");
							}

							_isFutureKey = value;
						}
					}
				}
			}
		}
	}

	public class ElectPreferredLeadersRequest
	{
		public ElectPreferredLeadersRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"ElectPreferredLeadersRequest does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 43;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicPartitionsCollection = reader.Read(() => new TopicPartitions(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TimeoutMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicPartitionsCollection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TimeoutMs.Value);
			}
		}

		/// <summary>
		/// The topic partitions to elect the preferred leader of.
		/// </summary>
		private TopicPartitions[] _topicPartitionsCollection = System.Array.Empty<TopicPartitions>();
		public TopicPartitions[] TopicPartitionsCollection 
		{
			get => _topicPartitionsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicPartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TopicPartitionsCollection does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_topicPartitionsCollection = value;
			}
		}

		public TopicPartitions CreateTopicPartitions()
		{
			return new TopicPartitions(Version);
		}

		public class TopicPartitions : ISerialize
		{
			internal TopicPartitions(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Topic = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIdCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Topic.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionIdCollection);
				}
			}

			/// <summary>
			/// The name of a topic.
			/// </summary>
			private String _topic = String.Default;
			public String Topic 
			{
				get => _topic;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Topic does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Topic is non-nullable.");
					}

					_topic = value;
				}
			}

			/// <summary>
			/// The partitions of this topic whose preferred leader should be elected
			/// </summary>
			private Int32[] _partitionIdCollection = System.Array.Empty<Int32>();
			public Int32[] PartitionIdCollection 
			{
				get => _partitionIdCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIdCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIdCollection is non-nullable.");
					}

					_partitionIdCollection = value;
				}
			}
		}

		/// <summary>
		/// The time in ms to wait for the election to complete.
		/// </summary>
		private Int32 _timeoutMs = new Int32(60000);
		public Int32 TimeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TimeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}
	}

	public class ElectPreferredLeadersResponse
	{
		public ElectPreferredLeadersResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"ElectPreferredLeadersResponse does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 43;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ReplicaElectionResultsCollection = reader.Read(() => new ReplicaElectionResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ReplicaElectionResultsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The election results, or an empty array if the requester did not have permission and the request asks for all partitions.
		/// </summary>
		private ReplicaElectionResult[] _replicaElectionResultsCollection = System.Array.Empty<ReplicaElectionResult>();
		public ReplicaElectionResult[] ReplicaElectionResultsCollection 
		{
			get => _replicaElectionResultsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ReplicaElectionResultsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ReplicaElectionResultsCollection is non-nullable.");
				}

				_replicaElectionResultsCollection = value;
			}
		}

		public ReplicaElectionResult CreateReplicaElectionResult()
		{
			return new ReplicaElectionResult(Version);
		}

		public class ReplicaElectionResult : ISerialize
		{
			internal ReplicaElectionResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Topic = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionResultCollection = reader.Read(() => new PartitionResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Topic.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionResultCollection);
				}
			}

			/// <summary>
			/// The topic name
			/// </summary>
			private String _topic = String.Default;
			public String Topic 
			{
				get => _topic;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Topic does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Topic is non-nullable.");
					}

					_topic = value;
				}
			}

			/// <summary>
			/// The results for each partition
			/// </summary>
			private PartitionResult[] _partitionResultCollection = System.Array.Empty<PartitionResult>();
			public PartitionResult[] PartitionResultCollection 
			{
				get => _partitionResultCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionResultCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionResultCollection is non-nullable.");
					}

					_partitionResultCollection = value;
				}
			}

			public PartitionResult CreatePartitionResult()
			{
				return new PartitionResult(Version);
			}

			public class PartitionResult : ISerialize
			{
				internal PartitionResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionId = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorMessage = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionId.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(ErrorMessage.Value);
					}
				}

				/// <summary>
				/// The partition id
				/// </summary>
				private Int32 _partitionId = Int32.Default;
				public Int32 PartitionId 
				{
					get => _partitionId;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionId is non-nullable.");
						}

						_partitionId = value;
					}
				}

				/// <summary>
				/// The result error, or zero if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The result message, or null if there was no error.
				/// </summary>
				private String _errorMessage = String.Default;
				public String ErrorMessage 
				{
					get => _errorMessage;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_errorMessage = value;
					}
				}
			}
		}
	}

	public class EndTxnRequest
	{
		public EndTxnRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"EndTxnRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 26;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerId = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerEpoch = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Committed = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ProducerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ProducerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBoolean(Committed.Value);
			}
		}

		/// <summary>
		/// The ID of the transaction to end.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId is non-nullable.");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// The producer ID.
		/// </summary>
		private Int64 _producerId = Int64.Default;
		public Int64 ProducerId 
		{
			get => _producerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerId is non-nullable.");
				}

				_producerId = value;
			}
		}

		/// <summary>
		/// The current epoch associated with the producer.
		/// </summary>
		private Int16 _producerEpoch = Int16.Default;
		public Int16 ProducerEpoch 
		{
			get => _producerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
				}

				_producerEpoch = value;
			}
		}

		/// <summary>
		/// True if the transaction was committed, false if it was aborted.
		/// </summary>
		private Boolean _committed = Boolean.Default;
		public Boolean Committed 
		{
			get => _committed;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Committed does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Committed is non-nullable.");
				}

				_committed = value;
			}
		}
	}

	public class EndTxnResponse
	{
		public EndTxnResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"EndTxnResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 26;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class ExpireDelegationTokenRequest
	{
		public ExpireDelegationTokenRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"ExpireDelegationTokenRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 40;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Hmac = new Bytes(reader.ReadBytes());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ExpiryTimePeriodMs = new Int64(reader.ReadInt64());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(Hmac.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ExpiryTimePeriodMs.Value);
			}
		}

		/// <summary>
		/// The HMAC of the delegation token to be expired.
		/// </summary>
		private Bytes _hmac = Bytes.Default;
		public Bytes Hmac 
		{
			get => _hmac;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Hmac does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Hmac is non-nullable.");
				}

				_hmac = value;
			}
		}

		/// <summary>
		/// The expiry time period in milliseconds.
		/// </summary>
		private Int64 _expiryTimePeriodMs = Int64.Default;
		public Int64 ExpiryTimePeriodMs 
		{
			get => _expiryTimePeriodMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ExpiryTimePeriodMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ExpiryTimePeriodMs is non-nullable.");
				}

				_expiryTimePeriodMs = value;
			}
		}
	}

	public class ExpireDelegationTokenResponse
	{
		public ExpireDelegationTokenResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"ExpireDelegationTokenResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 40;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ExpiryTimestampMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ExpiryTimestampMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The timestamp in milliseconds at which this token expires.
		/// </summary>
		private Int64 _expiryTimestampMs = Int64.Default;
		public Int64 ExpiryTimestampMs 
		{
			get => _expiryTimestampMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs is non-nullable.");
				}

				_expiryTimestampMs = value;
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class FetchRequest
	{
		public FetchRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 10)) == false) 
			{
				throw new UnsupportedVersionException($"FetchRequest does not support version {version}. Valid versions are: 0-10");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 1;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ReplicaId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MaxWait = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MinBytes = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				MaxBytes = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(4, 2147483647))) 
			{
				IsolationLevel = new Int8(reader.ReadInt8());
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				SessionId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				Epoch = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new FetchableTopic(Version));
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				ForgottenCollection = reader.Read(() => new ForgottenTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ReplicaId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(MaxWait.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(MinBytes.Value);
			}
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteInt32(MaxBytes.Value);
			}
			if (Version.InRange(new VersionRange(4, 2147483647))) 
			{
				writer.WriteInt8(IsolationLevel.Value);
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				writer.WriteInt32(SessionId.Value);
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				writer.WriteInt32(Epoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				writer.Write(ForgottenCollection);
			}
		}

		/// <summary>
		/// The broker ID of the follower, of -1 if this request is from a consumer.
		/// </summary>
		private Int32 _replicaId = Int32.Default;
		public Int32 ReplicaId 
		{
			get => _replicaId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ReplicaId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ReplicaId is non-nullable.");
				}

				_replicaId = value;
			}
		}

		/// <summary>
		/// The maximum time in milliseconds to wait for the response.
		/// </summary>
		private Int32 _maxWait = Int32.Default;
		public Int32 MaxWait 
		{
			get => _maxWait;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MaxWait does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MaxWait is non-nullable.");
				}

				_maxWait = value;
			}
		}

		/// <summary>
		/// The minimum bytes to accumulate in the response.
		/// </summary>
		private Int32 _minBytes = Int32.Default;
		public Int32 MinBytes 
		{
			get => _minBytes;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MinBytes does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MinBytes is non-nullable.");
				}

				_minBytes = value;
			}
		}

		/// <summary>
		/// The maximum bytes to fetch.  See KIP-74 for cases where this limit may not be honored.
		/// </summary>
		private Int32 _maxBytes = new Int32(0x7fffffff);
		public Int32 MaxBytes 
		{
			get => _maxBytes;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"MaxBytes is non-nullable.");
				}

				_maxBytes = value;
			}
		}

		/// <summary>
		/// This setting controls the visibility of transactional records. Using READ_UNCOMMITTED (isolation_level = 0) makes all records visible. With READ_COMMITTED (isolation_level = 1), non-transactional and COMMITTED transactional records are visible. To be more concrete, READ_COMMITTED returns all data from offsets smaller than the current LSO (last stable offset), and enables the inclusion of the list of aborted transactions in the result, which allows consumers to discard ABORTED transactional records
		/// </summary>
		private Int8 _isolationLevel = new Int8(0);
		public Int8 IsolationLevel 
		{
			get => _isolationLevel;
			set 
			{
				if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IsolationLevel does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IsolationLevel is non-nullable.");
				}

				_isolationLevel = value;
			}
		}

		/// <summary>
		/// The fetch session ID.
		/// </summary>
		private Int32 _sessionId = new Int32(0);
		public Int32 SessionId 
		{
			get => _sessionId;
			set 
			{
				if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"SessionId does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"SessionId is non-nullable.");
				}

				_sessionId = value;
			}
		}

		/// <summary>
		/// The fetch session ID.
		/// </summary>
		private Int32 _epoch = new Int32(-1);
		public Int32 Epoch 
		{
			get => _epoch;
			set 
			{
				if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Epoch does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Epoch is non-nullable.");
				}

				_epoch = value;
			}
		}

		/// <summary>
		/// The topics to fetch.
		/// </summary>
		private FetchableTopic[] _topicsCollection = System.Array.Empty<FetchableTopic>();
		public FetchableTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public FetchableTopic CreateFetchableTopic()
		{
			return new FetchableTopic(Version);
		}

		public class FetchableTopic : ISerialize
		{
			internal FetchableTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					FetchPartitionsCollection = reader.Read(() => new FetchPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(FetchPartitionsCollection);
				}
			}

			/// <summary>
			/// The name of the topic to fetch.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partitions to fetch.
			/// </summary>
			private FetchPartition[] _fetchPartitionsCollection = System.Array.Empty<FetchPartition>();
			public FetchPartition[] FetchPartitionsCollection 
			{
				get => _fetchPartitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"FetchPartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"FetchPartitionsCollection is non-nullable.");
					}

					_fetchPartitionsCollection = value;
				}
			}

			public FetchPartition CreateFetchPartition()
			{
				return new FetchPartition(Version);
			}

			public class FetchPartition : ISerialize
			{
				internal FetchPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(9, 2147483647))) 
					{
						CurrentLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						FetchOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						LogStartOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						MaxBytes = new Int32(reader.ReadInt32());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(9, 2147483647))) 
					{
						writer.WriteInt32(CurrentLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(FetchOffset.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt64(LogStartOffset.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(MaxBytes.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The current leader epoch of the partition.
				/// </summary>
				private Int32 _currentLeaderEpoch = new Int32(-1);
				public Int32 CurrentLeaderEpoch 
				{
					get => _currentLeaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"CurrentLeaderEpoch is non-nullable.");
						}

						_currentLeaderEpoch = value;
					}
				}

				/// <summary>
				/// The message offset.
				/// </summary>
				private Int64 _fetchOffset = Int64.Default;
				public Int64 FetchOffset 
				{
					get => _fetchOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"FetchOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"FetchOffset is non-nullable.");
						}

						_fetchOffset = value;
					}
				}

				/// <summary>
				/// The earliest available offset of the follower replica.  The field is only used when the request is sent by the follower.
				/// </summary>
				private Int64 _logStartOffset = new Int64(-1);
				public Int64 LogStartOffset 
				{
					get => _logStartOffset;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LogStartOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LogStartOffset is non-nullable.");
						}

						_logStartOffset = value;
					}
				}

				/// <summary>
				/// The maximum bytes to fetch from this partition.  See KIP-74 for cases where this limit may not be honored.
				/// </summary>
				private Int32 _maxBytes = Int32.Default;
				public Int32 MaxBytes 
				{
					get => _maxBytes;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"MaxBytes does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"MaxBytes is non-nullable.");
						}

						_maxBytes = value;
					}
				}
			}
		}

		/// <summary>
		/// In an incremental fetch request, the partitions to remove.
		/// </summary>
		private ForgottenTopic[] _forgottenCollection = System.Array.Empty<ForgottenTopic>();
		public ForgottenTopic[] ForgottenCollection 
		{
			get => _forgottenCollection;
			set 
			{
				if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ForgottenCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ForgottenCollection is non-nullable.");
				}

				_forgottenCollection = value;
			}
		}

		public ForgottenTopic CreateForgottenTopic()
		{
			return new ForgottenTopic(Version);
		}

		public class ForgottenTopic : ISerialize
		{
			internal ForgottenTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(7, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(7, 2147483647))) 
				{
					ForgottenPartitionIndexesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(7, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(7, 2147483647))) 
				{
					writer.Write(ForgottenPartitionIndexesCollection);
				}
			}

			/// <summary>
			/// The partition name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partitions indexes to forget.
			/// </summary>
			private Int32[] _forgottenPartitionIndexesCollection = System.Array.Empty<Int32>();
			public Int32[] ForgottenPartitionIndexesCollection 
			{
				get => _forgottenPartitionIndexesCollection;
				set 
				{
					if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ForgottenPartitionIndexesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ForgottenPartitionIndexesCollection is non-nullable.");
					}

					_forgottenPartitionIndexesCollection = value;
				}
			}
		}
	}

	public class FetchResponse
	{
		public FetchResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 10)) == false) 
			{
				throw new UnsupportedVersionException($"FetchResponse does not support version {version}. Valid versions are: 0-10");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 1;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				SessionId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new FetchableTopicResponse(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(7, 2147483647))) 
			{
				writer.WriteInt32(SessionId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The top level response error code.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The fetch session ID, or 0 if this is not part of a fetch session.
		/// </summary>
		private Int32 _sessionId = new Int32(0);
		public Int32 SessionId 
		{
			get => _sessionId;
			set 
			{
				if (Version.InRange(new VersionRange(7, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"SessionId does not support version {Version} and has been defined as not ignorable. Supported versions: 7+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"SessionId is non-nullable.");
				}

				_sessionId = value;
			}
		}

		/// <summary>
		/// The response topics.
		/// </summary>
		private FetchableTopicResponse[] _topicsCollection = System.Array.Empty<FetchableTopicResponse>();
		public FetchableTopicResponse[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public FetchableTopicResponse CreateFetchableTopicResponse()
		{
			return new FetchableTopicResponse(Version);
		}

		public class FetchableTopicResponse : ISerialize
		{
			internal FetchableTopicResponse(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new FetchablePartitionResponse(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The topic partitions.
			/// </summary>
			private FetchablePartitionResponse[] _partitionsCollection = System.Array.Empty<FetchablePartitionResponse>();
			public FetchablePartitionResponse[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public FetchablePartitionResponse CreateFetchablePartitionResponse()
			{
				return new FetchablePartitionResponse(Version);
			}

			public class FetchablePartitionResponse : ISerialize
			{
				internal FetchablePartitionResponse(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						HighWatermark = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						LastStableOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						LogStartOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						AbortedCollection = reader.Read(() => new AbortedTransaction(Version));
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Records = new Bytes(reader.ReadBytes());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(HighWatermark.Value);
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						writer.WriteInt64(LastStableOffset.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt64(LogStartOffset.Value);
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						writer.Write(AbortedCollection);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBytes(Records.Value);
					}
				}

				/// <summary>
				/// The partiiton index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no fetch error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The current high water mark.
				/// </summary>
				private Int64 _highWatermark = Int64.Default;
				public Int64 HighWatermark 
				{
					get => _highWatermark;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"HighWatermark does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"HighWatermark is non-nullable.");
						}

						_highWatermark = value;
					}
				}

				/// <summary>
				/// The last stable offset (or LSO) of the partition. This is the last offset such that the state of all transactional records prior to this offset have been decided (ABORTED or COMMITTED)
				/// </summary>
				private Int64 _lastStableOffset = new Int64(-1);
				public Int64 LastStableOffset 
				{
					get => _lastStableOffset;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LastStableOffset is non-nullable.");
						}

						_lastStableOffset = value;
					}
				}

				/// <summary>
				/// The current log start offset.
				/// </summary>
				private Int64 _logStartOffset = new Int64(-1);
				public Int64 LogStartOffset 
				{
					get => _logStartOffset;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LogStartOffset is non-nullable.");
						}

						_logStartOffset = value;
					}
				}

				/// <summary>
				/// The aborted transactions.
				/// </summary>
				private AbortedTransaction[] _abortedCollection = System.Array.Empty<AbortedTransaction>();
				public AbortedTransaction[] AbortedCollection 
				{
					get => _abortedCollection;
					set 
					{
						if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"AbortedCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
						}

						if (Version.InRange(new VersionRange(4, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"AbortedCollection does not support null for version {Version}. Supported versions for null value: 4+");
						}

						_abortedCollection = value;
					}
				}

				public AbortedTransaction CreateAbortedTransaction()
				{
					return new AbortedTransaction(Version);
				}

				public class AbortedTransaction : ISerialize
				{
					internal AbortedTransaction(int version)
					{
						Version = version;
					}

					internal int Version { get; }

					public void ReadFrom(IKafkaReader reader)
					{
						if (Version.InRange(new VersionRange(4, 2147483647))) 
						{
							ProducerId = new Int64(reader.ReadInt64());
						}
						if (Version.InRange(new VersionRange(4, 2147483647))) 
						{
							FirstOffset = new Int64(reader.ReadInt64());
						}
					}

					public void WriteTo(IKafkaWriter writer)
					{
						if (Version.InRange(new VersionRange(4, 2147483647))) 
						{
							writer.WriteInt64(ProducerId.Value);
						}
						if (Version.InRange(new VersionRange(4, 2147483647))) 
						{
							writer.WriteInt64(FirstOffset.Value);
						}
					}

					/// <summary>
					/// The producer id associated with the aborted transaction.
					/// </summary>
					private Int64 _producerId = Int64.Default;
					public Int64 ProducerId 
					{
						get => _producerId;
						set 
						{
							if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"ProducerId is non-nullable.");
							}

							_producerId = value;
						}
					}

					/// <summary>
					/// The first offset in the aborted transaction.
					/// </summary>
					private Int64 _firstOffset = Int64.Default;
					public Int64 FirstOffset 
					{
						get => _firstOffset;
						set 
						{
							if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"FirstOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"FirstOffset is non-nullable.");
							}

							_firstOffset = value;
						}
					}
				}

				/// <summary>
				/// The record data.
				/// </summary>
				private Bytes _records = Bytes.Default;
				public Bytes Records 
				{
					get => _records;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Records does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Records does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_records = value;
					}
				}
			}
		}
	}

	public class FindCoordinatorRequest
	{
		public FindCoordinatorRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"FindCoordinatorRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 10;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Key = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				KeyType = new Int8(reader.ReadInt8());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(Key.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt8(KeyType.Value);
			}
		}

		/// <summary>
		/// The coordinator key.
		/// </summary>
		private String _key = String.Default;
		public String Key 
		{
			get => _key;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Key does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Key is non-nullable.");
				}

				_key = value;
			}
		}

		/// <summary>
		/// The coordinator key type.  (Group, transaction, etc.)
		/// </summary>
		private Int8 _keyType = new Int8(0);
		public Int8 KeyType 
		{
			get => _keyType;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"KeyType does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"KeyType is non-nullable.");
				}

				_keyType = value;
			}
		}
	}

	public class FindCoordinatorResponse
	{
		public FindCoordinatorResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"FindCoordinatorResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 10;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ErrorMessage = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				NodeId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Host = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Port = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteString(ErrorMessage.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(NodeId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(Host.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(Port.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The error message, or null if there was no error.
		/// </summary>
		private String _errorMessage = String.Default;
		public String ErrorMessage 
		{
			get => _errorMessage;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 1+");
				}

				_errorMessage = value;
			}
		}

		/// <summary>
		/// The node id.
		/// </summary>
		private Int32 _nodeId = Int32.Default;
		public Int32 NodeId 
		{
			get => _nodeId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"NodeId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"NodeId is non-nullable.");
				}

				_nodeId = value;
			}
		}

		/// <summary>
		/// The host name.
		/// </summary>
		private String _host = String.Default;
		public String Host 
		{
			get => _host;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Host is non-nullable.");
				}

				_host = value;
			}
		}

		/// <summary>
		/// The port.
		/// </summary>
		private Int32 _port = Int32.Default;
		public Int32 Port 
		{
			get => _port;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Port does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Port is non-nullable.");
				}

				_port = value;
			}
		}
	}

	public class HeartbeatRequest
	{
		public HeartbeatRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"HeartbeatRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 12;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Generationid = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(Generationid.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
		}

		/// <summary>
		/// The group id.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The generation of the group.
		/// </summary>
		private Int32 _generationid = Int32.Default;
		public Int32 Generationid 
		{
			get => _generationid;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Generationid does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Generationid is non-nullable.");
				}

				_generationid = value;
			}
		}

		/// <summary>
		/// The member ID.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}
	}

	public class HeartbeatResponse
	{
		public HeartbeatResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"HeartbeatResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 12;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class InitProducerIdRequest
	{
		public InitProducerIdRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"InitProducerIdRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 22;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionTimeoutMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TransactionTimeoutMs.Value);
			}
		}

		/// <summary>
		/// The transactional id, or null if the producer is not transactional.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// The time in ms to wait for before aborting idle transactions sent by this producer.
		/// </summary>
		private Int32 _transactionTimeoutMs = Int32.Default;
		public Int32 TransactionTimeoutMs 
		{
			get => _transactionTimeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionTimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TransactionTimeoutMs is non-nullable.");
				}

				_transactionTimeoutMs = value;
			}
		}
	}

	public class InitProducerIdResponse
	{
		public InitProducerIdResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"InitProducerIdResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 22;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerId = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerEpoch = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ProducerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ProducerEpoch.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The current producer id.
		/// </summary>
		private Int64 _producerId = Int64.Default;
		public Int64 ProducerId 
		{
			get => _producerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerId is non-nullable.");
				}

				_producerId = value;
			}
		}

		/// <summary>
		/// The current epoch associated with the producer id.
		/// </summary>
		private Int16 _producerEpoch = Int16.Default;
		public Int16 ProducerEpoch 
		{
			get => _producerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
				}

				_producerEpoch = value;
			}
		}
	}

	public class JoinGroupRequest
	{
		public JoinGroupRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 4)) == false) 
			{
				throw new UnsupportedVersionException($"JoinGroupRequest does not support version {version}. Valid versions are: 0-4");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 11;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				SessionTimeoutMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				RebalanceTimeoutMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProtocolType = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProtocolsCollection = reader.Read(() => new JoinGroupRequestProtocol(Version)).ToDictionary(field => field.Name);
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(SessionTimeoutMs.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(RebalanceTimeoutMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ProtocolType.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ProtocolsCollection.Values.ToArray());
			}
		}

		/// <summary>
		/// The group identifier.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The coordinator considers the consumer dead if it receives no heartbeat after this timeout in milliseconds.
		/// </summary>
		private Int32 _sessionTimeoutMs = Int32.Default;
		public Int32 SessionTimeoutMs 
		{
			get => _sessionTimeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"SessionTimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"SessionTimeoutMs is non-nullable.");
				}

				_sessionTimeoutMs = value;
			}
		}

		/// <summary>
		/// The maximum time in milliseconds that the coordinator will wait for each member to rejoin when rebalancing the group.
		/// </summary>
		private Int32 _rebalanceTimeoutMs = new Int32(-1);
		public Int32 RebalanceTimeoutMs 
		{
			get => _rebalanceTimeoutMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"RebalanceTimeoutMs is non-nullable.");
				}

				_rebalanceTimeoutMs = value;
			}
		}

		/// <summary>
		/// The member id assigned by the group coordinator.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}

		/// <summary>
		/// The unique name the for class of protocols implemented by the group we want to join.
		/// </summary>
		private String _protocolType = String.Default;
		public String ProtocolType 
		{
			get => _protocolType;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProtocolType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProtocolType is non-nullable.");
				}

				_protocolType = value;
			}
		}

		/// <summary>
		/// The list of protocols that the member supports.
		/// </summary>
		private Dictionary<String, JoinGroupRequestProtocol> _protocolsCollection = new Dictionary<String, JoinGroupRequestProtocol>();
		public Dictionary<String, JoinGroupRequestProtocol> ProtocolsCollection 
		{
			get => _protocolsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProtocolsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProtocolsCollection is non-nullable.");
				}

				_protocolsCollection = value;
			}
		}

		public JoinGroupRequestProtocol CreateJoinGroupRequestProtocol()
		{
			return new JoinGroupRequestProtocol(Version);
		}

		public class JoinGroupRequestProtocol : ISerialize
		{
			internal JoinGroupRequestProtocol(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Metadata = new Bytes(reader.ReadBytes());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteBytes(Metadata.Value);
				}
			}

			/// <summary>
			/// The protocol name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The protocol metadata.
			/// </summary>
			private Bytes _metadata = Bytes.Default;
			public Bytes Metadata 
			{
				get => _metadata;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Metadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Metadata is non-nullable.");
					}

					_metadata = value;
				}
			}
		}
	}

	public class JoinGroupResponse
	{
		public JoinGroupResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 4)) == false) 
			{
				throw new UnsupportedVersionException($"JoinGroupResponse does not support version {version}. Valid versions are: 0-4");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 11;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GenerationId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProtocolName = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Leader = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MembersCollection = reader.Read(() => new JoinGroupResponseMember(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(GenerationId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ProtocolName.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(Leader.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(MembersCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The generation ID of the group.
		/// </summary>
		private Int32 _generationId = new Int32(-1);
		public Int32 GenerationId 
		{
			get => _generationId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GenerationId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GenerationId is non-nullable.");
				}

				_generationId = value;
			}
		}

		/// <summary>
		/// The group protocol selected by the coordinator.
		/// </summary>
		private String _protocolName = String.Default;
		public String ProtocolName 
		{
			get => _protocolName;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProtocolName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProtocolName is non-nullable.");
				}

				_protocolName = value;
			}
		}

		/// <summary>
		/// The leader of the group.
		/// </summary>
		private String _leader = String.Default;
		public String Leader 
		{
			get => _leader;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Leader does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Leader is non-nullable.");
				}

				_leader = value;
			}
		}

		/// <summary>
		/// The member ID assigned by the group coordinator.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}

		private JoinGroupResponseMember[] _membersCollection = System.Array.Empty<JoinGroupResponseMember>();
		public JoinGroupResponseMember[] MembersCollection 
		{
			get => _membersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MembersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MembersCollection is non-nullable.");
				}

				_membersCollection = value;
			}
		}

		public JoinGroupResponseMember CreateJoinGroupResponseMember()
		{
			return new JoinGroupResponseMember(Version);
		}

		public class JoinGroupResponseMember : ISerialize
		{
			internal JoinGroupResponseMember(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MemberId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Metadata = new Bytes(reader.ReadBytes());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(MemberId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteBytes(Metadata.Value);
				}
			}

			/// <summary>
			/// The group member ID.
			/// </summary>
			private String _memberId = String.Default;
			public String MemberId 
			{
				get => _memberId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MemberId is non-nullable.");
					}

					_memberId = value;
				}
			}

			/// <summary>
			/// The group member metadata.
			/// </summary>
			private Bytes _metadata = Bytes.Default;
			public Bytes Metadata 
			{
				get => _metadata;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Metadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Metadata is non-nullable.");
					}

					_metadata = value;
				}
			}
		}
	}

	public class LeaderAndIsrRequest
	{
		public LeaderAndIsrRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"LeaderAndIsrRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 4;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerEpoch = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				BrokerEpoch = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				TopicStatesCollection = reader.Read(() => new LeaderAndIsrRequestTopicState(Version));
			}
			if (Version.InRange(new VersionRange(0, 1))) 
			{
				PartitionStatesV0Collection = reader.Read(() => new LeaderAndIsrRequestPartitionStateV0(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				LiveLeadersCollection = reader.Read(() => new LeaderAndIsrLiveLeader(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt64(BrokerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.Write(TopicStatesCollection);
			}
			if (Version.InRange(new VersionRange(0, 1))) 
			{
				writer.Write(PartitionStatesV0Collection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(LiveLeadersCollection);
			}
		}

		/// <summary>
		/// The current controller ID.
		/// </summary>
		private Int32 _controllerId = Int32.Default;
		public Int32 ControllerId 
		{
			get => _controllerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerId is non-nullable.");
				}

				_controllerId = value;
			}
		}

		/// <summary>
		/// The current controller epoch.
		/// </summary>
		private Int32 _controllerEpoch = Int32.Default;
		public Int32 ControllerEpoch 
		{
			get => _controllerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
				}

				_controllerEpoch = value;
			}
		}

		/// <summary>
		/// The current broker epoch.
		/// </summary>
		private Int64 _brokerEpoch = new Int64(-1);
		public Int64 BrokerEpoch 
		{
			get => _brokerEpoch;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokerEpoch is non-nullable.");
				}

				_brokerEpoch = value;
			}
		}

		/// <summary>
		/// Each topic.
		/// </summary>
		private LeaderAndIsrRequestTopicState[] _topicStatesCollection = System.Array.Empty<LeaderAndIsrRequestTopicState>();
		public LeaderAndIsrRequestTopicState[] TopicStatesCollection 
		{
			get => _topicStatesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(2, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicStatesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 2+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicStatesCollection is non-nullable.");
				}

				_topicStatesCollection = value;
			}
		}

		public LeaderAndIsrRequestTopicState CreateLeaderAndIsrRequestTopicState()
		{
			return new LeaderAndIsrRequestTopicState(Version);
		}

		public class LeaderAndIsrRequestTopicState : ISerialize
		{
			internal LeaderAndIsrRequestTopicState(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(2, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionStatesCollection = reader.Read(() => new LeaderAndIsrRequestPartitionState(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(2, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionStatesCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(2, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 2+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The state of each partition
			/// </summary>
			private LeaderAndIsrRequestPartitionState[] _partitionStatesCollection = System.Array.Empty<LeaderAndIsrRequestPartitionState>();
			public LeaderAndIsrRequestPartitionState[] PartitionStatesCollection 
			{
				get => _partitionStatesCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionStatesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionStatesCollection is non-nullable.");
					}

					_partitionStatesCollection = value;
				}
			}

			public LeaderAndIsrRequestPartitionState CreateLeaderAndIsrRequestPartitionState()
			{
				return new LeaderAndIsrRequestPartitionState(Version);
			}

			public class LeaderAndIsrRequestPartitionState : ISerialize
			{
				internal LeaderAndIsrRequestPartitionState(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ControllerEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						LeaderKey = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						IsrReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ZkVersion = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						IsNew = new Boolean(reader.ReadBoolean());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(ControllerEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(LeaderKey.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(IsrReplicasCollection);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(ZkVersion.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(ReplicasCollection);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteBoolean(IsNew.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The controller epoch.
				/// </summary>
				private Int32 _controllerEpoch = Int32.Default;
				public Int32 ControllerEpoch 
				{
					get => _controllerEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
						}

						_controllerEpoch = value;
					}
				}

				/// <summary>
				/// The broker ID of the leader.
				/// </summary>
				private Int32 _leaderKey = Int32.Default;
				public Int32 LeaderKey 
				{
					get => _leaderKey;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderKey does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderKey is non-nullable.");
						}

						_leaderKey = value;
					}
				}

				/// <summary>
				/// The leader epoch.
				/// </summary>
				private Int32 _leaderEpoch = Int32.Default;
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}

				/// <summary>
				/// The in-sync replica IDs.
				/// </summary>
				private Int32[] _isrReplicasCollection = System.Array.Empty<Int32>();
				public Int32[] IsrReplicasCollection 
				{
					get => _isrReplicasCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"IsrReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsrReplicasCollection is non-nullable.");
						}

						_isrReplicasCollection = value;
					}
				}

				/// <summary>
				/// The ZooKeeper version.
				/// </summary>
				private Int32 _zkVersion = Int32.Default;
				public Int32 ZkVersion 
				{
					get => _zkVersion;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ZkVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ZkVersion is non-nullable.");
						}

						_zkVersion = value;
					}
				}

				/// <summary>
				/// The replica IDs.
				/// </summary>
				private Int32[] _replicasCollection = System.Array.Empty<Int32>();
				public Int32[] ReplicasCollection 
				{
					get => _replicasCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ReplicasCollection is non-nullable.");
						}

						_replicasCollection = value;
					}
				}

				/// <summary>
				/// Whether the replica should have existed on the broker or not.
				/// </summary>
				private Boolean _isNew = new Boolean(false);
				public Boolean IsNew 
				{
					get => _isNew;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsNew is non-nullable.");
						}

						_isNew = value;
					}
				}
			}
		}

		/// <summary>
		/// The state of each partition
		/// </summary>
		private LeaderAndIsrRequestPartitionStateV0[] _partitionStatesV0Collection = System.Array.Empty<LeaderAndIsrRequestPartitionStateV0>();
		public LeaderAndIsrRequestPartitionStateV0[] PartitionStatesV0Collection 
		{
			get => _partitionStatesV0Collection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 1)) == false) 
				{
					throw new UnsupportedVersionException($"PartitionStatesV0Collection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PartitionStatesV0Collection is non-nullable.");
				}

				_partitionStatesV0Collection = value;
			}
		}

		public LeaderAndIsrRequestPartitionStateV0 CreateLeaderAndIsrRequestPartitionStateV0()
		{
			return new LeaderAndIsrRequestPartitionStateV0(Version);
		}

		public class LeaderAndIsrRequestPartitionStateV0 : ISerialize
		{
			internal LeaderAndIsrRequestPartitionStateV0(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					ControllerEpoch = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					LeaderKey = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					LeaderEpoch = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					IsrReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					ZkVersion = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					ReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					IsNew = new Boolean(reader.ReadBoolean());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteInt32(ControllerEpoch.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteInt32(LeaderKey.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteInt32(LeaderEpoch.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.Write(IsrReplicasCollection);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.WriteInt32(ZkVersion.Value);
				}
				if (Version.InRange(new VersionRange(0, 1))) 
				{
					writer.Write(ReplicasCollection);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteBoolean(IsNew.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition index.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}

			/// <summary>
			/// The controller epoch.
			/// </summary>
			private Int32 _controllerEpoch = Int32.Default;
			public Int32 ControllerEpoch 
			{
				get => _controllerEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
					}

					_controllerEpoch = value;
				}
			}

			/// <summary>
			/// The broker ID of the leader.
			/// </summary>
			private Int32 _leaderKey = Int32.Default;
			public Int32 LeaderKey 
			{
				get => _leaderKey;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"LeaderKey does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"LeaderKey is non-nullable.");
					}

					_leaderKey = value;
				}
			}

			/// <summary>
			/// The leader epoch.
			/// </summary>
			private Int32 _leaderEpoch = Int32.Default;
			public Int32 LeaderEpoch 
			{
				get => _leaderEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
					}

					_leaderEpoch = value;
				}
			}

			/// <summary>
			/// The in-sync replica IDs.
			/// </summary>
			private Int32[] _isrReplicasCollection = System.Array.Empty<Int32>();
			public Int32[] IsrReplicasCollection 
			{
				get => _isrReplicasCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"IsrReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"IsrReplicasCollection is non-nullable.");
					}

					_isrReplicasCollection = value;
				}
			}

			/// <summary>
			/// The ZooKeeper version.
			/// </summary>
			private Int32 _zkVersion = Int32.Default;
			public Int32 ZkVersion 
			{
				get => _zkVersion;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"ZkVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ZkVersion is non-nullable.");
					}

					_zkVersion = value;
				}
			}

			/// <summary>
			/// The replica IDs.
			/// </summary>
			private Int32[] _replicasCollection = System.Array.Empty<Int32>();
			public Int32[] ReplicasCollection 
			{
				get => _replicasCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 1)) == false) 
					{
						throw new UnsupportedVersionException($"ReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-1");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ReplicasCollection is non-nullable.");
					}

					_replicasCollection = value;
				}
			}

			/// <summary>
			/// Whether the replica should have existed on the broker or not.
			/// </summary>
			private Boolean _isNew = new Boolean(false);
			public Boolean IsNew 
			{
				get => _isNew;
				set 
				{
					if (value == null) 
					{
						throw new UnsupportedVersionException($"IsNew is non-nullable.");
					}

					_isNew = value;
				}
			}
		}

		/// <summary>
		/// The current live leaders.
		/// </summary>
		private LeaderAndIsrLiveLeader[] _liveLeadersCollection = System.Array.Empty<LeaderAndIsrLiveLeader>();
		public LeaderAndIsrLiveLeader[] LiveLeadersCollection 
		{
			get => _liveLeadersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"LiveLeadersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"LiveLeadersCollection is non-nullable.");
				}

				_liveLeadersCollection = value;
			}
		}

		public LeaderAndIsrLiveLeader CreateLeaderAndIsrLiveLeader()
		{
			return new LeaderAndIsrLiveLeader(Version);
		}

		public class LeaderAndIsrLiveLeader : ISerialize
		{
			internal LeaderAndIsrLiveLeader(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					BrokerId = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					HostName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Port = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(BrokerId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(HostName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(Port.Value);
				}
			}

			/// <summary>
			/// The leader's broker ID.
			/// </summary>
			private Int32 _brokerId = Int32.Default;
			public Int32 BrokerId 
			{
				get => _brokerId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"BrokerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"BrokerId is non-nullable.");
					}

					_brokerId = value;
				}
			}

			/// <summary>
			/// The leader's hostname.
			/// </summary>
			private String _hostName = String.Default;
			public String HostName 
			{
				get => _hostName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"HostName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"HostName is non-nullable.");
					}

					_hostName = value;
				}
			}

			/// <summary>
			/// The leader's port.
			/// </summary>
			private Int32 _port = Int32.Default;
			public Int32 Port 
			{
				get => _port;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Port does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Port is non-nullable.");
					}

					_port = value;
				}
			}
		}
	}

	public class LeaderAndIsrResponse
	{
		public LeaderAndIsrResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"LeaderAndIsrResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 4;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PartitionsCollection = reader.Read(() => new LeaderAndIsrResponsePartition(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(PartitionsCollection);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// Each partition.
		/// </summary>
		private LeaderAndIsrResponsePartition[] _partitionsCollection = System.Array.Empty<LeaderAndIsrResponsePartition>();
		public LeaderAndIsrResponsePartition[] PartitionsCollection 
		{
			get => _partitionsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
				}

				_partitionsCollection = value;
			}
		}

		public LeaderAndIsrResponsePartition CreateLeaderAndIsrResponsePartition()
		{
			return new LeaderAndIsrResponsePartition(Version);
		}

		public class LeaderAndIsrResponsePartition : ISerialize
		{
			internal LeaderAndIsrResponsePartition(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition index.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}

			/// <summary>
			/// The partition error code, or 0 if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}
		}
	}

	public class LeaveGroupRequest
	{
		public LeaveGroupRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"LeaveGroupRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 13;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
		}

		/// <summary>
		/// The ID of the group to leave.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The member ID to remove from the group.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}
	}

	public class LeaveGroupResponse
	{
		public LeaveGroupResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"LeaveGroupResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 13;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class ListGroupsRequest
	{
		public ListGroupsRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ListGroupsRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 16;

		public void ReadFrom(IKafkaReader reader)
		{

		}

		public void WriteTo(IKafkaWriter writer)
		{

		}


	}

	public class ListGroupsResponse
	{
		public ListGroupsResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"ListGroupsResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 16;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupsCollection = reader.Read(() => new ListedGroup(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(GroupsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// Each group in the response.
		/// </summary>
		private ListedGroup[] _groupsCollection = System.Array.Empty<ListedGroup>();
		public ListedGroup[] GroupsCollection 
		{
			get => _groupsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupsCollection is non-nullable.");
				}

				_groupsCollection = value;
			}
		}

		public ListedGroup CreateListedGroup()
		{
			return new ListedGroup(Version);
		}

		public class ListedGroup : ISerialize
		{
			internal ListedGroup(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					GroupId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProtocolType = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(GroupId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(ProtocolType.Value);
				}
			}

			/// <summary>
			/// The group ID.
			/// </summary>
			private String _groupId = String.Default;
			public String GroupId 
			{
				get => _groupId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"GroupId is non-nullable.");
					}

					_groupId = value;
				}
			}

			/// <summary>
			/// The group protocol type.
			/// </summary>
			private String _protocolType = String.Default;
			public String ProtocolType 
			{
				get => _protocolType;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProtocolType does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProtocolType is non-nullable.");
					}

					_protocolType = value;
				}
			}
		}
	}

	public class ListOffsetRequest
	{
		public ListOffsetRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"ListOffsetRequest does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 2;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ReplicaId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				IsolationLevel = new Int8(reader.ReadInt8());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new ListOffsetTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ReplicaId.Value);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt8(IsolationLevel.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The broker ID of the requestor, or -1 if this request is being made by a normal consumer.
		/// </summary>
		private Int32 _replicaId = Int32.Default;
		public Int32 ReplicaId 
		{
			get => _replicaId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ReplicaId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ReplicaId is non-nullable.");
				}

				_replicaId = value;
			}
		}

		/// <summary>
		/// This setting controls the visibility of transactional records. Using READ_UNCOMMITTED (isolation_level = 0) makes all records visible. With READ_COMMITTED (isolation_level = 1), non-transactional and COMMITTED transactional records are visible. To be more concrete, READ_COMMITTED returns all data from offsets smaller than the current LSO (last stable offset), and enables the inclusion of the list of aborted transactions in the result, which allows consumers to discard ABORTED transactional records
		/// </summary>
		private Int8 _isolationLevel = Int8.Default;
		public Int8 IsolationLevel 
		{
			get => _isolationLevel;
			set 
			{
				if (Version.InRange(new VersionRange(2, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IsolationLevel does not support version {Version} and has been defined as not ignorable. Supported versions: 2+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IsolationLevel is non-nullable.");
				}

				_isolationLevel = value;
			}
		}

		/// <summary>
		/// Each topic in the request.
		/// </summary>
		private ListOffsetTopic[] _topicsCollection = System.Array.Empty<ListOffsetTopic>();
		public ListOffsetTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public ListOffsetTopic CreateListOffsetTopic()
		{
			return new ListOffsetTopic(Version);
		}

		public class ListOffsetTopic : ISerialize
		{
			internal ListOffsetTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new ListOffsetPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition in the request.
			/// </summary>
			private ListOffsetPartition[] _partitionsCollection = System.Array.Empty<ListOffsetPartition>();
			public ListOffsetPartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public ListOffsetPartition CreateListOffsetPartition()
			{
				return new ListOffsetPartition(Version);
			}

			public class ListOffsetPartition : ISerialize
			{
				internal ListOffsetPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						CurrentLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Timestamp = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						MaxNumOffsets = new Int32(reader.ReadInt32());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						writer.WriteInt32(CurrentLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(Timestamp.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(MaxNumOffsets.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The current leader epoch.
				/// </summary>
				private Int32 _currentLeaderEpoch = Int32.Default;
				public Int32 CurrentLeaderEpoch 
				{
					get => _currentLeaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CurrentLeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CurrentLeaderEpoch is non-nullable.");
						}

						_currentLeaderEpoch = value;
					}
				}

				/// <summary>
				/// The current timestamp.
				/// </summary>
				private Int64 _timestamp = Int64.Default;
				public Int64 Timestamp 
				{
					get => _timestamp;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Timestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Timestamp is non-nullable.");
						}

						_timestamp = value;
					}
				}

				/// <summary>
				/// The maximum number of offsets to report.
				/// </summary>
				private Int32 _maxNumOffsets = Int32.Default;
				public Int32 MaxNumOffsets 
				{
					get => _maxNumOffsets;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"MaxNumOffsets does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"MaxNumOffsets is non-nullable.");
						}

						_maxNumOffsets = value;
					}
				}
			}
		}
	}

	public class ListOffsetResponse
	{
		public ListOffsetResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"ListOffsetResponse does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 2;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new ListOffsetTopicResponse(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Each topic in the response.
		/// </summary>
		private ListOffsetTopicResponse[] _topicsCollection = System.Array.Empty<ListOffsetTopicResponse>();
		public ListOffsetTopicResponse[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public ListOffsetTopicResponse CreateListOffsetTopicResponse()
		{
			return new ListOffsetTopicResponse(Version);
		}

		public class ListOffsetTopicResponse : ISerialize
		{
			internal ListOffsetTopicResponse(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new ListOffsetPartitionResponse(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition in the response.
			/// </summary>
			private ListOffsetPartitionResponse[] _partitionsCollection = System.Array.Empty<ListOffsetPartitionResponse>();
			public ListOffsetPartitionResponse[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public ListOffsetPartitionResponse CreateListOffsetPartitionResponse()
			{
				return new ListOffsetPartitionResponse(Version);
			}

			public class ListOffsetPartitionResponse : ISerialize
			{
				internal ListOffsetPartitionResponse(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						OldStyleOffsetsCollection = reader.Read(() => new Int64(reader.ReadInt64()));
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						Timestamp = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						Offset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(OldStyleOffsetsCollection);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt64(Timestamp.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt64(Offset.Value);
					}
					if (Version.InRange(new VersionRange(4, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The partition error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The result offsets.
				/// </summary>
				private Int64[] _oldStyleOffsetsCollection = System.Array.Empty<Int64>();
				public Int64[] OldStyleOffsetsCollection 
				{
					get => _oldStyleOffsetsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"OldStyleOffsetsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"OldStyleOffsetsCollection is non-nullable.");
						}

						_oldStyleOffsetsCollection = value;
					}
				}

				/// <summary>
				/// The timestamp associated with the returned offset.
				/// </summary>
				private Int64 _timestamp = new Int64(-1);
				public Int64 Timestamp 
				{
					get => _timestamp;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Timestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Timestamp is non-nullable.");
						}

						_timestamp = value;
					}
				}

				/// <summary>
				/// The returned offset.
				/// </summary>
				private Int64 _offset = new Int64(-1);
				public Int64 Offset 
				{
					get => _offset;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Offset does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Offset is non-nullable.");
						}

						_offset = value;
					}
				}

				private Int32 _leaderEpoch = Int32.Default;
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}
			}
		}
	}

	public class MetadataRequest
	{
		public MetadataRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 8)) == false) 
			{
				throw new UnsupportedVersionException($"MetadataRequest does not support version {version}. Valid versions are: 0-8");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 3;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new MetadataRequestTopic(Version));
			}
			if (Version.InRange(new VersionRange(4, 2147483647))) 
			{
				AllowAutoTopicCreation = new Boolean(reader.ReadBoolean());
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				IncludeClusterAuthorizedOperations = new Boolean(reader.ReadBoolean());
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				IncludeTopicAuthorizedOperations = new Boolean(reader.ReadBoolean());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
			if (Version.InRange(new VersionRange(4, 2147483647))) 
			{
				writer.WriteBoolean(AllowAutoTopicCreation.Value);
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				writer.WriteBoolean(IncludeClusterAuthorizedOperations.Value);
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				writer.WriteBoolean(IncludeTopicAuthorizedOperations.Value);
			}
		}

		/// <summary>
		/// The topics to fetch metadata for.
		/// </summary>
		private MetadataRequestTopic[] _topicsCollection = System.Array.Empty<MetadataRequestTopic>();
		public MetadataRequestTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(1, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support null for version {Version}. Supported versions for null value: 1+");
				}

				_topicsCollection = value;
			}
		}

		public MetadataRequestTopic CreateMetadataRequestTopic()
		{
			return new MetadataRequestTopic(Version);
		}

		public class MetadataRequestTopic : ISerialize
		{
			internal MetadataRequestTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}
		}

		/// <summary>
		/// If this is true, the broker may auto-create topics that we requested which do not already exist, if it is configured to do so.
		/// </summary>
		private Boolean _allowAutoTopicCreation = new Boolean(true);
		public Boolean AllowAutoTopicCreation 
		{
			get => _allowAutoTopicCreation;
			set 
			{
				if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"AllowAutoTopicCreation does not support version {Version} and has been defined as not ignorable. Supported versions: 4+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"AllowAutoTopicCreation is non-nullable.");
				}

				_allowAutoTopicCreation = value;
			}
		}

		/// <summary>
		/// Whether to include cluster authorized operations.
		/// </summary>
		private Boolean _includeClusterAuthorizedOperations = Boolean.Default;
		public Boolean IncludeClusterAuthorizedOperations 
		{
			get => _includeClusterAuthorizedOperations;
			set 
			{
				if (Version.InRange(new VersionRange(8, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IncludeClusterAuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 8+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IncludeClusterAuthorizedOperations is non-nullable.");
				}

				_includeClusterAuthorizedOperations = value;
			}
		}

		/// <summary>
		/// Whether to include topic authorized operations.
		/// </summary>
		private Boolean _includeTopicAuthorizedOperations = Boolean.Default;
		public Boolean IncludeTopicAuthorizedOperations 
		{
			get => _includeTopicAuthorizedOperations;
			set 
			{
				if (Version.InRange(new VersionRange(8, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"IncludeTopicAuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 8+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"IncludeTopicAuthorizedOperations is non-nullable.");
				}

				_includeTopicAuthorizedOperations = value;
			}
		}
	}

	public class MetadataResponse
	{
		public MetadataResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 8)) == false) 
			{
				throw new UnsupportedVersionException($"MetadataResponse does not support version {version}. Valid versions are: 0-8");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 3;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				BrokersCollection = reader.Read(() => new MetadataResponseBroker(Version)).ToDictionary(field => field.NodeId);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ClusterId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ControllerId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new MetadataResponseTopic(Version)).ToDictionary(field => field.Name);
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				ClusterAuthorizedOperations = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(BrokersCollection.Values.ToArray());
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteString(ClusterId.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ControllerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection.Values.ToArray());
			}
			if (Version.InRange(new VersionRange(8, 2147483647))) 
			{
				writer.WriteInt32(ClusterAuthorizedOperations.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(3, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 3+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Each broker in the response.
		/// </summary>
		private Dictionary<Int32, MetadataResponseBroker> _brokersCollection = new Dictionary<Int32, MetadataResponseBroker>();
		public Dictionary<Int32, MetadataResponseBroker> BrokersCollection 
		{
			get => _brokersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"BrokersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokersCollection is non-nullable.");
				}

				_brokersCollection = value;
			}
		}

		public MetadataResponseBroker CreateMetadataResponseBroker()
		{
			return new MetadataResponseBroker(Version);
		}

		public class MetadataResponseBroker : ISerialize
		{
			internal MetadataResponseBroker(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					NodeId = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Host = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Port = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					Rack = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(NodeId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Host.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(Port.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteString(Rack.Value);
				}
			}

			/// <summary>
			/// The broker ID.
			/// </summary>
			private Int32 _nodeId = Int32.Default;
			public Int32 NodeId 
			{
				get => _nodeId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"NodeId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"NodeId is non-nullable.");
					}

					_nodeId = value;
				}
			}

			/// <summary>
			/// The broker hostname.
			/// </summary>
			private String _host = String.Default;
			public String Host 
			{
				get => _host;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Host is non-nullable.");
					}

					_host = value;
				}
			}

			/// <summary>
			/// The broker port.
			/// </summary>
			private Int32 _port = Int32.Default;
			public Int32 Port 
			{
				get => _port;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Port does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Port is non-nullable.");
					}

					_port = value;
				}
			}

			/// <summary>
			/// The rack of the broker, or null if it has not been assigned to a rack.
			/// </summary>
			private String _rack = new String(null);
			public String Rack 
			{
				get => _rack;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"Rack does not support null for version {Version}. Supported versions for null value: 1+");
					}

					_rack = value;
				}
			}
		}

		/// <summary>
		/// The cluster ID that responding broker belongs to.
		/// </summary>
		private String _clusterId = new String(null);
		public String ClusterId 
		{
			get => _clusterId;
			set 
			{
				if (Version.InRange(new VersionRange(2, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"ClusterId does not support null for version {Version}. Supported versions for null value: 2+");
				}

				_clusterId = value;
			}
		}

		/// <summary>
		/// The ID of the controller broker.
		/// </summary>
		private Int32 _controllerId = new Int32(-1);
		public Int32 ControllerId 
		{
			get => _controllerId;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerId is non-nullable.");
				}

				_controllerId = value;
			}
		}

		/// <summary>
		/// Each topic in the response.
		/// </summary>
		private Dictionary<String, MetadataResponseTopic> _topicsCollection = new Dictionary<String, MetadataResponseTopic>();
		public Dictionary<String, MetadataResponseTopic> TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public MetadataResponseTopic CreateMetadataResponseTopic()
		{
			return new MetadataResponseTopic(Version);
		}

		public class MetadataResponseTopic : ISerialize
		{
			internal MetadataResponseTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					IsInternal = new Boolean(reader.ReadBoolean());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new MetadataResponsePartition(Version));
				}
				if (Version.InRange(new VersionRange(8, 2147483647))) 
				{
					TopicAuthorizedOperations = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteBoolean(IsInternal.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
				if (Version.InRange(new VersionRange(8, 2147483647))) 
				{
					writer.WriteInt32(TopicAuthorizedOperations.Value);
				}
			}

			/// <summary>
			/// The topic error, or 0 if there was no error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// True if the topic is internal.
			/// </summary>
			private Boolean _isInternal = new Boolean(false);
			public Boolean IsInternal 
			{
				get => _isInternal;
				set 
				{
					if (value == null) 
					{
						throw new UnsupportedVersionException($"IsInternal is non-nullable.");
					}

					_isInternal = value;
				}
			}

			/// <summary>
			/// Each partition in the topic.
			/// </summary>
			private MetadataResponsePartition[] _partitionsCollection = System.Array.Empty<MetadataResponsePartition>();
			public MetadataResponsePartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public MetadataResponsePartition CreateMetadataResponsePartition()
			{
				return new MetadataResponsePartition(Version);
			}

			public class MetadataResponsePartition : ISerialize
			{
				internal MetadataResponsePartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						LeaderId = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(7, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ReplicaNodesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						IsrNodesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						OfflineReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(LeaderId.Value);
					}
					if (Version.InRange(new VersionRange(7, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(ReplicaNodesCollection);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(IsrNodesCollection);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.Write(OfflineReplicasCollection);
					}
				}

				/// <summary>
				/// The partition error, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The ID of the leader broker.
				/// </summary>
				private Int32 _leaderId = Int32.Default;
				public Int32 LeaderId 
				{
					get => _leaderId;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderId is non-nullable.");
						}

						_leaderId = value;
					}
				}

				/// <summary>
				/// The leader epoch of this partition.
				/// </summary>
				private Int32 _leaderEpoch = new Int32(-1);
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}

				/// <summary>
				/// The set of all nodes that host this partition.
				/// </summary>
				private Int32[] _replicaNodesCollection = System.Array.Empty<Int32>();
				public Int32[] ReplicaNodesCollection 
				{
					get => _replicaNodesCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ReplicaNodesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ReplicaNodesCollection is non-nullable.");
						}

						_replicaNodesCollection = value;
					}
				}

				/// <summary>
				/// The set of nodes that are in sync with the leader for this partition.
				/// </summary>
				private Int32[] _isrNodesCollection = System.Array.Empty<Int32>();
				public Int32[] IsrNodesCollection 
				{
					get => _isrNodesCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"IsrNodesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsrNodesCollection is non-nullable.");
						}

						_isrNodesCollection = value;
					}
				}

				/// <summary>
				/// The set of offline replicas of this partition.
				/// </summary>
				private Int32[] _offlineReplicasCollection = System.Array.Empty<Int32>();
				public Int32[] OfflineReplicasCollection 
				{
					get => _offlineReplicasCollection;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"OfflineReplicasCollection is non-nullable.");
						}

						_offlineReplicasCollection = value;
					}
				}
			}

			/// <summary>
			/// 32-bit bitfield to represent authorized operations for this topic.
			/// </summary>
			private Int32 _topicAuthorizedOperations = Int32.Default;
			public Int32 TopicAuthorizedOperations 
			{
				get => _topicAuthorizedOperations;
				set 
				{
					if (Version.InRange(new VersionRange(8, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicAuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 8+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicAuthorizedOperations is non-nullable.");
					}

					_topicAuthorizedOperations = value;
				}
			}
		}

		/// <summary>
		/// 32-bit bitfield to represent authorized operations for this cluster.
		/// </summary>
		private Int32 _clusterAuthorizedOperations = Int32.Default;
		public Int32 ClusterAuthorizedOperations 
		{
			get => _clusterAuthorizedOperations;
			set 
			{
				if (Version.InRange(new VersionRange(8, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ClusterAuthorizedOperations does not support version {Version} and has been defined as not ignorable. Supported versions: 8+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ClusterAuthorizedOperations is non-nullable.");
				}

				_clusterAuthorizedOperations = value;
			}
		}
	}

	public class OffsetCommitRequest
	{
		public OffsetCommitRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 6)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetCommitRequest does not support version {version}. Valid versions are: 0-6");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 8;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				GenerationId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(2, 4))) 
			{
				RetentionTimeMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetCommitRequestTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(GenerationId.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
			if (Version.InRange(new VersionRange(2, 4))) 
			{
				writer.WriteInt64(RetentionTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The unique group identifier.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The generation of the group.
		/// </summary>
		private Int32 _generationId = new Int32(-1);
		public Int32 GenerationId 
		{
			get => _generationId;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"GenerationId is non-nullable.");
				}

				_generationId = value;
			}
		}

		/// <summary>
		/// The member ID assigned by the group coordinator.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}

		/// <summary>
		/// The time period in ms to retain the offset.
		/// </summary>
		private Int64 _retentionTimeMs = new Int64(-1);
		public Int64 RetentionTimeMs 
		{
			get => _retentionTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"RetentionTimeMs is non-nullable.");
				}

				_retentionTimeMs = value;
			}
		}

		/// <summary>
		/// The topics to commit offsets for.
		/// </summary>
		private OffsetCommitRequestTopic[] _topicsCollection = System.Array.Empty<OffsetCommitRequestTopic>();
		public OffsetCommitRequestTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public OffsetCommitRequestTopic CreateOffsetCommitRequestTopic()
		{
			return new OffsetCommitRequestTopic(Version);
		}

		public class OffsetCommitRequestTopic : ISerialize
		{
			internal OffsetCommitRequestTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new OffsetCommitRequestPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition to commit offsets for.
			/// </summary>
			private OffsetCommitRequestPartition[] _partitionsCollection = System.Array.Empty<OffsetCommitRequestPartition>();
			public OffsetCommitRequestPartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public OffsetCommitRequestPartition CreateOffsetCommitRequestPartition()
			{
				return new OffsetCommitRequestPartition(Version);
			}

			public class OffsetCommitRequestPartition : ISerialize
			{
				internal OffsetCommitRequestPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						CommittedOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(6, 2147483647))) 
					{
						CommittedLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						CommitTimestamp = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						CommittedMetadata = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(CommittedOffset.Value);
					}
					if (Version.InRange(new VersionRange(6, 2147483647))) 
					{
						writer.WriteInt32(CommittedLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt64(CommitTimestamp.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(CommittedMetadata.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The message offset to be committed.
				/// </summary>
				private Int64 _committedOffset = Int64.Default;
				public Int64 CommittedOffset 
				{
					get => _committedOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedOffset is non-nullable.");
						}

						_committedOffset = value;
					}
				}

				/// <summary>
				/// The leader epoch of this partition.
				/// </summary>
				private Int32 _committedLeaderEpoch = new Int32(-1);
				public Int32 CommittedLeaderEpoch 
				{
					get => _committedLeaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedLeaderEpoch is non-nullable.");
						}

						_committedLeaderEpoch = value;
					}
				}

				/// <summary>
				/// The timestamp of the commit.
				/// </summary>
				private Int64 _commitTimestamp = new Int64(-1);
				public Int64 CommitTimestamp 
				{
					get => _commitTimestamp;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommitTimestamp does not support version {Version} and has been defined as not ignorable. Supported versions: 1");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommitTimestamp is non-nullable.");
						}

						_commitTimestamp = value;
					}
				}

				/// <summary>
				/// Any associated metadata the client wants to keep.
				/// </summary>
				private String _committedMetadata = String.Default;
				public String CommittedMetadata 
				{
					get => _committedMetadata;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedMetadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"CommittedMetadata does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_committedMetadata = value;
					}
				}
			}
		}
	}

	public class OffsetCommitResponse
	{
		public OffsetCommitResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 6)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetCommitResponse does not support version {version}. Valid versions are: 0-6");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 8;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetCommitResponseTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The responses for each topic.
		/// </summary>
		private OffsetCommitResponseTopic[] _topicsCollection = System.Array.Empty<OffsetCommitResponseTopic>();
		public OffsetCommitResponseTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public OffsetCommitResponseTopic CreateOffsetCommitResponseTopic()
		{
			return new OffsetCommitResponseTopic(Version);
		}

		public class OffsetCommitResponseTopic : ISerialize
		{
			internal OffsetCommitResponseTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new OffsetCommitResponsePartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The responses for each partition in the topic.
			/// </summary>
			private OffsetCommitResponsePartition[] _partitionsCollection = System.Array.Empty<OffsetCommitResponsePartition>();
			public OffsetCommitResponsePartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public OffsetCommitResponsePartition CreateOffsetCommitResponsePartition()
			{
				return new OffsetCommitResponsePartition(Version);
			}

			public class OffsetCommitResponsePartition : ISerialize
			{
				internal OffsetCommitResponsePartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}
	}

	public class OffsetFetchRequest
	{
		public OffsetFetchRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetFetchRequest does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 9;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetFetchRequestTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The group to fetch offsets for.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// Each topic we would like to fetch offsets for, or null to fetch offsets for all topics.
		/// </summary>
		private OffsetFetchRequestTopic[] _topicsCollection = System.Array.Empty<OffsetFetchRequestTopic>();
		public OffsetFetchRequestTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(2, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support null for version {Version}. Supported versions for null value: 2+");
				}

				_topicsCollection = value;
			}
		}

		public OffsetFetchRequestTopic CreateOffsetFetchRequestTopic()
		{
			return new OffsetFetchRequestTopic(Version);
		}

		public class OffsetFetchRequestTopic : ISerialize
		{
			internal OffsetFetchRequestTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndexesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionIndexesCollection);
				}
			}

			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partition indexes we would like to fetch offsets for.
			/// </summary>
			private Int32[] _partitionIndexesCollection = System.Array.Empty<Int32>();
			public Int32[] PartitionIndexesCollection 
			{
				get => _partitionIndexesCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndexesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndexesCollection is non-nullable.");
					}

					_partitionIndexesCollection = value;
				}
			}
		}
	}

	public class OffsetFetchResponse
	{
		public OffsetFetchResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetFetchResponse does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 9;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetFetchResponseTopic(Version));
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The responses per topic.
		/// </summary>
		private OffsetFetchResponseTopic[] _topicsCollection = System.Array.Empty<OffsetFetchResponseTopic>();
		public OffsetFetchResponseTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public OffsetFetchResponseTopic CreateOffsetFetchResponseTopic()
		{
			return new OffsetFetchResponseTopic(Version);
		}

		public class OffsetFetchResponseTopic : ISerialize
		{
			internal OffsetFetchResponseTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new OffsetFetchResponsePartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The responses per partition
			/// </summary>
			private OffsetFetchResponsePartition[] _partitionsCollection = System.Array.Empty<OffsetFetchResponsePartition>();
			public OffsetFetchResponsePartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public OffsetFetchResponsePartition CreateOffsetFetchResponsePartition()
			{
				return new OffsetFetchResponsePartition(Version);
			}

			public class OffsetFetchResponsePartition : ISerialize
			{
				internal OffsetFetchResponsePartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						CommittedOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						CommittedLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Metadata = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(CommittedOffset.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(CommittedLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Metadata.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The committed message offset.
				/// </summary>
				private Int64 _committedOffset = Int64.Default;
				public Int64 CommittedOffset 
				{
					get => _committedOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedOffset is non-nullable.");
						}

						_committedOffset = value;
					}
				}

				/// <summary>
				/// The leader epoch.
				/// </summary>
				private Int32 _committedLeaderEpoch = Int32.Default;
				public Int32 CommittedLeaderEpoch 
				{
					get => _committedLeaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedLeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedLeaderEpoch is non-nullable.");
						}

						_committedLeaderEpoch = value;
					}
				}

				/// <summary>
				/// The partition metadata.
				/// </summary>
				private String _metadata = String.Default;
				public String Metadata 
				{
					get => _metadata;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Metadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Metadata does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_metadata = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}

		/// <summary>
		/// The top-level error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = new Int16(0);
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(2, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 2+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class OffsetForLeaderEpochRequest
	{
		public OffsetForLeaderEpochRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetForLeaderEpochRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 23;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetForLeaderTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// Each topic to get offsets for.
		/// </summary>
		private OffsetForLeaderTopic[] _topicsCollection = System.Array.Empty<OffsetForLeaderTopic>();
		public OffsetForLeaderTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public OffsetForLeaderTopic CreateOffsetForLeaderTopic()
		{
			return new OffsetForLeaderTopic(Version);
		}

		public class OffsetForLeaderTopic : ISerialize
		{
			internal OffsetForLeaderTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new OffsetForLeaderPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition to get offsets for.
			/// </summary>
			private OffsetForLeaderPartition[] _partitionsCollection = System.Array.Empty<OffsetForLeaderPartition>();
			public OffsetForLeaderPartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public OffsetForLeaderPartition CreateOffsetForLeaderPartition()
			{
				return new OffsetForLeaderPartition(Version);
			}

			public class OffsetForLeaderPartition : ISerialize
			{
				internal OffsetForLeaderPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						CurrentLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						writer.WriteInt32(CurrentLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// An epoch used to fence consumers/replicas with old metadata.  If the epoch provided by the client is larger than the current epoch known to the broker, then the UNKNOWN_LEADER_EPOCH error code will be returned. If the provided epoch is smaller, then the FENCED_LEADER_EPOCH error code will be returned.
				/// </summary>
				private Int32 _currentLeaderEpoch = new Int32(-1);
				public Int32 CurrentLeaderEpoch 
				{
					get => _currentLeaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"CurrentLeaderEpoch is non-nullable.");
						}

						_currentLeaderEpoch = value;
					}
				}

				/// <summary>
				/// The epoch to look up an offset for.
				/// </summary>
				private Int32 _leaderEpoch = Int32.Default;
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}
			}
		}
	}

	public class OffsetForLeaderEpochResponse
	{
		public OffsetForLeaderEpochResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"OffsetForLeaderEpochResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 23;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new OffsetForLeaderTopicResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(2, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// Each topic we fetched offsets for.
		/// </summary>
		private OffsetForLeaderTopicResult[] _topicsCollection = System.Array.Empty<OffsetForLeaderTopicResult>();
		public OffsetForLeaderTopicResult[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public OffsetForLeaderTopicResult CreateOffsetForLeaderTopicResult()
		{
			return new OffsetForLeaderTopicResult(Version);
		}

		public class OffsetForLeaderTopicResult : ISerialize
		{
			internal OffsetForLeaderTopicResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new OffsetForLeaderPartitionResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition in the topic we fetched offsets for.
			/// </summary>
			private OffsetForLeaderPartitionResult[] _partitionsCollection = System.Array.Empty<OffsetForLeaderPartitionResult>();
			public OffsetForLeaderPartitionResult[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public OffsetForLeaderPartitionResult CreateOffsetForLeaderPartitionResult()
			{
				return new OffsetForLeaderPartitionResult(Version);
			}

			public class OffsetForLeaderPartitionResult : ISerialize
			{
				internal OffsetForLeaderPartitionResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						EndOffset = new Int64(reader.ReadInt64());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(EndOffset.Value);
					}
				}

				/// <summary>
				/// The error code 0, or if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The leader epoch of the partition.
				/// </summary>
				private Int32 _leaderEpoch = new Int32(-1);
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}

				/// <summary>
				/// The end offset of the epoch.
				/// </summary>
				private Int64 _endOffset = Int64.Default;
				public Int64 EndOffset 
				{
					get => _endOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"EndOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"EndOffset is non-nullable.");
						}

						_endOffset = value;
					}
				}
			}
		}
	}

	public class ProduceRequest
	{
		public ProduceRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 7)) == false) 
			{
				throw new UnsupportedVersionException($"ProduceRequest does not support version {version}. Valid versions are: 0-7");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 0;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Acks = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TimeoutMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new TopicProduceData(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(3, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(Acks.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(TimeoutMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The transactional ID, or null if the producer is not transactional.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(3, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 3+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// The number of acknowledgments the producer requires the leader to have received before considering a request complete. Allowed values: 0 for no acknowledgments, 1 for only the leader and -1 for the full ISR.
		/// </summary>
		private Int16 _acks = Int16.Default;
		public Int16 Acks 
		{
			get => _acks;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Acks does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Acks is non-nullable.");
				}

				_acks = value;
			}
		}

		/// <summary>
		/// The timeout to await a response in miliseconds.
		/// </summary>
		private Int32 _timeoutMs = Int32.Default;
		public Int32 TimeoutMs 
		{
			get => _timeoutMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TimeoutMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TimeoutMs is non-nullable.");
				}

				_timeoutMs = value;
			}
		}

		/// <summary>
		/// Each topic to produce to.
		/// </summary>
		private TopicProduceData[] _topicsCollection = System.Array.Empty<TopicProduceData>();
		public TopicProduceData[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public TopicProduceData CreateTopicProduceData()
		{
			return new TopicProduceData(Version);
		}

		public class TopicProduceData : ISerialize
		{
			internal TopicProduceData(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new PartitionProduceData(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition to produce to.
			/// </summary>
			private PartitionProduceData[] _partitionsCollection = System.Array.Empty<PartitionProduceData>();
			public PartitionProduceData[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public PartitionProduceData CreatePartitionProduceData()
			{
				return new PartitionProduceData(Version);
			}

			public class PartitionProduceData : ISerialize
			{
				internal PartitionProduceData(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Records = new Bytes(reader.ReadBytes());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteBytes(Records.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The record data to be produced.
				/// </summary>
				private Bytes _records = Bytes.Default;
				public Bytes Records 
				{
					get => _records;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Records does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"Records does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_records = value;
					}
				}
			}
		}
	}

	public class ProduceResponse
	{
		public ProduceResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 7)) == false) 
			{
				throw new UnsupportedVersionException($"ProduceResponse does not support version {version}. Valid versions are: 0-7");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 0;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ResponsesCollection = reader.Read(() => new TopicProduceResponse(Version));
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(ResponsesCollection);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// Each produce response
		/// </summary>
		private TopicProduceResponse[] _responsesCollection = System.Array.Empty<TopicProduceResponse>();
		public TopicProduceResponse[] ResponsesCollection 
		{
			get => _responsesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ResponsesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ResponsesCollection is non-nullable.");
				}

				_responsesCollection = value;
			}
		}

		public TopicProduceResponse CreateTopicProduceResponse()
		{
			return new TopicProduceResponse(Version);
		}

		public class TopicProduceResponse : ISerialize
		{
			internal TopicProduceResponse(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new PartitionProduceResponse(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// Each partition that we produced to within the topic.
			/// </summary>
			private PartitionProduceResponse[] _partitionsCollection = System.Array.Empty<PartitionProduceResponse>();
			public PartitionProduceResponse[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public PartitionProduceResponse CreatePartitionProduceResponse()
			{
				return new PartitionProduceResponse(Version);
			}

			public class PartitionProduceResponse : ISerialize
			{
				internal PartitionProduceResponse(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						BaseOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						LogAppendTimeMs = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						LogStartOffset = new Int64(reader.ReadInt64());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(BaseOffset.Value);
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						writer.WriteInt64(LogAppendTimeMs.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt64(LogStartOffset.Value);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}

				/// <summary>
				/// The base offset.
				/// </summary>
				private Int64 _baseOffset = Int64.Default;
				public Int64 BaseOffset 
				{
					get => _baseOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"BaseOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"BaseOffset is non-nullable.");
						}

						_baseOffset = value;
					}
				}

				/// <summary>
				/// The timestamp returned by broker after appending the messages. If CreateTime is used for the topic, the timestamp will be -1.  If LogAppendTime is used for the topic, the timestamp will be the broker local time when the messages are appended.
				/// </summary>
				private Int64 _logAppendTimeMs = new Int64(-1);
				public Int64 LogAppendTimeMs 
				{
					get => _logAppendTimeMs;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LogAppendTimeMs is non-nullable.");
						}

						_logAppendTimeMs = value;
					}
				}

				/// <summary>
				/// The log start offset.
				/// </summary>
				private Int64 _logStartOffset = new Int64(-1);
				public Int64 LogStartOffset 
				{
					get => _logStartOffset;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"LogStartOffset is non-nullable.");
						}

						_logStartOffset = value;
					}
				}
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class RenewDelegationTokenRequest
	{
		public RenewDelegationTokenRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"RenewDelegationTokenRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 39;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Hmac = new Bytes(reader.ReadBytes());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				RenewPeriodMs = new Int64(reader.ReadInt64());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(Hmac.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(RenewPeriodMs.Value);
			}
		}

		/// <summary>
		/// The HMAC of the delegation token to be renewed.
		/// </summary>
		private Bytes _hmac = Bytes.Default;
		public Bytes Hmac 
		{
			get => _hmac;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Hmac does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Hmac is non-nullable.");
				}

				_hmac = value;
			}
		}

		/// <summary>
		/// The renewal time period in milliseconds.
		/// </summary>
		private Int64 _renewPeriodMs = Int64.Default;
		public Int64 RenewPeriodMs 
		{
			get => _renewPeriodMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"RenewPeriodMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"RenewPeriodMs is non-nullable.");
				}

				_renewPeriodMs = value;
			}
		}
	}

	public class RenewDelegationTokenResponse
	{
		public RenewDelegationTokenResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"RenewDelegationTokenResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 39;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ExpiryTimestampMs = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ExpiryTimestampMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The timestamp in milliseconds at which this token expires.
		/// </summary>
		private Int64 _expiryTimestampMs = Int64.Default;
		public Int64 ExpiryTimestampMs 
		{
			get => _expiryTimestampMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ExpiryTimestampMs is non-nullable.");
				}

				_expiryTimestampMs = value;
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}
	}

	public class RequestHeader
	{
		public RequestHeader(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"RequestHeader does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 0;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				RequestApiKey = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				RequestApiVersion = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				CorrelationId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ClientId = new String(reader.ReadString());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(RequestApiKey.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(RequestApiVersion.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(CorrelationId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ClientId.Value);
			}
		}

		/// <summary>
		/// The API key of this request.
		/// </summary>
		private Int16 _requestApiKey = Int16.Default;
		public Int16 RequestApiKey 
		{
			get => _requestApiKey;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"RequestApiKey does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"RequestApiKey is non-nullable.");
				}

				_requestApiKey = value;
			}
		}

		/// <summary>
		/// The API version of this request.
		/// </summary>
		private Int16 _requestApiVersion = Int16.Default;
		public Int16 RequestApiVersion 
		{
			get => _requestApiVersion;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"RequestApiVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"RequestApiVersion is non-nullable.");
				}

				_requestApiVersion = value;
			}
		}

		/// <summary>
		/// The correlation ID of this request.
		/// </summary>
		private Int32 _correlationId = Int32.Default;
		public Int32 CorrelationId 
		{
			get => _correlationId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"CorrelationId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"CorrelationId is non-nullable.");
				}

				_correlationId = value;
			}
		}

		/// <summary>
		/// The client ID string.
		/// </summary>
		private String _clientId = String.Default;
		public String ClientId 
		{
			get => _clientId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ClientId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ClientId is non-nullable.");
				}

				_clientId = value;
			}
		}
	}

	public class ResponseHeader
	{
		public ResponseHeader(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"ResponseHeader does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 0;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				CorrelationId = new Int32(reader.ReadInt32());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(CorrelationId.Value);
			}
		}

		/// <summary>
		/// The correlation ID of this response.
		/// </summary>
		private Int32 _correlationId = Int32.Default;
		public Int32 CorrelationId 
		{
			get => _correlationId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"CorrelationId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"CorrelationId is non-nullable.");
				}

				_correlationId = value;
			}
		}
	}

	public class SaslAuthenticateRequest
	{
		public SaslAuthenticateRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"SaslAuthenticateRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 36;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				AuthBytes = new Bytes(reader.ReadBytes());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(AuthBytes.Value);
			}
		}

		/// <summary>
		/// The SASL authentication bytes from the client, as defined by the SASL mechanism.
		/// </summary>
		private Bytes _authBytes = Bytes.Default;
		public Bytes AuthBytes 
		{
			get => _authBytes;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"AuthBytes does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"AuthBytes is non-nullable.");
				}

				_authBytes = value;
			}
		}
	}

	public class SaslAuthenticateResponse
	{
		public SaslAuthenticateResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"SaslAuthenticateResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 36;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorMessage = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				AuthBytes = new Bytes(reader.ReadBytes());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				SessionLifetimeMs = new Int64(reader.ReadInt64());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(ErrorMessage.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(AuthBytes.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt64(SessionLifetimeMs.Value);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The error message, or null if there was no error.
		/// </summary>
		private String _errorMessage = String.Default;
		public String ErrorMessage 
		{
			get => _errorMessage;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorMessage does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
					value == null) 
				{
					throw new UnsupportedVersionException($"ErrorMessage does not support null for version {Version}. Supported versions for null value: 0+");
				}

				_errorMessage = value;
			}
		}

		/// <summary>
		/// The SASL authentication bytes from the server, as defined by the SASL mechanism.
		/// </summary>
		private Bytes _authBytes = Bytes.Default;
		public Bytes AuthBytes 
		{
			get => _authBytes;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"AuthBytes does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"AuthBytes is non-nullable.");
				}

				_authBytes = value;
			}
		}

		/// <summary>
		/// The SASL authentication bytes from the server, as defined by the SASL mechanism.
		/// </summary>
		private Int64 _sessionLifetimeMs = new Int64(0);
		public Int64 SessionLifetimeMs 
		{
			get => _sessionLifetimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"SessionLifetimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"SessionLifetimeMs is non-nullable.");
				}

				_sessionLifetimeMs = value;
			}
		}
	}

	public class SaslHandshakeRequest
	{
		public SaslHandshakeRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"SaslHandshakeRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 17;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Mechanism = new String(reader.ReadString());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(Mechanism.Value);
			}
		}

		/// <summary>
		/// The SASL mechanism chosen by the client.
		/// </summary>
		private String _mechanism = String.Default;
		public String Mechanism 
		{
			get => _mechanism;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Mechanism does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Mechanism is non-nullable.");
				}

				_mechanism = value;
			}
		}
	}

	public class SaslHandshakeResponse
	{
		public SaslHandshakeResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"SaslHandshakeResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 17;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MechanismsCollection = reader.Read(() => new String(reader.ReadString()));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(MechanismsCollection);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The mechanisms enabled in the server.
		/// </summary>
		private String[] _mechanismsCollection = System.Array.Empty<String>();
		public String[] MechanismsCollection 
		{
			get => _mechanismsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MechanismsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MechanismsCollection is non-nullable.");
				}

				_mechanismsCollection = value;
			}
		}
	}

	public class StopReplicaRequest
	{
		public StopReplicaRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"StopReplicaRequest does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 5;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerEpoch = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				BrokerEpoch = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				DeletePartitions = new Boolean(reader.ReadBoolean());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PartitionsV0Collection = reader.Read(() => new StopReplicaRequestPartitionV0(Version));
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new StopReplicaRequestTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt64(BrokerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBoolean(DeletePartitions.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(PartitionsV0Collection);
			}
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The controller id.
		/// </summary>
		private Int32 _controllerId = Int32.Default;
		public Int32 ControllerId 
		{
			get => _controllerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerId is non-nullable.");
				}

				_controllerId = value;
			}
		}

		/// <summary>
		/// The controller epoch.
		/// </summary>
		private Int32 _controllerEpoch = Int32.Default;
		public Int32 ControllerEpoch 
		{
			get => _controllerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
				}

				_controllerEpoch = value;
			}
		}

		/// <summary>
		/// The broker epoch.
		/// </summary>
		private Int64 _brokerEpoch = new Int64(-1);
		public Int64 BrokerEpoch 
		{
			get => _brokerEpoch;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokerEpoch is non-nullable.");
				}

				_brokerEpoch = value;
			}
		}

		/// <summary>
		/// Whether these partitions should be deleted.
		/// </summary>
		private Boolean _deletePartitions = Boolean.Default;
		public Boolean DeletePartitions 
		{
			get => _deletePartitions;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"DeletePartitions does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"DeletePartitions is non-nullable.");
				}

				_deletePartitions = value;
			}
		}

		/// <summary>
		/// The partitions to stop.
		/// </summary>
		private StopReplicaRequestPartitionV0[] _partitionsV0Collection = System.Array.Empty<StopReplicaRequestPartitionV0>();
		public StopReplicaRequestPartitionV0[] PartitionsV0Collection 
		{
			get => _partitionsV0Collection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PartitionsV0Collection does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PartitionsV0Collection is non-nullable.");
				}

				_partitionsV0Collection = value;
			}
		}

		public StopReplicaRequestPartitionV0 CreateStopReplicaRequestPartitionV0()
		{
			return new StopReplicaRequestPartitionV0(Version);
		}

		public class StopReplicaRequestPartitionV0 : ISerialize
		{
			internal StopReplicaRequestPartitionV0(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition index.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}
		}

		/// <summary>
		/// The topics to stop.
		/// </summary>
		private StopReplicaRequestTopic[] _topicsCollection = System.Array.Empty<StopReplicaRequestTopic>();
		public StopReplicaRequestTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public StopReplicaRequestTopic CreateStopReplicaRequestTopic()
		{
			return new StopReplicaRequestTopic(Version);
		}

		public class StopReplicaRequestTopic : ISerialize
		{
			internal StopReplicaRequestTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					PartitionIndexesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.Write(PartitionIndexesCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partition indexes.
			/// </summary>
			private Int32[] _partitionIndexesCollection = System.Array.Empty<Int32>();
			public Int32[] PartitionIndexesCollection 
			{
				get => _partitionIndexesCollection;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndexesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndexesCollection is non-nullable.");
					}

					_partitionIndexesCollection = value;
				}
			}
		}
	}

	public class StopReplicaResponse
	{
		public StopReplicaResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 1)) == false) 
			{
				throw new UnsupportedVersionException($"StopReplicaResponse does not support version {version}. Valid versions are: 0-1");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 5;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				PartitionsCollection = reader.Read(() => new StopReplicaResponsePartition(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(PartitionsCollection);
			}
		}

		/// <summary>
		/// The top-level error code, or 0 if there was no top-level error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The responses for each partition.
		/// </summary>
		private StopReplicaResponsePartition[] _partitionsCollection = System.Array.Empty<StopReplicaResponsePartition>();
		public StopReplicaResponsePartition[] PartitionsCollection 
		{
			get => _partitionsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
				}

				_partitionsCollection = value;
			}
		}

		public StopReplicaResponsePartition CreateStopReplicaResponsePartition()
		{
			return new StopReplicaResponsePartition(Version);
		}

		public class StopReplicaResponsePartition : ISerialize
		{
			internal StopReplicaResponsePartition(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ErrorCode = new Int16(reader.ReadInt16());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ErrorCode.Value);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition index.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}

			/// <summary>
			/// The partition error code, or 0 if there was no partition error.
			/// </summary>
			private Int16 _errorCode = Int16.Default;
			public Int16 ErrorCode 
			{
				get => _errorCode;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
					}

					_errorCode = value;
				}
			}
		}
	}

	public class SyncGroupRequest
	{
		public SyncGroupRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"SyncGroupRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 14;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GenerationId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MemberId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				AssignmentsCollection = reader.Read(() => new SyncGroupRequestAssignment(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(GenerationId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(MemberId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(AssignmentsCollection);
			}
		}

		/// <summary>
		/// The unique group identifier.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The generation of the group.
		/// </summary>
		private Int32 _generationId = Int32.Default;
		public Int32 GenerationId 
		{
			get => _generationId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GenerationId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GenerationId is non-nullable.");
				}

				_generationId = value;
			}
		}

		/// <summary>
		/// The member ID assigned by the group.
		/// </summary>
		private String _memberId = String.Default;
		public String MemberId 
		{
			get => _memberId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MemberId is non-nullable.");
				}

				_memberId = value;
			}
		}

		/// <summary>
		/// Each assignment.
		/// </summary>
		private SyncGroupRequestAssignment[] _assignmentsCollection = System.Array.Empty<SyncGroupRequestAssignment>();
		public SyncGroupRequestAssignment[] AssignmentsCollection 
		{
			get => _assignmentsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"AssignmentsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"AssignmentsCollection is non-nullable.");
				}

				_assignmentsCollection = value;
			}
		}

		public SyncGroupRequestAssignment CreateSyncGroupRequestAssignment()
		{
			return new SyncGroupRequestAssignment(Version);
		}

		public class SyncGroupRequestAssignment : ISerialize
		{
			internal SyncGroupRequestAssignment(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					MemberId = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Assignment = new Bytes(reader.ReadBytes());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(MemberId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteBytes(Assignment.Value);
				}
			}

			/// <summary>
			/// The ID of the member to assign.
			/// </summary>
			private String _memberId = String.Default;
			public String MemberId 
			{
				get => _memberId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"MemberId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"MemberId is non-nullable.");
					}

					_memberId = value;
				}
			}

			/// <summary>
			/// The member assignment.
			/// </summary>
			private Bytes _assignment = Bytes.Default;
			public Bytes Assignment 
			{
				get => _assignment;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Assignment does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Assignment is non-nullable.");
					}

					_assignment = value;
				}
			}
		}
	}

	public class SyncGroupResponse
	{
		public SyncGroupResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"SyncGroupResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 14;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				Assignment = new Bytes(reader.ReadBytes());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(1, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteBytes(Assignment.Value);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}

		/// <summary>
		/// The member assignment.
		/// </summary>
		private Bytes _assignment = Bytes.Default;
		public Bytes Assignment 
		{
			get => _assignment;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"Assignment does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"Assignment is non-nullable.");
				}

				_assignment = value;
			}
		}
	}

	public class TxnOffsetCommitRequest
	{
		public TxnOffsetCommitRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"TxnOffsetCommitRequest does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 28;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TransactionalId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				GroupId = new String(reader.ReadString());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerId = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ProducerEpoch = new Int16(reader.ReadInt16());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new TxnOffsetCommitRequestTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(TransactionalId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteString(GroupId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt64(ProducerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ProducerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The ID of the transaction.
		/// </summary>
		private String _transactionalId = String.Default;
		public String TransactionalId 
		{
			get => _transactionalId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TransactionalId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TransactionalId is non-nullable.");
				}

				_transactionalId = value;
			}
		}

		/// <summary>
		/// The ID of the group.
		/// </summary>
		private String _groupId = String.Default;
		public String GroupId 
		{
			get => _groupId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"GroupId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"GroupId is non-nullable.");
				}

				_groupId = value;
			}
		}

		/// <summary>
		/// The current producer ID in use by the transactional ID.
		/// </summary>
		private Int64 _producerId = Int64.Default;
		public Int64 ProducerId 
		{
			get => _producerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerId is non-nullable.");
				}

				_producerId = value;
			}
		}

		/// <summary>
		/// The current epoch associated with the producer ID.
		/// </summary>
		private Int16 _producerEpoch = Int16.Default;
		public Int16 ProducerEpoch 
		{
			get => _producerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
				}

				_producerEpoch = value;
			}
		}

		/// <summary>
		/// Each topic that we want to committ offsets for.
		/// </summary>
		private TxnOffsetCommitRequestTopic[] _topicsCollection = System.Array.Empty<TxnOffsetCommitRequestTopic>();
		public TxnOffsetCommitRequestTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public TxnOffsetCommitRequestTopic CreateTxnOffsetCommitRequestTopic()
		{
			return new TxnOffsetCommitRequestTopic(Version);
		}

		public class TxnOffsetCommitRequestTopic : ISerialize
		{
			internal TxnOffsetCommitRequestTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new TxnOffsetCommitRequestPartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The partitions inside the topic that we want to committ offsets for.
			/// </summary>
			private TxnOffsetCommitRequestPartition[] _partitionsCollection = System.Array.Empty<TxnOffsetCommitRequestPartition>();
			public TxnOffsetCommitRequestPartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public TxnOffsetCommitRequestPartition CreateTxnOffsetCommitRequestPartition()
			{
				return new TxnOffsetCommitRequestPartition(Version);
			}

			public class TxnOffsetCommitRequestPartition : ISerialize
			{
				internal TxnOffsetCommitRequestPartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						CommittedOffset = new Int64(reader.ReadInt64());
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						CommittedLeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						CommittedMetadata = new String(reader.ReadString());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt64(CommittedOffset.Value);
					}
					if (Version.InRange(new VersionRange(2, 2147483647))) 
					{
						writer.WriteInt32(CommittedLeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(CommittedMetadata.Value);
					}
				}

				/// <summary>
				/// The index of the partition within the topic.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The message offset to be committed.
				/// </summary>
				private Int64 _committedOffset = Int64.Default;
				public Int64 CommittedOffset 
				{
					get => _committedOffset;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedOffset does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedOffset is non-nullable.");
						}

						_committedOffset = value;
					}
				}

				/// <summary>
				/// The leader epoch of the last consumed record.
				/// </summary>
				private Int32 _committedLeaderEpoch = new Int32(-1);
				public Int32 CommittedLeaderEpoch 
				{
					get => _committedLeaderEpoch;
					set 
					{
						if (value == null) 
						{
							throw new UnsupportedVersionException($"CommittedLeaderEpoch is non-nullable.");
						}

						_committedLeaderEpoch = value;
					}
				}

				/// <summary>
				/// Any associated metadata the client wants to keep.
				/// </summary>
				private String _committedMetadata = String.Default;
				public String CommittedMetadata 
				{
					get => _committedMetadata;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"CommittedMetadata does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
							value == null) 
						{
							throw new UnsupportedVersionException($"CommittedMetadata does not support null for version {Version}. Supported versions for null value: 0+");
						}

						_committedMetadata = value;
					}
				}
			}
		}
	}

	public class TxnOffsetCommitResponse
	{
		public TxnOffsetCommitResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2)) == false) 
			{
				throw new UnsupportedVersionException($"TxnOffsetCommitResponse does not support version {version}. Valid versions are: 0-2");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 28;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ThrottleTimeMs = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				TopicsCollection = reader.Read(() => new TxnOffsetCommitResponseTopic(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ThrottleTimeMs.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(TopicsCollection);
			}
		}

		/// <summary>
		/// The duration in milliseconds for which the request was throttled due to a quota violation, or zero if the request did not violate any quota.
		/// </summary>
		private Int32 _throttleTimeMs = Int32.Default;
		public Int32 ThrottleTimeMs 
		{
			get => _throttleTimeMs;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ThrottleTimeMs is non-nullable.");
				}

				_throttleTimeMs = value;
			}
		}

		/// <summary>
		/// The responses for each topic.
		/// </summary>
		private TxnOffsetCommitResponseTopic[] _topicsCollection = System.Array.Empty<TxnOffsetCommitResponseTopic>();
		public TxnOffsetCommitResponseTopic[] TopicsCollection 
		{
			get => _topicsCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
				}

				_topicsCollection = value;
			}
		}

		public TxnOffsetCommitResponseTopic CreateTxnOffsetCommitResponseTopic()
		{
			return new TxnOffsetCommitResponseTopic(Version);
		}

		public class TxnOffsetCommitResponseTopic : ISerialize
		{
			internal TxnOffsetCommitResponseTopic(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Name = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					PartitionsCollection = reader.Read(() => new TxnOffsetCommitResponsePartition(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(Name.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(PartitionsCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _name = String.Default;
			public String Name 
			{
				get => _name;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Name is non-nullable.");
					}

					_name = value;
				}
			}

			/// <summary>
			/// The responses for each partition in the topic.
			/// </summary>
			private TxnOffsetCommitResponsePartition[] _partitionsCollection = System.Array.Empty<TxnOffsetCommitResponsePartition>();
			public TxnOffsetCommitResponsePartition[] PartitionsCollection 
			{
				get => _partitionsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
					}

					_partitionsCollection = value;
				}
			}

			public TxnOffsetCommitResponsePartition CreateTxnOffsetCommitResponsePartition()
			{
				return new TxnOffsetCommitResponsePartition(Version);
			}

			public class TxnOffsetCommitResponsePartition : ISerialize
			{
				internal TxnOffsetCommitResponsePartition(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						ErrorCode = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteInt16(ErrorCode.Value);
					}
				}

				/// <summary>
				/// The partitition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The error code, or 0 if there was no error.
				/// </summary>
				private Int16 _errorCode = Int16.Default;
				public Int16 ErrorCode 
				{
					get => _errorCode;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
						}

						_errorCode = value;
					}
				}
			}
		}
	}

	public class UpdateMetadataRequest
	{
		public UpdateMetadataRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"UpdateMetadataRequest does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 6;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerId = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ControllerEpoch = new Int32(reader.ReadInt32());
			}
			if (Version.InRange(new VersionRange(5, 2147483647))) 
			{
				BrokerEpoch = new Int64(reader.ReadInt64());
			}
			if (Version.InRange(new VersionRange(5, 2147483647))) 
			{
				TopicStatesCollection = reader.Read(() => new UpdateMetadataRequestTopicState(Version));
			}
			if (Version.InRange(new VersionRange(0, 4))) 
			{
				PartitionStatesV0Collection = reader.Read(() => new UpdateMetadataRequestPartitionStateV0(Version));
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				BrokersCollection = reader.Read(() => new UpdateMetadataRequestBroker(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerId.Value);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt32(ControllerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(5, 2147483647))) 
			{
				writer.WriteInt64(BrokerEpoch.Value);
			}
			if (Version.InRange(new VersionRange(5, 2147483647))) 
			{
				writer.Write(TopicStatesCollection);
			}
			if (Version.InRange(new VersionRange(0, 4))) 
			{
				writer.Write(PartitionStatesV0Collection);
			}
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(BrokersCollection);
			}
		}

		/// <summary>
		/// The controller id.
		/// </summary>
		private Int32 _controllerId = Int32.Default;
		public Int32 ControllerId 
		{
			get => _controllerId;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerId is non-nullable.");
				}

				_controllerId = value;
			}
		}

		/// <summary>
		/// The controller epoch.
		/// </summary>
		private Int32 _controllerEpoch = Int32.Default;
		public Int32 ControllerEpoch 
		{
			get => _controllerEpoch;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
				}

				_controllerEpoch = value;
			}
		}

		/// <summary>
		/// The broker epoch.
		/// </summary>
		private Int64 _brokerEpoch = new Int64(-1);
		public Int64 BrokerEpoch 
		{
			get => _brokerEpoch;
			set 
			{
				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokerEpoch is non-nullable.");
				}

				_brokerEpoch = value;
			}
		}

		/// <summary>
		/// Each topic that we would like to update.
		/// </summary>
		private UpdateMetadataRequestTopicState[] _topicStatesCollection = System.Array.Empty<UpdateMetadataRequestTopicState>();
		public UpdateMetadataRequestTopicState[] TopicStatesCollection 
		{
			get => _topicStatesCollection;
			set 
			{
				if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"TopicStatesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"TopicStatesCollection is non-nullable.");
				}

				_topicStatesCollection = value;
			}
		}

		public UpdateMetadataRequestTopicState CreateUpdateMetadataRequestTopicState()
		{
			return new UpdateMetadataRequestTopicState(Version);
		}

		public class UpdateMetadataRequestTopicState : ISerialize
		{
			internal UpdateMetadataRequestTopicState(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(5, 2147483647))) 
				{
					PartitionStatesCollection = reader.Read(() => new UpdateMetadataPartitionState(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(5, 2147483647))) 
				{
					writer.Write(PartitionStatesCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition that we would like to update.
			/// </summary>
			private UpdateMetadataPartitionState[] _partitionStatesCollection = System.Array.Empty<UpdateMetadataPartitionState>();
			public UpdateMetadataPartitionState[] PartitionStatesCollection 
			{
				get => _partitionStatesCollection;
				set 
				{
					if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionStatesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionStatesCollection is non-nullable.");
					}

					_partitionStatesCollection = value;
				}
			}

			public UpdateMetadataPartitionState CreateUpdateMetadataPartitionState()
			{
				return new UpdateMetadataPartitionState(Version);
			}

			public class UpdateMetadataPartitionState : ISerialize
			{
				internal UpdateMetadataPartitionState(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						PartitionIndex = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						ControllerEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						Leader = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						LeaderEpoch = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						IsrCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						ZkVersion = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						ReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						OfflineReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(PartitionIndex.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(ControllerEpoch.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(Leader.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(LeaderEpoch.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.Write(IsrCollection);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.WriteInt32(ZkVersion.Value);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.Write(ReplicasCollection);
					}
					if (Version.InRange(new VersionRange(5, 2147483647))) 
					{
						writer.Write(OfflineReplicasCollection);
					}
				}

				/// <summary>
				/// The partition index.
				/// </summary>
				private Int32 _partitionIndex = Int32.Default;
				public Int32 PartitionIndex 
				{
					get => _partitionIndex;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
						}

						_partitionIndex = value;
					}
				}

				/// <summary>
				/// The controller epoch.
				/// </summary>
				private Int32 _controllerEpoch = Int32.Default;
				public Int32 ControllerEpoch 
				{
					get => _controllerEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
						}

						_controllerEpoch = value;
					}
				}

				/// <summary>
				/// The ID of the broker which is the current partition leader.
				/// </summary>
				private Int32 _leader = Int32.Default;
				public Int32 Leader 
				{
					get => _leader;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Leader does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Leader is non-nullable.");
						}

						_leader = value;
					}
				}

				/// <summary>
				/// The leader epoch of this partition.
				/// </summary>
				private Int32 _leaderEpoch = Int32.Default;
				public Int32 LeaderEpoch 
				{
					get => _leaderEpoch;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
						}

						_leaderEpoch = value;
					}
				}

				/// <summary>
				/// The brokers which are in the ISR for this partition.
				/// </summary>
				private Int32[] _isrCollection = System.Array.Empty<Int32>();
				public Int32[] IsrCollection 
				{
					get => _isrCollection;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"IsrCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"IsrCollection is non-nullable.");
						}

						_isrCollection = value;
					}
				}

				/// <summary>
				/// The Zookeeper version.
				/// </summary>
				private Int32 _zkVersion = Int32.Default;
				public Int32 ZkVersion 
				{
					get => _zkVersion;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ZkVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ZkVersion is non-nullable.");
						}

						_zkVersion = value;
					}
				}

				/// <summary>
				/// All the replicas of this partition.
				/// </summary>
				private Int32[] _replicasCollection = System.Array.Empty<Int32>();
				public Int32[] ReplicasCollection 
				{
					get => _replicasCollection;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"ReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"ReplicasCollection is non-nullable.");
						}

						_replicasCollection = value;
					}
				}

				/// <summary>
				/// The replicas of this partition which are offline.
				/// </summary>
				private Int32[] _offlineReplicasCollection = System.Array.Empty<Int32>();
				public Int32[] OfflineReplicasCollection 
				{
					get => _offlineReplicasCollection;
					set 
					{
						if (Version.InRange(new VersionRange(5, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"OfflineReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 5+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"OfflineReplicasCollection is non-nullable.");
						}

						_offlineReplicasCollection = value;
					}
				}
			}
		}

		/// <summary>
		/// Each partition that we would like to update.
		/// </summary>
		private UpdateMetadataRequestPartitionStateV0[] _partitionStatesV0Collection = System.Array.Empty<UpdateMetadataRequestPartitionStateV0>();
		public UpdateMetadataRequestPartitionStateV0[] PartitionStatesV0Collection 
		{
			get => _partitionStatesV0Collection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 4)) == false) 
				{
					throw new UnsupportedVersionException($"PartitionStatesV0Collection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"PartitionStatesV0Collection is non-nullable.");
				}

				_partitionStatesV0Collection = value;
			}
		}

		public UpdateMetadataRequestPartitionStateV0 CreateUpdateMetadataRequestPartitionStateV0()
		{
			return new UpdateMetadataRequestPartitionStateV0(Version);
		}

		public class UpdateMetadataRequestPartitionStateV0 : ISerialize
		{
			internal UpdateMetadataRequestPartitionStateV0(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					TopicName = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					PartitionIndex = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					ControllerEpoch = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					Leader = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					LeaderEpoch = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					IsrCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					ZkVersion = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					ReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
				if (Version.InRange(new VersionRange(4, 2147483647))) 
				{
					OfflineReplicasCollection = reader.Read(() => new Int32(reader.ReadInt32()));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteString(TopicName.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteInt32(PartitionIndex.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteInt32(ControllerEpoch.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteInt32(Leader.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteInt32(LeaderEpoch.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.Write(IsrCollection);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.WriteInt32(ZkVersion.Value);
				}
				if (Version.InRange(new VersionRange(0, 4))) 
				{
					writer.Write(ReplicasCollection);
				}
				if (Version.InRange(new VersionRange(4, 2147483647))) 
				{
					writer.Write(OfflineReplicasCollection);
				}
			}

			/// <summary>
			/// The topic name.
			/// </summary>
			private String _topicName = String.Default;
			public String TopicName 
			{
				get => _topicName;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"TopicName does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicName is non-nullable.");
					}

					_topicName = value;
				}
			}

			/// <summary>
			/// The partition index.
			/// </summary>
			private Int32 _partitionIndex = Int32.Default;
			public Int32 PartitionIndex 
			{
				get => _partitionIndex;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
					}

					_partitionIndex = value;
				}
			}

			/// <summary>
			/// The controller epoch.
			/// </summary>
			private Int32 _controllerEpoch = Int32.Default;
			public Int32 ControllerEpoch 
			{
				get => _controllerEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"ControllerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ControllerEpoch is non-nullable.");
					}

					_controllerEpoch = value;
				}
			}

			/// <summary>
			/// The ID of the broker which is the current partition leader.
			/// </summary>
			private Int32 _leader = Int32.Default;
			public Int32 Leader 
			{
				get => _leader;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"Leader does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Leader is non-nullable.");
					}

					_leader = value;
				}
			}

			/// <summary>
			/// The leader epoch of this partition.
			/// </summary>
			private Int32 _leaderEpoch = Int32.Default;
			public Int32 LeaderEpoch 
			{
				get => _leaderEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"LeaderEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"LeaderEpoch is non-nullable.");
					}

					_leaderEpoch = value;
				}
			}

			/// <summary>
			/// The brokers which are in the ISR for this partition.
			/// </summary>
			private Int32[] _isrCollection = System.Array.Empty<Int32>();
			public Int32[] IsrCollection 
			{
				get => _isrCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"IsrCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"IsrCollection is non-nullable.");
					}

					_isrCollection = value;
				}
			}

			/// <summary>
			/// The Zookeeper version.
			/// </summary>
			private Int32 _zkVersion = Int32.Default;
			public Int32 ZkVersion 
			{
				get => _zkVersion;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"ZkVersion does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ZkVersion is non-nullable.");
					}

					_zkVersion = value;
				}
			}

			/// <summary>
			/// All the replicas of this partition.
			/// </summary>
			private Int32[] _replicasCollection = System.Array.Empty<Int32>();
			public Int32[] ReplicasCollection 
			{
				get => _replicasCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 4)) == false) 
					{
						throw new UnsupportedVersionException($"ReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0-4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ReplicasCollection is non-nullable.");
					}

					_replicasCollection = value;
				}
			}

			/// <summary>
			/// The replicas of this partition which are offline.
			/// </summary>
			private Int32[] _offlineReplicasCollection = System.Array.Empty<Int32>();
			public Int32[] OfflineReplicasCollection 
			{
				get => _offlineReplicasCollection;
				set 
				{
					if (Version.InRange(new VersionRange(4, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"OfflineReplicasCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 4");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"OfflineReplicasCollection is non-nullable.");
					}

					_offlineReplicasCollection = value;
				}
			}
		}

		private UpdateMetadataRequestBroker[] _brokersCollection = System.Array.Empty<UpdateMetadataRequestBroker>();
		public UpdateMetadataRequestBroker[] BrokersCollection 
		{
			get => _brokersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"BrokersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"BrokersCollection is non-nullable.");
				}

				_brokersCollection = value;
			}
		}

		public UpdateMetadataRequestBroker CreateUpdateMetadataRequestBroker()
		{
			return new UpdateMetadataRequestBroker(Version);
		}

		public class UpdateMetadataRequestBroker : ISerialize
		{
			internal UpdateMetadataRequestBroker(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					Id = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					V0Host = new String(reader.ReadString());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					V0Port = new Int32(reader.ReadInt32());
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					EndpointsCollection = reader.Read(() => new UpdateMetadataRequestEndpoint(Version));
				}
				if (Version.InRange(new VersionRange(2, 2147483647))) 
				{
					Rack = new String(reader.ReadString());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(Id.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteString(V0Host.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(V0Port.Value);
				}
				if (Version.InRange(new VersionRange(1, 2147483647))) 
				{
					writer.Write(EndpointsCollection);
				}
				if (Version.InRange(new VersionRange(2, 2147483647))) 
				{
					writer.WriteString(Rack.Value);
				}
			}

			private Int32 _id = Int32.Default;
			public Int32 Id 
			{
				get => _id;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"Id does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"Id is non-nullable.");
					}

					_id = value;
				}
			}

			/// <summary>
			/// The broker hostname.
			/// </summary>
			private String _v0Host = String.Default;
			public String V0Host 
			{
				get => _v0Host;
				set 
				{
					if (value == null) 
					{
						throw new UnsupportedVersionException($"V0Host is non-nullable.");
					}

					_v0Host = value;
				}
			}

			/// <summary>
			/// The broker port.
			/// </summary>
			private Int32 _v0Port = Int32.Default;
			public Int32 V0Port 
			{
				get => _v0Port;
				set 
				{
					if (value == null) 
					{
						throw new UnsupportedVersionException($"V0Port is non-nullable.");
					}

					_v0Port = value;
				}
			}

			/// <summary>
			/// The broker endpoints.
			/// </summary>
			private UpdateMetadataRequestEndpoint[] _endpointsCollection = System.Array.Empty<UpdateMetadataRequestEndpoint>();
			public UpdateMetadataRequestEndpoint[] EndpointsCollection 
			{
				get => _endpointsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"EndpointsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"EndpointsCollection is non-nullable.");
					}

					_endpointsCollection = value;
				}
			}

			public UpdateMetadataRequestEndpoint CreateUpdateMetadataRequestEndpoint()
			{
				return new UpdateMetadataRequestEndpoint(Version);
			}

			public class UpdateMetadataRequestEndpoint : ISerialize
			{
				internal UpdateMetadataRequestEndpoint(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						Port = new Int32(reader.ReadInt32());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						Host = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(3, 2147483647))) 
					{
						Listener = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						SecurityProtocol = new Int16(reader.ReadInt16());
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt32(Port.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteString(Host.Value);
					}
					if (Version.InRange(new VersionRange(3, 2147483647))) 
					{
						writer.WriteString(Listener.Value);
					}
					if (Version.InRange(new VersionRange(1, 2147483647))) 
					{
						writer.WriteInt16(SecurityProtocol.Value);
					}
				}

				/// <summary>
				/// The port of this endpoint
				/// </summary>
				private Int32 _port = Int32.Default;
				public Int32 Port 
				{
					get => _port;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Port does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Port is non-nullable.");
						}

						_port = value;
					}
				}

				/// <summary>
				/// The hostname of this endpoint
				/// </summary>
				private String _host = String.Default;
				public String Host 
				{
					get => _host;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Host does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Host is non-nullable.");
						}

						_host = value;
					}
				}

				/// <summary>
				/// The listener name.
				/// </summary>
				private String _listener = String.Default;
				public String Listener 
				{
					get => _listener;
					set 
					{
						if (Version.InRange(new VersionRange(3, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Listener does not support version {Version} and has been defined as not ignorable. Supported versions: 3+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Listener is non-nullable.");
						}

						_listener = value;
					}
				}

				/// <summary>
				/// The security protocol type.
				/// </summary>
				private Int16 _securityProtocol = Int16.Default;
				public Int16 SecurityProtocol 
				{
					get => _securityProtocol;
					set 
					{
						if (Version.InRange(new VersionRange(1, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"SecurityProtocol does not support version {Version} and has been defined as not ignorable. Supported versions: 1+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"SecurityProtocol is non-nullable.");
						}

						_securityProtocol = value;
					}
				}
			}

			/// <summary>
			/// The rack which this broker belongs to.
			/// </summary>
			private String _rack = String.Default;
			public String Rack 
			{
				get => _rack;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false &&
						value == null) 
					{
						throw new UnsupportedVersionException($"Rack does not support null for version {Version}. Supported versions for null value: 0+");
					}

					_rack = value;
				}
			}
		}
	}

	public class UpdateMetadataResponse
	{
		public UpdateMetadataResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 5)) == false) 
			{
				throw new UnsupportedVersionException($"UpdateMetadataResponse does not support version {version}. Valid versions are: 0-5");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 6;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				ErrorCode = new Int16(reader.ReadInt16());
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.WriteInt16(ErrorCode.Value);
			}
		}

		/// <summary>
		/// The error code, or 0 if there was no error.
		/// </summary>
		private Int16 _errorCode = Int16.Default;
		public Int16 ErrorCode 
		{
			get => _errorCode;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
				}

				_errorCode = value;
			}
		}
	}

	public class WriteTxnMarkersRequest
	{
		public WriteTxnMarkersRequest(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"WriteTxnMarkersRequest does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 27;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MarkersCollection = reader.Read(() => new WritableTxnMarker(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(MarkersCollection);
			}
		}

		/// <summary>
		/// The transaction markers to be written.
		/// </summary>
		private WritableTxnMarker[] _markersCollection = System.Array.Empty<WritableTxnMarker>();
		public WritableTxnMarker[] MarkersCollection 
		{
			get => _markersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MarkersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MarkersCollection is non-nullable.");
				}

				_markersCollection = value;
			}
		}

		public WritableTxnMarker CreateWritableTxnMarker()
		{
			return new WritableTxnMarker(Version);
		}

		public class WritableTxnMarker : ISerialize
		{
			internal WritableTxnMarker(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProducerId = new Int64(reader.ReadInt64());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProducerEpoch = new Int16(reader.ReadInt16());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TransactionResult = new Boolean(reader.ReadBoolean());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicsCollection = reader.Read(() => new WritableTxnMarkerTopic(Version));
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					CoordinatorEpoch = new Int32(reader.ReadInt32());
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt64(ProducerId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt16(ProducerEpoch.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteBoolean(TransactionResult.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(TopicsCollection);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt32(CoordinatorEpoch.Value);
				}
			}

			/// <summary>
			/// The current producer ID.
			/// </summary>
			private Int64 _producerId = Int64.Default;
			public Int64 ProducerId 
			{
				get => _producerId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProducerId is non-nullable.");
					}

					_producerId = value;
				}
			}

			/// <summary>
			/// The current epoch associated with the producer ID.
			/// </summary>
			private Int16 _producerEpoch = Int16.Default;
			public Int16 ProducerEpoch 
			{
				get => _producerEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProducerEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProducerEpoch is non-nullable.");
					}

					_producerEpoch = value;
				}
			}

			/// <summary>
			/// The result of the transaction to write to the partitions (false = ABORT, true = COMMIT).
			/// </summary>
			private Boolean _transactionResult = Boolean.Default;
			public Boolean TransactionResult 
			{
				get => _transactionResult;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TransactionResult does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TransactionResult is non-nullable.");
					}

					_transactionResult = value;
				}
			}

			/// <summary>
			/// Each topic that we want to write transaction marker(s) for.
			/// </summary>
			private WritableTxnMarkerTopic[] _topicsCollection = System.Array.Empty<WritableTxnMarkerTopic>();
			public WritableTxnMarkerTopic[] TopicsCollection 
			{
				get => _topicsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
					}

					_topicsCollection = value;
				}
			}

			public WritableTxnMarkerTopic CreateWritableTxnMarkerTopic()
			{
				return new WritableTxnMarkerTopic(Version);
			}

			public class WritableTxnMarkerTopic : ISerialize
			{
				internal WritableTxnMarkerTopic(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionIndexesCollection = reader.Read(() => new Int32(reader.ReadInt32()));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(PartitionIndexesCollection);
					}
				}

				/// <summary>
				/// The topic name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The indexes of the partitions to write transaction markers for.
				/// </summary>
				private Int32[] _partitionIndexesCollection = System.Array.Empty<Int32>();
				public Int32[] PartitionIndexesCollection 
				{
					get => _partitionIndexesCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionIndexesCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionIndexesCollection is non-nullable.");
						}

						_partitionIndexesCollection = value;
					}
				}
			}

			/// <summary>
			/// Epoch associated with the transaction state partition hosted by this transaction coordinator
			/// </summary>
			private Int32 _coordinatorEpoch = Int32.Default;
			public Int32 CoordinatorEpoch 
			{
				get => _coordinatorEpoch;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"CoordinatorEpoch does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"CoordinatorEpoch is non-nullable.");
					}

					_coordinatorEpoch = value;
				}
			}
		}
	}

	public class WriteTxnMarkersResponse
	{
		public WriteTxnMarkersResponse(int version)
		{
			if (version.InRange(new VersionRange(0, 2147483647)) == false) 
			{
				throw new UnsupportedVersionException($"WriteTxnMarkersResponse does not support version {version}. Valid versions are: 0");
			}

			Version = version;
		}

		public int Version { get; }

		public int ApiKey => 27;

		public void ReadFrom(IKafkaReader reader)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				MarkersCollection = reader.Read(() => new WritableTxnMarkerResult(Version));
			}
		}

		public void WriteTo(IKafkaWriter writer)
		{
			if (Version.InRange(new VersionRange(0, 2147483647))) 
			{
				writer.Write(MarkersCollection);
			}
		}

		/// <summary>
		/// The results for writing makers.
		/// </summary>
		private WritableTxnMarkerResult[] _markersCollection = System.Array.Empty<WritableTxnMarkerResult>();
		public WritableTxnMarkerResult[] MarkersCollection 
		{
			get => _markersCollection;
			set 
			{
				if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
				{
					throw new UnsupportedVersionException($"MarkersCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
				}

				if (value == null) 
				{
					throw new UnsupportedVersionException($"MarkersCollection is non-nullable.");
				}

				_markersCollection = value;
			}
		}

		public WritableTxnMarkerResult CreateWritableTxnMarkerResult()
		{
			return new WritableTxnMarkerResult(Version);
		}

		public class WritableTxnMarkerResult : ISerialize
		{
			internal WritableTxnMarkerResult(int version)
			{
				Version = version;
			}

			internal int Version { get; }

			public void ReadFrom(IKafkaReader reader)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					ProducerId = new Int64(reader.ReadInt64());
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					TopicsCollection = reader.Read(() => new WritableTxnMarkerTopicResult(Version));
				}
			}

			public void WriteTo(IKafkaWriter writer)
			{
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.WriteInt64(ProducerId.Value);
				}
				if (Version.InRange(new VersionRange(0, 2147483647))) 
				{
					writer.Write(TopicsCollection);
				}
			}

			/// <summary>
			/// The current producer ID in use by the transactional ID.
			/// </summary>
			private Int64 _producerId = Int64.Default;
			public Int64 ProducerId 
			{
				get => _producerId;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"ProducerId does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"ProducerId is non-nullable.");
					}

					_producerId = value;
				}
			}

			/// <summary>
			/// The results by topic.
			/// </summary>
			private WritableTxnMarkerTopicResult[] _topicsCollection = System.Array.Empty<WritableTxnMarkerTopicResult>();
			public WritableTxnMarkerTopicResult[] TopicsCollection 
			{
				get => _topicsCollection;
				set 
				{
					if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
					{
						throw new UnsupportedVersionException($"TopicsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
					}

					if (value == null) 
					{
						throw new UnsupportedVersionException($"TopicsCollection is non-nullable.");
					}

					_topicsCollection = value;
				}
			}

			public WritableTxnMarkerTopicResult CreateWritableTxnMarkerTopicResult()
			{
				return new WritableTxnMarkerTopicResult(Version);
			}

			public class WritableTxnMarkerTopicResult : ISerialize
			{
				internal WritableTxnMarkerTopicResult(int version)
				{
					Version = version;
				}

				internal int Version { get; }

				public void ReadFrom(IKafkaReader reader)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						Name = new String(reader.ReadString());
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						PartitionsCollection = reader.Read(() => new WritableTxnMarkerPartitionResult(Version));
					}
				}

				public void WriteTo(IKafkaWriter writer)
				{
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.WriteString(Name.Value);
					}
					if (Version.InRange(new VersionRange(0, 2147483647))) 
					{
						writer.Write(PartitionsCollection);
					}
				}

				/// <summary>
				/// The topic name.
				/// </summary>
				private String _name = String.Default;
				public String Name 
				{
					get => _name;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"Name does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"Name is non-nullable.");
						}

						_name = value;
					}
				}

				/// <summary>
				/// The results by partition.
				/// </summary>
				private WritableTxnMarkerPartitionResult[] _partitionsCollection = System.Array.Empty<WritableTxnMarkerPartitionResult>();
				public WritableTxnMarkerPartitionResult[] PartitionsCollection 
				{
					get => _partitionsCollection;
					set 
					{
						if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
						}

						if (value == null) 
						{
							throw new UnsupportedVersionException($"PartitionsCollection is non-nullable.");
						}

						_partitionsCollection = value;
					}
				}

				public WritableTxnMarkerPartitionResult CreateWritableTxnMarkerPartitionResult()
				{
					return new WritableTxnMarkerPartitionResult(Version);
				}

				public class WritableTxnMarkerPartitionResult : ISerialize
				{
					internal WritableTxnMarkerPartitionResult(int version)
					{
						Version = version;
					}

					internal int Version { get; }

					public void ReadFrom(IKafkaReader reader)
					{
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							PartitionIndex = new Int32(reader.ReadInt32());
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							ErrorCode = new Int16(reader.ReadInt16());
						}
					}

					public void WriteTo(IKafkaWriter writer)
					{
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteInt32(PartitionIndex.Value);
						}
						if (Version.InRange(new VersionRange(0, 2147483647))) 
						{
							writer.WriteInt16(ErrorCode.Value);
						}
					}

					/// <summary>
					/// The partition index.
					/// </summary>
					private Int32 _partitionIndex = Int32.Default;
					public Int32 PartitionIndex 
					{
						get => _partitionIndex;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"PartitionIndex does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"PartitionIndex is non-nullable.");
							}

							_partitionIndex = value;
						}
					}

					/// <summary>
					/// The error code, or 0 if there was no error.
					/// </summary>
					private Int16 _errorCode = Int16.Default;
					public Int16 ErrorCode 
					{
						get => _errorCode;
						set 
						{
							if (Version.InRange(new VersionRange(0, 2147483647)) == false) 
							{
								throw new UnsupportedVersionException($"ErrorCode does not support version {Version} and has been defined as not ignorable. Supported versions: 0+");
							}

							if (value == null) 
							{
								throw new UnsupportedVersionException($"ErrorCode is non-nullable.");
							}

							_errorCode = value;
						}
					}
				}
			}
		}
	}

}