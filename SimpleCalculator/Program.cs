using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+ (add), - (subtract), * (multiply), / (divide), ^ (power):");
            string operation = Console.ReadLine().ToLower();

            Console.WriteLine("Enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            CalculatorEngine calculator = new CalculatorEngine();

            double result = 0;

            switch (operation)
            {
                case "+":
                case "add":
                    result = calculator.Calculate(operation, firstNumber, secondNumber);
                    break;
                case "-":
                case "subtract":
                    result = calculator.Calculate(operation, firstNumber, secondNumber);
                    break;
                case "*":
                case "multiply":
                    result = calculator.Calculate(operation, firstNumber, secondNumber);
                    break;
                case "/":
                case "divide":
                    result = calculator.Calculate(operation, firstNumber, secondNumber);
                    break;
                case "power":
                case "pow":
                    result = calculator.Calculate(operation, firstNumber, secondNumber);
                    Console.WriteLine("{0} to the power of {1} is {2}", firstNumber, secondNumber, result);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Console.WriteLine("{0} {1} {2} equals {3}", firstNumber, operation, secondNumber, result);
            Console.ReadLine();
        }
    }
}
