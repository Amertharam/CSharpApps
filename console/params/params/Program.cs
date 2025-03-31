using System;

namespace @params
{
    public class Program
    {
        public static double add(params double[] value) 
        {
            double result = 0.0;
            foreach (var item in value)
            {
                result = result + item;
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(add(1,2,3,4,5,6,7,8,9));
            Console.ReadKey();
        }
    }
}
