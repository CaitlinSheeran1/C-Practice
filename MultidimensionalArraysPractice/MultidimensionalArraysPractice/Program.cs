// Caitlin Sheeran
// 1/28/2025
// Multidimensional Arrays Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode


namespace MultidimensionalArraysPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[,] parkingLot = { { "Mustang", "F-150", "Explorer" }, //row 0
                                     { "Corvette", "Camaro", "Silverado" }, //row 1
                                     { "Corolla", "Cmary", "Rav4" }  }; // row 2

            parkingLot[0, 2] = "Fusion"; // grabs car in row 0, index 2
            parkingLot[2, 0] = "Tacoma";


            foreach (var car in parkingLot)
            {
                Console.WriteLine(car);
            }


            for(int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
