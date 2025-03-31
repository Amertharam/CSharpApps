using System;
using System.Collections.Generic;
using System.Linq;

namespace Skip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var res = lst.Skip(3);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
