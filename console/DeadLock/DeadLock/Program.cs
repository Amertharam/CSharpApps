using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Threading;

namespace DeadLock
{
    public class Program
    {
        static readonly object LockA = new object();
        static readonly object LockB = new object();

        public static void Main()
        {
            Thread thread1 = new Thread(() =>
            {
                lock (LockA)
                {
                    Thread.Sleep(100); // Simulate work
                    lock (LockB) { /* Deadlock here */ }
                }
            });

            Thread thread2 = new Thread(() =>
            {
                lock (LockB)
                {
                    Thread.Sleep(100); // Simulate work
                    lock (LockA) { /* Deadlock here */ }
                }
            });

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();
        }
    }
}

//In this example, thread1 and thread2 cause a circular wait: thread1 holds LockA and waits for LockB, while thread2 holds LockB and waits for LockA.

//Resolution:
//Use a consistent locking order to avoid circular dependencies.
//Use timeouts for acquiring locks (e.g., Monitor.TryEnter).
//Consider using higher-level concurrency primitives like SemaphoreSlim.