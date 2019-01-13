using NUnit.Framework;

namespace NUnitTestSample.UnitTest
{
    public class ArithmeticTest
    {
        private Arithmetic _arithmetic;

        [SetUp]
        public void Setup()
        {
            _arithmetic = new Arithmetic();
        }

        [Test]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmetic.Addition(5, 4) == 9);
        }

        [Test]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmetic.Subtraction(5, 4) == 0);
        }

        [Test]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiplication(5, 4) == 20);
        }
    }
}
