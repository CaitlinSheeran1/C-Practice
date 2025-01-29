// Caitlin Sheeran
// 1/28/2025
// Polymorphism Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace PolymorphismPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // polymorphism = Greek word that means to "have many forms"
            //                Objects can be identified by more than one type
            //                Ex. A dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }


            Console.ReadKey();
        }
    }
    public class Vehicle
    {
        public virtual void Go()
        {
            
        }
    }
    public class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving");
        }
    }
    public class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving");
        }
    }
    public class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving");
        }
    }
}
