using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Kafka.Protocol
{
    internal static class StreamExtensions
    {
        internal static ValueTask WriteAsLittleEndianAsync(this Stream buffer, byte[] value, CancellationToken cancellationToken = default)
        {
            if (BitConverter.IsLittleEndian == false)
            {
                Array.Reverse(value);
            }

            return WriteAsync(buffer, value, cancellationToken);
        }

        internal static ValueTask WriteAsBigEndianAsync(this Stream buffer, byte[] value, CancellationToken cancellationToken = default)
        {
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(value);
            }

            return WriteAsync(buffer, value, cancellationToken);
        }

        private static ValueTask WriteAsync(this Stream buffer, byte[] value, CancellationToken cancellationToken = default)
        {
            if (value.Any() == false)
            {
                return default;
            }

            return buffer.WriteAsync(value.AsMemory(), cancellationToken);
        }
        
        public static int ReadInt32(this Stream s)
        {
            if (s.Position + 4 > s.Length)
                throw new Exception(string.Format("ReadInt32 needs 4 bytes but got only {0}", s.Length - s.Position));
            return s.ReadByte() << 3*8 | s.ReadByte() << 2*8 | s.ReadByte() << 8 | s.ReadByte();
        }

        public static short ReadInt16(this Stream s)
        {
            if (s.Position + 2 > s.Length)
                throw new Exception(string.Format("ReadInt16 needs 2 bytes but got only {0}", s.Length - s.Position));
            return (short) ((s.ReadByte() << 8) | s.ReadByte());
        }

        public static long ReadInt64(this Stream stream)
        {
            if (stream.Position + 8 > stream.Length)
                throw new Exception(string.Format("ReadInt64 needs 8 bytes but got only {0}",
                    stream.Length - stream.Position));

            var res = 0L;
            for (int i = 0; i < 8; i++)
                res = res << 8 | (uint) stream.ReadByte();
            return res;
        }
        
        public static long ReadAsVarInt64(this Stream stream)
        {
            var more = true;
            ulong value = 0;
            var shift = 0;
            while (more)
            {
                var lowerBits = stream.ReadByte();
                if (lowerBits < 0)
                {
                    break;
                }

                more = (lowerBits & 128) != 0;
                value |= (uint)((lowerBits & 0x7f) << shift);
                shift += 7;
            }

            return value.DecodeFromZigZag();
        }

        public static int ReadAsVarInt32(this Stream stream)
        {
            return (int)stream.ReadAsVarInt64();
        }

        public static byte[] ReadBytes(this Stream stream, int size)
        {
            var bytes = new byte[size];

            var read = stream.Read(bytes);
            if (read != size)
            {
                throw new EndOfStreamException();
            }

            return bytes;
        }
    }
}