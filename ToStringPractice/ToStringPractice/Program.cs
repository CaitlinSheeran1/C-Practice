// Caitlin Sheeran
// 1/28/2025
// ToString() Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


using System.Runtime.InteropServices;

namespace ToStringPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ToString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Shevy", "Corvette", 2022, "blue");

            Console.WriteLine(car.ToString()); 
            Console.WriteLine(car); //this works too


            Console.ReadKey();
        }
    }

    public class Car
    {
        private string make;
        private string model;
        private int year;
        private string color;

        public Car(string make, string model, int year, string color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string ToString()
        {
            return $"This is a {make} {model}";

        }

    }
}
