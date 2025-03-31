using System;

namespace _1_ExtensionMethods
{
    public sealed class Calc // eventhough this is an sealed class. you can add new methods to this class by using extension methods.
    {
        public int x = 1;
        public int y = 2;

        public Calc() { }
        public int ADD(int x, int y) { return x + y; }
    }
    public static class Class1_Extenstion 
    {
        public static int SUB(this Calc obj, int x, int y) { return x-y; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Calc obj = new Calc();
            Console.WriteLine(obj.SUB(10,2));
            Console.ReadKey();
        }
    }
}
