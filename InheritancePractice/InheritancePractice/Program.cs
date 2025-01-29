// Caitlin Sheeran
// 1/28/2025
// Inheritance Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace InheritancePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inheritance = 1 or more child classes recieving fields, methods, etc. from a common parent

            // you can keep anything that all classes share within a parent to make it eaiser, example if you had to change the name of something

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicycle.speed);
            Console.WriteLine(bicycle.wheels);
            bicycle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();


            Console.ReadKey();
        }
    }

    public class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }

    }
    public class Car : Vehicle // car is child      vehicle is parent
    {
        public int wheels = 4;
    }

    public class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    public class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
