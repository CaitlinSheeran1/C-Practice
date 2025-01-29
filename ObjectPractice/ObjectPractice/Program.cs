// Caitlin Sheeran
// 1/28/2025
// Object Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ObjectPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields and methods (characteristics and actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();

            human2.name = "Morty";
            human2.age = 16;

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    public class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}
