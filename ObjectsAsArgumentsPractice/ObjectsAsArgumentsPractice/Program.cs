// Caitlin Sheeran
// 1/28/2025
// Objects as Arguments Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ObjectsAsArgumentsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "Red");

            ChangeColor(car1, "silver");

            Console.WriteLine(car1.color + " " + car1.model);

            Car car2 = Copy(car1);


            Console.ReadKey();
        }

        public static void ChangeColor(Car car, string color)
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }

    }

    public class Car
    {
        public string model;
        public string color;

        public Car(string model, string color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
