using NUnit.Framework;
using ArithmeticLibrary;

namespace NUnitTestSample.UnitTest
{
    public class ArithmeticCalculatorTest
    {
        private ArithmeticCalculator _arithmeticCalculator;

        [SetUp]
        public void Setup()
        {
            _arithmeticCalculator = new ArithmeticCalculator();
        }

        [Test]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Add(5, 4) == 9);
        }

        [Test]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Subtract(5, 4) == 0);
        }

        [Test]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Multiply(5, 4) == 20);
        }

        [Test]
        public void FailingDivisionTest()
        {
            Assert.IsTrue(_arithmeticCalculator.Divide(8, 4) == 1);
        }
    }
}
