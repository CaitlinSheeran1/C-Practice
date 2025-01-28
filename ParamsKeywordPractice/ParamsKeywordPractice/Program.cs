// Caitlin Sheeran
// 1/28/2025
// Params Keyword Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


using System.ComponentModel.Design;

namespace ParamsKeywordPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single - dimensional array

            double total = CheckOut(3.88, 5.75, 15.00);

            Console.WriteLine(total);

            Console.ReadKey();
        }
        static double CheckOut(params double[] prices) // puts the values given to the methods into an array
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
