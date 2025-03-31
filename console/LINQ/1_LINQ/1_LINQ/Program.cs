using System;
using System.Collections.Generic;
using System.Linq;

namespace _1_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,5,6,7,8,9,0};

            //to find all even numbers in the list
            //IEnumerable<int> evenNumbersList = from n in list
            //                                   where (n%2 == 0)
            //                                   select n;
            IEnumerable<int> evenNumbersList = list.Where(X => X % 2 == 0);
            //print all even numbers
            foreach (int n in evenNumbersList) { Console.WriteLine(n); }
            Console.ReadKey();
        }
    }
}
