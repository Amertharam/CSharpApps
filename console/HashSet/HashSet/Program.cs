using System;
using System.Collections.Generic;

namespace HashSet
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                numbers.Add(i);
            }

            //Intentinal change of value to set duplicate value
            numbers[10] = 9;
            numbers[11] = 8888;

            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int number in numbers)
            {
                if (seenNumbers.Contains(number))
                {
                    Console.WriteLine($"Duplicate found: {number}");
                }
                else
                {
                    seenNumbers.Add(number);
                }
            }
            Console.ReadKey();
        }
    }

}
