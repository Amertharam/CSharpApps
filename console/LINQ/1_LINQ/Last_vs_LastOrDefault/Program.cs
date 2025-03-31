using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_vs_LastOrDefault
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var lst2 = new List<int>() { };
            var res = lst1.Last();
            Console.WriteLine("Last return : " + res);

            try
            {
                res = lst2.Last();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Last return : " + "exception : "+ex.Message);
            }
            finally
            {
                Console.WriteLine("If we use Last on empty list. It will throw null exception so we use LastOrDefault to avoid this");
            }

            res = lst2.LastOrDefault();
            Console.WriteLine("LastOrDefault return : " + res);

            Console.ReadKey();
        }
    }
}
