// Caitlin Sheeran
// 1/28/2025
// Abstract Classes Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace AbstractClassesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract classes = modifier that indicates missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); // makes it so people cant pick a vehicle object


            Console.ReadKey();
        }
    }

     abstract public class Vehicle
    {
        private int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

    }
    public class Car : Vehicle // car is child      vehicle is parent
    {
        public int wheels = 4;
        public int maxSpeed = 500;

    }

    public class Bicycle : Vehicle
    {
        public int wheels = 2;
        public int maxSpeed = 50;
    }

    public class Boat : Vehicle
    {
        public int wheels = 0;
        public int maxSpeed = 100;
    }
}




