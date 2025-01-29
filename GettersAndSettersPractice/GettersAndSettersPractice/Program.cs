// Caitlin Sheeran
// 1/28/2025
// Getters and Setters Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



using System.ComponentModel.DataAnnotations;

namespace GettersAndSettersPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // getters and setters = add security to fields by encapsulation
            //                       They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accesor = used to return the property value
            // set accesor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000;

            Console.WriteLine(car.Speed);


            Console.ReadKey();
        }
    }
    public class Car
    {
        private int speed = -1;

        public Car(int speed)
        {
            this.speed = speed;
        }

        public int Speed
        {
            get { return this.speed; }
            set
            {
                if (value > 500)
                {
                    this.speed = 500;
                }
                else this.speed = value;
            }
        } 
    }
}
