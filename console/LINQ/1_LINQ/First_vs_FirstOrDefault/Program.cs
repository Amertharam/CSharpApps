using System;
using System.Collections.Generic;
using System.Linq;

namespace First_vs_FirstOrDefault
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lst1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var lst2 = new List<int>() { };
            var res = lst1.First();
            Console.WriteLine("First return : " + res);

            try
            {
                res = lst2.First();
            }
            catch (Exception ex)
            {
                Console.WriteLine("First return : " +"exception : "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("If we use First on empty list. It will throw null exception so we use FirstOrDefault to avoid this");
            }

            res = lst2.FirstOrDefault();
            Console.WriteLine("FirstOrDefault return : " + res);

            Console.ReadKey();
        }
    }
}
