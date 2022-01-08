﻿using System.IO;
using System.IO.Pipelines;
using System.Threading.Tasks;
using FluentAssertions;
using Test.It.With.XUnit;
using Xunit;

namespace Kafka.Protocol.Tests.Primitives
{
    public partial class Given_a_nullable_array_of_int32
    {
        public class
            When_writing_null : XUnit2SpecificationAsync
        {
            private readonly byte[] _buffer = new byte[4];
            private readonly NullableArray<Int32> _value = default;
            private MemoryStream _stream = default!;

            protected override Task GivenAsync()
            {
                _stream = new MemoryStream(_buffer);
                return base.GivenAsync();
            }

            protected override async Task WhenAsync()
            {
                await _value.WriteToAsync(_stream)
                    .ConfigureAwait(false);
            }

            [Fact]
            public void It_should_parse_correctly()
            {
                _buffer.Should()
                    .Equal(255, 255, 255, 255);
            }

            [Fact]
            public void It_should_report_correct_size()
            {
                _value.GetSize().Should().Be(4);
            }
        }
        
        public class When_reading : XUnit2SpecificationAsync
        {
            private PipeReader _reader = default!;
            private Int32[]? _value;

            protected override async Task GivenAsync()
            {
                _reader = await new byte[] { 255, 255, 255, 255 }
                    .ToReaderAsync()
                    .ConfigureAwait(false);
            }

            protected override async Task WhenAsync()
            {
                _value = await NullableArray<Int32>.FromReaderAsync(_reader,
                        () => Int32.FromReaderAsync(_reader))
                    .ConfigureAwait(false);
            }

            [Fact]
            public void It_should_parse_correctly()
            {
                _value.Should().BeNull();
            }
        }
    }
}