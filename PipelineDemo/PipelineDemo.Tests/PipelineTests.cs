using FluentAssertions;
using Xunit;

namespace PipelineDemo.Tests
{
    public class PipelineTests
    {
        [Fact]
        public void TestDemo()
        {
            true.Should().BeTrue();
        }
    }
}