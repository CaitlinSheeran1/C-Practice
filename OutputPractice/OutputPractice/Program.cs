// Caitlin Sheeran
// 1/16/2024
// Output Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace OutputPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!"); //Doesn't make a new line
            Console.WriteLine("Hello, World!"); //Goes on a new line

            /*This is a multi-line comment
             * 
             * Escape Sequences
             * \a Bell
             * \b Backspace
             * \f form feed
             * \n new line
             * \r Carriage return
             * \t Horizontal tab
             * \v Vertical tab
             * \' Single quotation mark
             * \" Double quotation mark
             * \\ Backslash
             * \? Literal question mark
             * 
             */

            Console.WriteLine("\tBro\nCode");

            Console.ReadKey(); //Gets rid of all of the extra words in the console
            
        }
    }
}
