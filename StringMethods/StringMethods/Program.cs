// Caitlin Sheeran
// 1/27/2025
// String Methods Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Caitlin Sheeran";
            string phoneNumber = "123-456-7890";

            fullName = fullName.ToUpper(); // Makes string all uppercase
            fullName = fullName.ToLower(); // Makes string all lowercase

            phoneNumber = phoneNumber.Replace('-', '/'); // Will replace - in string to /

            String userName = fullName.Insert(0, "@"); // inserts the @ at index 0

            Console.WriteLine(fullName.Length); // Will print how many characters are in the name

            string firstName = fullName.Substring(0,7); // for a substring, you start at the index you want then how many characters after
            string lastName = fullName.Substring(8,7); // for a substring, you start at the index you want then how many characters after

            Console.WriteLine(fullName);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(userName);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);



            Console.ReadKey();
        }
    }
}
