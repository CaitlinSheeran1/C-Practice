// Caitlin Sheeran
// 1/28/2025
// Array of Objects Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ArrayOfObjectsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Car[] garage = new Car[3];

            //Car car1 = new Car("Mustang");
            //Car car2 = new Car("Corvette");
            //Car car3 = new Car("Lambo");

            //garage[0] = car1;
            //garage[1] = car2;
            //garage[2] = car3;

            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }

    public class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}
