using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MakeTeaExample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Before MakeTea_Async()");
            await MakeTea_Async();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " After MakeTea_Async()");
            Console.WriteLine("take cups out");
            Console.WriteLine("put tea powder in cups");
            int a = 0;
            for (int i = 0; i < 100; i++)
            {
                a = a + i;
                Console.Write(Thread.CurrentThread.ManagedThreadId + "_ML. ");
            }
            Console.WriteLine("Main Finished");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
        }
        public async static Task<string> MakeTea_Async() 
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Before BoilWater_Async()");
            var res = await BoilWater_Async();

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " After BoilWater_Async()");
            Console.WriteLine(res + " so pour this hot water in the cups");
            await Task.Delay(5000);

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " 5 sec delay ended");

            return "Tea Ready"; 
        }
        public async static Task<string> BoilWater_Async() 
        {
            Console.WriteLine("water boiling started");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Before Delay()");
            await Task.Delay(2000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " After Delay()");
            Console.WriteLine("water boiling ended");
            return "Hot Water Ready"; 
        }
    }
}
