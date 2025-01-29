// Caitlin Sheeran
// 1/28/2025
// Generics Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace GenericsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //           add <T> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doublesArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "1", "2", "3" };

            displayElements(intArray);

            Console.ReadKey();
        }
    
    public static void displayElements<T>(T[] array)
        {
            foreach (T i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
