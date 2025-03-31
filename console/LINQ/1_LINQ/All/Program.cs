using System;
using System.Collections.Generic;
using System.Linq;

namespace All
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst1 = new List<int>() { 2, 4, 6, 8, 0 }; //contains all even numbers only

            var res = lst1.All(x => x % 2 == 0); //true
            Console.WriteLine("Contains all even numbers : " + res);

            var lst2 = new List<int>() { 1, 3, 5, 7, 2 }; //contains 4 odd + 1 even 

            res = lst2.All(x => x % 2 != 0); //false
            Console.WriteLine("Contains all odd numbers : " + res);

            Console.ReadKey();
        }
    }
}
