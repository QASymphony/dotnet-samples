using System;
using Xunit;

namespace xUnitSample
{
    public class UnitTest : IDisposable
    {
        public UnitTest()
        {
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


        public void Dispose()
        {
        }
    }
}
