using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 1;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResult()
        {
            int number1 = 5;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("subtract", number1, number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubtractsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 5;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("-", number1, number2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResult()
        {
            int number1 = 5;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("multiply", number1, number2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void MultipliesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 5;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("*", number1, number2);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResult()
        {
            int number1 = 10;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("divide", number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void DividesTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            int number1 = 10;
            int number2 = 2;
            double result = _calculatorEngine.Calculate("/", number1, number2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void RaisesNumberToPowerAndReturnsValidResult()
        {
            int number1 = 2;
            int number2 = 3;
            double result = _calculatorEngine.Calculate("power", number1, number2);
            Assert.AreEqual(8, result);
        }

    }
}
