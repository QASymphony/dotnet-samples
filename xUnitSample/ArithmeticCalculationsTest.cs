using System;
using Xunit;
using ArithmeticLibrary;

namespace xUnitSample
{

    public class ArithmeticCalculationsTest : IDisposable
    {
        private readonly ArithmeticCalculations _arithmetic;

        public ArithmeticCalculationsTest()
        {
            _arithmetic = new ArithmeticCalculations();
        }

        [Fact]
        public void PassingAdditionTest()
        {
            Assert.Equal(9, _arithmetic.Add(5, 4));
        }

        [Fact]
        public void FailingSubtractionTest()
        {
            Assert.Equal(0, _arithmetic.Subtract(5, 4));
        }

        [Fact]
        public void PassingMultiplicationTest()
        {
            Assert.Equal(20, _arithmetic.Multiply(5, 4));
        }

        [Fact]
        public void FailingMultiplicationTest()
        {
            Assert.Equal(1, _arithmetic.Divide(8, 4));
        }

        public void Dispose()
        {
        }
    }
}
