// Caitlin Sheeran
// 1/28/2025
// Static Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace StaticPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object


            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);
            
            Car.StartRace();

            Console.ReadKey();
        }
    }
    public class Car
    {
     
        public string model;
        public static int numberOfCars; // all share the same variable

        

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }

       
    }
}
