using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArithmeticLibrary;

namespace UnitTestSample
{
    [TestClass]
    public class ArithmeticCalculationsTest
    {
        private ArithmeticCalculations _arithmetic;

        [TestInitialize]
        public void Initialize()
        {
            _arithmetic = new ArithmeticCalculations();
        }

        [TestMethod]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmetic.Add(5, 4) == 9);
        }

        [TestMethod]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmetic.Subtract(5, 4) == 0);
        }

        [TestMethod]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiply(5, 4) == 20);
        }

        [TestMethod]
        public void FailingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiply(8, 4) == 1);
        }
    }
}
