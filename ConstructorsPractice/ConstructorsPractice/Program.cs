// Caitlin Sheeran
// 1/28/2025
// Constructors Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode

namespace ConstructorsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object


            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

          

            human1.Eat();
            human1.Sleep();


            human2.Eat();
            human2.Sleep();


            Car car1 = new Car("Ford", "Mustang", 2022, "Red");

            car1.Drive();

            Car car2 = new Car("Chevy", "Corvette", 1989, "Black");

            car2.Drive();




            Console.ReadKey();
        }
    }
    public class Human
    {
        public string name;
        public int age;

        // CONSTRUCTOR
        public Human(String name, int age)
        {
            this .name = name;
            this .age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }

    public class Car
    {
        public string make;
        public string model;
        public int year;
        public string color;

        public Car(String make, string model, int year, string color)
        {
            this .make = make;
            this .model = model;
            this .year = year;
            this .color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {make} {model}");
        }
    }
}
