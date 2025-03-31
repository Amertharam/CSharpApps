using System;

namespace _3_anonymus_delegate
{
    //delegate type definition
    public delegate int dlgtCalculator(int a, int b);
    public class Program
    {
        public static void Main(string[] args)
        {
            //delegate object decalration
            dlgtCalculator calculator;

            //delegate object instansiation
            calculator = delegate(int x, int y) { Console.WriteLine("anonymus add :" + x + " + " + y); return x+y; }; //for add

            var addedResult= calculator(1, 2);
            Console.WriteLine("returned value from Anonymus Delegate is : " + addedResult);

            Console.ReadKey();
        }
    }
}
