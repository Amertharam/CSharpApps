using System;
using System.Threading;

namespace MonitorTryEnter
{
    class Program
    {
        static object lock1 = new object();
        static object lock2 = new object();

        static void Thread1()
        {
            if (Monitor.TryEnter(lock1, TimeSpan.FromMilliseconds(500))) // Try to acquire lock1
            {
                try
                {
                    Console.WriteLine("Thread 1 acquired lock1.");
                    Thread.Sleep(300); // Simulate some work

                    if (Monitor.TryEnter(lock2, TimeSpan.FromMilliseconds(500))) // Try to acquire lock2
                    {
                        try
                        {
                            Console.WriteLine("Thread 1 acquired lock2.");
                        }
                        finally
                        {
                            Monitor.Exit(lock2); // Release lock2
                            Console.WriteLine("Thread 1 released lock2.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thread 1 could not acquire lock2.");
                    }
                }
                finally
                {
                    Monitor.Exit(lock1); // Release lock1
                    Console.WriteLine("Thread 1 released lock1.");
                }
            }
            else
            {
                Console.WriteLine("Thread 1 could not acquire lock1.");
            }
        }

        static void Thread2()
        {
            if (Monitor.TryEnter(lock2, TimeSpan.FromMilliseconds(500))) // Try to acquire lock2
            {
                try
                {
                    Console.WriteLine("Thread 2 acquired lock2.");
                    Thread.Sleep(300); // Simulate some work

                    if (Monitor.TryEnter(lock1, TimeSpan.FromMilliseconds(500))) // Try to acquire lock1
                    {
                        try
                        {
                            Console.WriteLine("Thread 2 acquired lock1.");
                        }
                        finally
                        {
                            Monitor.Exit(lock1); // Release lock1
                            Console.WriteLine("Thread 2 released lock1.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thread 2 could not acquire lock1.");
                    }
                }
                finally
                {
                    Monitor.Exit(lock2); // Release lock2
                    Console.WriteLine("Thread 2 released lock2.");
                }
            }
            else
            {
                Console.WriteLine("Thread 2 could not acquire lock2.");
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
    }
}
