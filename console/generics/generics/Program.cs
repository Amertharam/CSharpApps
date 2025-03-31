using System;

namespace generics
{
    public class Calculator
    {
        //Generic Method
        public static bool AreEqual<T>(T a, T b) // Same Method for Different Input Types
        {
            return a.Equals(b);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //same int inputs
            dynamic x = 1;
            dynamic y = 1;
            dynamic res = Calculator.AreEqual<int>(x, y);
            Console.WriteLine("the answer is : " + res);

            //different int inputs
            x = 1;
            y = 2;
            res = Calculator.AreEqual<int>(x, y);
            Console.WriteLine("the answer is : " + res);

            //same string inputs
            x = "ABC";
            y = "ABC";
            res = Calculator.AreEqual<string>(x, y);
            Console.WriteLine("the answer is : " + res);

            //different string inputs
            x = "ABC";
            y = "XYZ";
            res = Calculator.AreEqual<string>(x, y);
            Console.WriteLine("the answer is : " + res);

            Console.ReadKey();
        }
    }
}
