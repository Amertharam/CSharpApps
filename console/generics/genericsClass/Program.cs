using System;

namespace genericsClass
{
    // Generic Class
    public class Calculator<T>
    {
        public static bool AreEqual(T a, T b) { return a.Equals(b); }
        public static bool IsNull(T a) { return a==null; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //same inputs
            dynamic res = Calculator<int>.AreEqual(1, 1);
            Console.WriteLine(res);

            //different inputs
            res = Calculator<int>.AreEqual(1,2);
            Console.WriteLine(res);

            //same inputs
            res = Calculator<string>.AreEqual("asd", "asd");
            Console.WriteLine(res);

            //different inputs
            res = Calculator<string>.AreEqual("asd", "xyz");
            Console.WriteLine(res);

            //null input
            res = Calculator<string>.IsNull(null);
            Console.WriteLine(res);

            //non null input
            res = Calculator<string>.IsNull("asd");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
