// Caitlin Sheeran
// 1/27/2025
// Nested Loops Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace NestedLoopsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested loops = loops inside of other loops
            //                Uses vary. Used a lot in sorting algorithms

            Console.Write("How many rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            Console.Write("What symbol: ");
            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
