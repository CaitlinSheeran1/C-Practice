// Caitlin Sheeran
// 1/27/2025
// Math Class Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3;
            double y = 5;

            double a = Math.Pow(x, 2); // x^2
            double b = Math.Sqrt(x); // Square root
            double c = Math.Abs(x); // Abouslte value
            double d = Math.Round(x); // Rounding
            double e = Math.Ceiling(x); // Rounds up
            double f = Math.Floor(x); // Rounds down
            double g = Math.Max(x, y); // Finds the highest(max) value
            double h = Math.Min(y, a); // Finds the lowest(min) value


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.ReadKey();
        }

    }
}
