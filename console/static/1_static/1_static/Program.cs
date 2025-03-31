using System;

namespace _1_static
{
    public delegate void delegate1();
    public static class class1  //this class is declared as static class. so you will not able to create the object of the class.
    {
        public static int x;
        public static void func1() { Console.WriteLine("f1"); }
        public static void func2() { Console.WriteLine("f2"); }
        static class1() { Console.WriteLine("static ctor called"); } // static constructor is used in this class because this constructor gets called before any it's static class members gets called.
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(class1.x);
            class1.func1();
            class1.func2();
            Console.ReadKey();
        }
    }
}
