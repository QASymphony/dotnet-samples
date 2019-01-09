using System;
using Xunit;

namespace xUnitSample
{
    /// <summary>
    /// https://xunit.github.io/docs/getting-started-dotnet-core
    /// </summary>
    public class UnitTest : IDisposable
    {
        public UnitTest()
        {
        }

        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }


        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }

        private bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        private int Add(int x, int y)
        {
            return x + y;
        }

        public void Dispose()
        {
        }
    }
}
