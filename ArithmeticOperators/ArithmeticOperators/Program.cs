// Caitlin Sheeran
// 1/27/2025
// Arithmetic Operators Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;
            
            // Some ways to add a variable
            friends =friends + 1;
            friends += 1;
            friends++;

            // Some ways to subtract a variable
            friends = friends - 1;
            friends -= 1;
            friends--;

            // Some ways to multiple a variable
            friends = friends * 2;
            friends *= 2;

            // Some ways to divide a variable
            friends = friends / 2;
            friends /= 2;

            // STo find the remainder to a variable
            int remainder = friends % 3;

            Console.WriteLine(friends);
            Console.WriteLine(remainder);

            Console.ReadKey();
        }


    }
}
