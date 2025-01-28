// Caitlin Sheeran
// 1/27/2025
// Random Numbers Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random(); // imports the random module

            int num = random.Next(1, 21); // generates a random whole number

            double num2 = random.NextDouble(); // generates a random decimal number

            Console.WriteLine(num);
            Console.WriteLine(num2);

            Console.ReadKey();



        }
    }
}
