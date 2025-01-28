// Caitlin Sheeran
// 1/28/2025
// Foreach Looop Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ForEachLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // foreach loop = a simpler way to iterate over an array, but it's less flexible

            string[] cars = {"BMW", "Mustang", "Corvette"};


            foreach (string car in cars) // for each(variable) in array cars
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
