// Caitlin Sheeran
// 1/28/2025
// String Interpolation Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace StringInterpolationPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders


            string firstName = "Caitlin";
            string lastName = "Sheeran";
            int age = 19;

            Console.WriteLine($"Hello {firstName} {lastName}. You are {age} years old.");


            Console.ReadKey();
        }
    }
}
