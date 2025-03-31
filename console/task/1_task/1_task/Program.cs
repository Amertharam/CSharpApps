using System;
using System.Threading.Tasks;

namespace _1_task
{
    public class Program
    {
        public static void printOddNums()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("ODD :" + i);
                }
            }
        }
        public static void printEvenNums()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("EVEN:" + i);
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Main start");
            Task.Run(() => { printOddNums(); });
            Task.Run(() => { printEvenNums(); });
            Task.WaitAll();
            Console.WriteLine("Main end");
            Console.ReadKey();
        }
    }
}
