using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestSample.UnitTest
{
    [TestClass]
    public class ArithmeticTest
    {
        private Arithmetic _arithmetic;

        [TestInitialize]
        public void Initialize()
        {
            _arithmetic = new Arithmetic();
        }

        [TestMethod]
        public void PassingAdditionTest()
        {
            Assert.IsTrue(_arithmetic.Addition(5, 4) == 9);
        }

        [TestMethod]
        public void FailingSubtractionTest()
        {
            Assert.IsTrue(_arithmetic.Subtraction(5, 4) == 0);
        }

        [TestMethod]
        public void PassingMultiplicationTest()
        {
            Assert.IsTrue(_arithmetic.Multiplication(5, 4) == 20);
        }
    }
}
