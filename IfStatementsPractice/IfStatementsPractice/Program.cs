// Caitlin Sheeran
// 1/27/2025
// If statements Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace IfStatementsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if statement = a basic form of decision making

            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up!");
            }
            else if (age < 0)
            {
                Console.WriteLine("You haven't been born yet!");
            }
           
            else
            {
                Console.WriteLine("You must be 18 years or older to sign up!");
            }

            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("You did not enter your name!");
            }
            else
            {
                Console.WriteLine("Hello " + name);
            }


            Console.ReadKey();
        }
    }
}
