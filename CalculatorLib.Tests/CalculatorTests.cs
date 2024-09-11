using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLib;

namespace CalculatorLib.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10, y = 20; int expected = 30;
            Calculator calculator = new Calculator();
            int actual = calculator.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            int x = 10, y = 5; int expected = 5;
            Calculator calculator = new Calculator();
            int actual = calculator.Subtract(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumTest()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(calculator.Sum(3, 5), 8);
            Assert.AreEqual(calculator.Sum(-1, 1), 0);
            Assert.AreEqual(calculator.Sum(-1, -1), -2);
        }
        [TestMethod]
        public void SubtractTestMore()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(calculator.Subtract(10, 5), 5);
            Assert.AreEqual(calculator.Subtract(0, 0), 0);
            Assert.AreEqual(calculator.Subtract(-1, -3), 2);
        }
    }
}