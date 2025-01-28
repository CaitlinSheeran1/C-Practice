// Caitlin Sheeran
// 1/27/2025
// While Loops Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace WhileLoopPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // while loop = repeats some code while some condition remains true

            string name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);



            Console.ReadKey();
        }
    }
}
