// Caitlin Sheeran
// 1/28/2025
// Multithreading Practice
// https://www.youtube.com/watch?v=wxznTygnRfQ&ab_channel=BroCode

using System;
using System.Threading;

namespace MultiThreadingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // thread = an execution path of a program
            //          We can use multiple thread to perform.
            //          different tasks of our program at the same time
            //          Current threads running is "main" thread
            //          using System.Threading;


            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(CountDown);
            Thread thread2 = new Thread(CountUp);
            thread1.Start();
            thread2.Start();
            


            CountDown();
            CountUp();

            Console.WriteLine(mainThread.Name + " is Complete!");


            Console.ReadKey();
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000); // 1000 is 1 second
            }
            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10 ; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000); // 1000 is 1 second
            }
            Console.WriteLine("Timer #2is complete!");
        }
    }

}
