// Caitlin Sheeran
// 1/28/2025
// Method Overriding Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace MethodOverridingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            //                     inherited method must be: abstract, virtual, or already overriden
            //                     Used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();



            Console.ReadKey();
        }
    }

    public class Animal
    {
        public virtual void Speak() // virtual means that the class can be overridden
        {
            Console.WriteLine("The animal goes *brrrr*");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *wolf*");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }
    }
}
