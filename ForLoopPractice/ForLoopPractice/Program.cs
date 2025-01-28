// Caitlin Sheeran
// 1/27/2025
// For loop Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ForLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a FINITE amount of times

            for (int i = 1; i <= 10; i++) //counter/index    conditon/when to stop     how much to go up or go down
            {
                Console.WriteLine(i);
            }

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Happy New Year!");




            Console.ReadKey();
        }
    }
}
