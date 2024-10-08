using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();

        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {
            string inputNumber = "5";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(5, convertedNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertsInvalidStringInputIntoDouble()
        {
            string inputNumber = "*";
            double convertedNumber = _inputConverter.ConvertInputToNumeric(inputNumber);
            Assert.AreEqual(2, convertedNumber);
        }
    }

    public class InputConverter
    {
        public InputConverter()
        {
            
        }

        public double ConvertInputToNumeric(string input)
        {
           
            double result;
            if (double.TryParse(input, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid input");
            }
        }
    }
}
