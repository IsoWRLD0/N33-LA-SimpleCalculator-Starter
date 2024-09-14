using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            switch (argOperation.ToLower())
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "/":
                case "divide":
                    if (argSecondNumber == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero");
                    }
                    result = argFirstNumber / argSecondNumber;
                    break;
                case "power":
                case "pow":
                    result = Math.Pow(argFirstNumber, argSecondNumber);
                    break;
                default:
                    throw new ArgumentException("Invalid operation");
            }

            return result;
        }
    }
}
