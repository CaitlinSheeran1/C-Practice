// Caitlin Sheeran
// 1/28/2025
// Conditional Operator Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace ConditionalOperatorPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // conditional operator = used in conditional assignment if a condition is true/false

            // (condition) ? x : y

            double temperature = 20;
            string message;

            message = (temperature >= 15) ? "It's warm outside!" : "Its cold outside!"; // (if the temp is greater or equal to 15) print Its warm outside :(if not)    its cold outside

            Console.WriteLine(message);
            Console.WriteLine((temperature >= 15) ? "It's warm outside!" : "Its cold outside!"); // this works too



            Console.ReadKey();
        }
    }
}
