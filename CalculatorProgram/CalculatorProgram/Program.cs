// Caitlin Sheeran
// 1/28/2025
// Calculator Program
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



using System;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");

                Console.Write("Enter an option: ");

                switch (Console.ReadLine())
                {

                    case "+":
                        Console.ForegroundColor = ConsoleColor.Red;
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = {result}");
                        break;

                    case "-":
                        Console.ForegroundColor = ConsoleColor.Red;
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = {result}");
                        break;

                    case "*":
                        Console.ForegroundColor = ConsoleColor.Red;
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = {result}");
                        break;

                    case "/":
                        Console.ForegroundColor = ConsoleColor.Red;
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = {result}");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That was not a valid option!");
                        break;
                }

                Console.Write("Would you like to continue? (Y/N): ");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");






            Console.ReadKey();
        }
    }
}
