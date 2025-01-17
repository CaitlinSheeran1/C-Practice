// Caitlin Sheeran
// 1/16/2024
// Variable Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace VariablesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x; //declaration
            x = 123; //initialization

            int y = 321; //combo of both declaration and initialization

            int z = x + y;

            int age = 21; //Whole integer

            double height = 300.5; //Like floats, but called doubles | deciamls

            bool alive = true; //booleans
            char symbol = '@'; //used for symbols (a single one)

            String name = "Caitlin"; //used for strings


            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Your age is " + age); // + to combine strings and ints
            Console.WriteLine(age);
            Console.WriteLine("Your height is " + height + "cms");

            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Youre symbol is " + symbol);
            Console.WriteLine("Hello " + name);

            String userName = symbol + name;
            Console.WriteLine("Your user name is " + userName);    




            Console.ReadKey();
        }
    }
}
