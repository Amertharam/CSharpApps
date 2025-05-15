using System;
using System.Threading;

namespace ResourceStarvation
{
    // Example: Starvation due to high-priority threads
    class Program
    {
        static int LPCount;
        static int HPCount;
        static void Main()
        {
            for (int i = 0; i < 1; i++)
            {
                Thread t = new Thread(LowPriorityTask);
                t.Priority = ThreadPriority.Lowest; // Starved threads
                t.Start();
            }

            Thread highPriority = new Thread(HighPriorityTask);
            highPriority.Priority = ThreadPriority.Highest; // Dominates execution
            highPriority.Start();
        }

        static void LowPriorityTask()
        {
            while (true) { Console.WriteLine("LP"); LPCount++;/* Does not get enough CPU time */ }
        }

        static void HighPriorityTask()
        {
            while (true) { Console.WriteLine("HP"); HPCount++;/* Hogging the CPU */ }
        }
    }

}

//In this example, low-priority threads may starve as the high-priority thread consumes most of the CPU time.

//Resolution:
//Use fair scheduling (e.g., Task and TaskScheduler in C# often handle fairness better). Avoid long-running high-priority threads.