﻿using System.IO;
using System.Threading.Tasks;

namespace Kafka.Protocol
{
    public sealed class RequestPayload
    {
        public RequestHeader Header { get; }
        public Message Message { get; }

        private RequestPayload(RequestHeader header, Message message)
        {
            Header = header;
            Message = message;
        }

        internal async Task<byte[]> WriteToAsync()
        {
            await using var stream = new MemoryStream();
            await using (var writer = new KafkaWriter(stream))
            {
                Header.WriteTo(writer);
                Message.WriteTo(writer);
            }

            return stream.GetBuffer();
        }

        public static RequestPayload ReadFrom(int version, byte[] payload)
        {
            var kafkaReader = new KafkaReader(payload);
            var header = new RequestHeader(version);
            header.ReadFrom(kafkaReader);
            var message = Messages.Create(
                header.RequestApiKey.Value,
                header.RequestApiVersion.Value);
            message.ReadFrom(kafkaReader);

            return new RequestPayload(header, message);
        }
    }
}