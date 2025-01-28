// Caitlin Sheeran
// 1/28/2025
// Methods Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace MethodsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked"  
            //          benefit = Let's us reuse code without writing it multiple times
            // argument - what is sent to the methods

            string name = "Mark";
            int age = 21;

            singHappyBirthday(name, age);


            Console.ReadKey();
        }

        static void singHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine($"Happy birthday dear {name}!");
            Console.WriteLine($"You are {age}!");
            Console.WriteLine();
        }
    }
}

