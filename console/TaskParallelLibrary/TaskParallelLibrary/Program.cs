using System;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {       
        static void Main()
        {
            // Define the range of numbers
            int start = 1, end = 100;

            Console.WriteLine("Squares of numbers using Parallel.For:");

            // Use Parallel.For to process the range in parallel
            Parallel.For(start, end + 1, i =>
            {
                int square = i * i;
                Console.WriteLine($"Number: {i}, Square: {square}");
            });

            Console.WriteLine("Execution completed!");
        }
    }

}
