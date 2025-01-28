// Caitlin Sheeran
// 1/28/2025
// Arrays Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // array = a variable that can store multiple values. fixed size

            //string[] cars = { "BMW", "Mustang", "Corette"};
            string[] cars = new string[3];
            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corette";


            cars[0] = "Tesla";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}
