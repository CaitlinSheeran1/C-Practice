// Caitlin Sheeran
// 1/28/2025
// Interfaces Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace InterfacesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface = defines a "contract" that all the classes inheriting from should follow

            //              An interface declares "what a class should have"
            //              An inheriting class defines "how it should do it"

            //              Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();

            rabbit.Flee();

            Hawk hawk = new Hawk();

            hawk.Hunt();

            Fish fish = new Fish();
            fish.Flee();
            fish.Hunt();


            Console.ReadKey();
        }
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }

    public class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The Rabbit runs away");
        }
    }
    public class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for prey");
        }
    }
    public class Fish : IPredator, IPrey
    {
        public void Hunt()
        {
            Console.WriteLine("The fish is searching for prey");
        }
        public void Flee()
        {
            Console.WriteLine("The fish swims away");
        }
    }
}
