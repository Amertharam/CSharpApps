using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tst
{
    class Program
    {
        public static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(state =>
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
            Console.ReadKey();
        }
    }
}
