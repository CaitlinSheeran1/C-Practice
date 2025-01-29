// Caitlin Sheeran
// 1/28/2025
// Overloaded Constructors Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace OverloadedConstructorsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Overloaded constructors = technique to create multiple constructors,
            //                           with a different set of parameters.
            //                           name + parameters = signature


            Pizza pizza1 = new Pizza("Stuffed Crust", "Red Sauce", "Mozzarella", "Pepperoni");
            Pizza pizza2 = new Pizza("Stuffed Crust", "Blue Sauce", "Mozzarella");


            Console.ReadKey();
        }
    }

    public class Pizza
    {
        private string bread;
        private string sauce;
        public string cheese;
        public string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese) // If you only have 3 parameters, this one would be used instead of the other one
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
    }
}
