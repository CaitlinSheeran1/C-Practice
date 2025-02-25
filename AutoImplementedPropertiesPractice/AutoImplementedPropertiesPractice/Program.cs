﻿// Caitlin Sheeran
// 1/28/2025
// Auto Implemented Properties Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace AutoImplementedPropertiesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property,
            //                               you only have to write get; and/or set; inside the property


            Car car = new Car("Porsche");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }

    public class Car
    {
        public string model;

        public string Model { get; set; }

        public Car(string model)
        {
            this.model = model;
        }
        
        
    }
}
