﻿// Caitlin Sheeran
// 1/27/2025
// Switches Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode



namespace SwitchPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("It's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("It's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("It's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("It's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("It's Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
               
            }


            Console.ReadKey();
        }
    }
}
