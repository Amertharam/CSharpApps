using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst = new List<int>() { 1, 2, 3 };
            dynamic res = lst.Aggregate((temp, x) => temp + x);
            Console.WriteLine("aggregate of integers : "+res);

            var stringlist = new List<string>() { "a", "b", "c" };
            res = stringlist.Aggregate((temp, x) => temp + x);
            Console.WriteLine("aggregate of strings : " + res);

            Console.ReadKey();
        }
    }
}
