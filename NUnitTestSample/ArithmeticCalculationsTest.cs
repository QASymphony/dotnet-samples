using NUnit.Framework;
using ArithmeticLibrary;

namespace NUnitTestSample.UnitTest
{
    public class ArithmeticCalculationsTest
    {
        private ArithmeticCalculations _arithmetic;

        [SetUp]
        public void Setup()
        {
            _arithmetic = new ArithmeticCalculations();
        }

        [Test]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmetic.Add(5, 4) == 9);
        }

        [Test]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmetic.Subtract(5, 4) == 0);
        }

        [Test]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiply(5, 4) == 20);
        }

        [Test]
        public void FailingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiply(8, 4) == 1);
        }
    }
}
