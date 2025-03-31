using System;

namespace _2_staticFuncCallByDelegates
{
    public delegate void delegate1();
    public class Program
    {
        public static void func1() { Console.WriteLine("f1"); }
        public static void func2() { Console.WriteLine("f2"); }
        public static void Main(string[] args)
        { 
            delegate1 delegate1Obj;
            delegate1Obj = Program.func1;
            delegate1Obj += Program.func2;
            delegate1Obj();
            Console.ReadKey();
        }
    }
}
