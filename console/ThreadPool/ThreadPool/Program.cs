using System;

namespace ThreadPool
{
    class Program
    {
         public static void Main(string[] args)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(state =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("threadpool task is running");
                }
            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main is running");
            }
            //System.Threading.ThreadPool.SetMinThreads(4, 4);
            //System.Threading.ThreadPool.SetMaxThreads(16, 16);
            Console.ReadKey();
        }
    }
}
