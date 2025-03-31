using System;
using System.Collections.Generic;
using System.Linq;

namespace Any
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst1 = new List<int>() { 1, 3, 5, 7, 9 }; // all odd numbers
            var res = lst1.Any(x => x % 2 == 0); //false
            Console.WriteLine("Contains any even numbers : " + res);

            var lst2 = new List<int>() { 1, 2, 4, 6, 8, 0 }; // 5 even + 1 odd number
            res = lst2.Any(x => x % 2 != 0); //true
            Console.WriteLine("Contains any odd numbers : " + res);

            Console.ReadKey();
        }
    }
}
