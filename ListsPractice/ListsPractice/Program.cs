// Caitlin Sheeran
// 1/28/2025
// Lists Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace ListsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

            List<string> food = new List<string>();

            food.Add("pizza"); // adds an item to the list
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");

            food.Remove("fries"); // removes a item from the list
            food.Insert(0,"sushi"); // insert a string at a give index

            Console.WriteLine(food.Count); // tells you how many items are in the list
            Console.WriteLine(food.IndexOf("pizza")); // gives you the index location of the string
            Console.WriteLine(food.LastIndexOf("hotdog")); //finds the last index that the string shows up in
            Console.WriteLine(food.Contains("pizza")); // returns true if its in the list

            food.Reverse(); // reverses the list
            food.Clear(); // clears the list

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine(food[0]);

            Console.ReadKey();
        }
    }
}
