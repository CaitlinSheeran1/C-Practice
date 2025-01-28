// Caitlin Sheeran
// 1/28/2025
// Method Overloading Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


using System.Numerics;

namespace MethodOverloadingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Method overloading = methods share same name, but different parameters
            //                      name + parameters = signature
            //                      methods must have a unique signature

            double total = Multiply(2, 3, 4);

            Console.WriteLine(total);


            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
