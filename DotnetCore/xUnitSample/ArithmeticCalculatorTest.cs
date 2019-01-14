using System;
using Xunit;
using ArithmeticLibrary;

namespace xUnitSample
{
    public class ArithmeticCalculatorTest : IDisposable
    {
        private readonly ArithmeticCalculator _arithmeticCalculator;

        public ArithmeticCalculatorTest()
        {
            _arithmeticCalculator = new ArithmeticCalculator();
        }

        [Fact]
        public void PassingAdditionTest()
        {
            Assert.Equal(9, _arithmeticCalculator.Add(5, 4));
        }

        [Fact]
        public void FailingSubtractionTest()
        {
            Assert.Equal(0, _arithmeticCalculator.Subtract(5, 4));
        }

        [Fact]
        public void PassingMultiplicationTest()
        {
            Assert.Equal(20, _arithmeticCalculator.Multiply(5, 4));
        }

        [Fact]
        public void FailingDivisionTest()
        {
            Assert.Equal(1, _arithmeticCalculator.Divide(8, 4));
        }

        public void Dispose()
        {
        }
    }
}
