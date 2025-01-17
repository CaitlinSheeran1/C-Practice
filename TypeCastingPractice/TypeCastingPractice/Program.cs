// Caitlin Sheeran
// 1/16/2024
// Type Casting Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode




using System.Dynamic;

namespace TypeCastingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things


            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);


            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);


            Console.WriteLine(b);  
            Console.WriteLine(a.GetType());  //Displays the data type  

            Console.WriteLine(c);
            Console.WriteLine(d.GetType()); //Displays the data type

            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            Console.WriteLine(h);
            Console.WriteLine(h.GetType());

            Console.WriteLine(j);
            Console.WriteLine(j.GetType());







            Console.ReadKey();
        }
    }
}
