using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> unOrderedList = new List<int>() { 2, 1, 3, 8, 7, 9, 0, 5 };

            //Ascending sort
            var res = unOrderedList.OrderBy(x => x);

            //Dcsending sort
            res = unOrderedList.OrderByDescending(x => x);

            Console.ReadKey();
        }
    }
}
