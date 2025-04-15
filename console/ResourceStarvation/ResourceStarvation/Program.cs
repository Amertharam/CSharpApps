using System.Threading;

namespace ResourceStarvation
{
    // Example: Starvation due to high-priority threads
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
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
            while (true) { /* Does not get enough CPU time */ }
        }

        static void HighPriorityTask()
        {
            while (true) { /* Hogging the CPU */ }
        }
    }

}

//In this example, low-priority threads may starve as the high-priority thread consumes most of the CPU time.

//Resolution:
//Use fair scheduling (e.g., Task and TaskScheduler in C# often handle fairness better). Avoid long-running high-priority threads.