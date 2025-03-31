using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst = new List<int>() { 1, 2, 2, 3, 4, 4, 5, 5, 5, 6, 7, 8, 9, 0 };
            dynamic res = lst.Distinct(); // it removes all duplicates

            Console.WriteLine("Now list contains only unique int values");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            var stringlst = new List<string>() { "abc", "sdf","sdf", "qwe","jkl","jkl","jkl","bnm" };
            res = stringlst.Distinct(); // it removes all duplicates

            Console.WriteLine("Now list contains only unique string values");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
