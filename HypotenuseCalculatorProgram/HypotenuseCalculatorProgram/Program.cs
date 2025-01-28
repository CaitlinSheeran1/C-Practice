// Caitlin Sheeran
// 1/27/2025
// Hypotenuse Calculator Program
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace HypotenuseCalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asks user for the first side
            Console.Write("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            //Asks user for the second side
            Console.Write("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //Caluclates the hypotenuse
            double c = Math.Sqrt((a * a) + (b * b));

            //Displays the end result
            Console.WriteLine("The hypotenuse is: " + c);





            Console.ReadKey();

        }
    }
}
