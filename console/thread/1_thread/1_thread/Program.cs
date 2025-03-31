using System;
using System.Threading;

namespace _1_thread
{
    public class Program
    {
        public static void printOddNumbers()
        {
            Console.WriteLine("OddThread Start");
            for (int i = 0; i <1000; i++)
            {
                if (i % 2 != 0) { Console.WriteLine(" ODD " + i); }
            }
            Console.WriteLine("OddThread End");
        }
        public static void printEvenNumbers() 
        {
            Console.WriteLine("EvenThread Start");
            for (int i = 0; i <1000; i++)
            {
                if (i % 2 == 0) { Console.WriteLine("Even " + i); }
            }
            Console.WriteLine("EvenThread End");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("MainThread Start");
            Thread thread1 = new Thread(new ThreadStart(printOddNumbers));
            Thread thread2 = new Thread(new ThreadStart(printEvenNumbers));
            thread1.Start();
            thread2.Start();

            Console.WriteLine("I am a MainThread and I waiting for other threads to join");
            thread1.Join();
            thread2.Join();
            Console.WriteLine("MainThread End");
            Console.ReadKey();
        }
    }
}
