// Caitlin Sheeran
// 1/28/2025
// Return Keyword Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ReturnKeywordPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // return = returns data back to the place where a method is invoked


            Console.WriteLine("Enter in number 1: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in number 2: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = Multiply(x, y);

            Console.WriteLine(result);




            Console.ReadKey();
        }

        static double Multiply(double x, double y)
        {
          return x * y; ;
        }
    }
}
