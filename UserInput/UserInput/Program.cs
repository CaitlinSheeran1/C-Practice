// Caitlin Sheeran
// 1/27/2025
// User input Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            Console.WriteLine("What's your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");


            Console.ReadKey();
        }
    }
}
