// Caitlin Sheeran
// 1/28/2025
// Exception Handling Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


using System;

namespace ExceptionHandlingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during execution
            //     try      = try some code that is considered "dangerous"
            //     catch    = catches and handles exceptions when they occur
            //     finally  = always executes regardless if exception is caught or not

            try // this will try code that could possibly have an error
            {
                Console.Write("Enter number 1: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                double y = Convert.ToDouble(Console.ReadLine());

                double result = x / y;
                Console.Write($"Result: {result}");
            }
            catch (FormatException e) // this will catch errors
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0!");
            }
            catch (Exception e) // will catch anything, but not good practice since you don't let the user know went wrong
            {
                Console.WriteLine("Something went wrong");
            }
            finally // exceutes no matter if the code ran fine or ran into an error
            {
                Console.WriteLine("Thanks for visting");
            }


            


            Console.ReadKey();
        }
    }
}
