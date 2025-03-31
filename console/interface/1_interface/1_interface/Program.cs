using System;

namespace _1_interface
{
    public interface Interface1
    {
         void func1();
    }
    public interface Interface2: Interface1 //Single Interface
    {
         void func2();
    }

    public class Program : Interface2 //Mutli-level Interface
    {
        public void func1() { Console.WriteLine("Interface1 func1"); }
        public void func2() { Console.WriteLine("Interface2 func2"); }

        public static void Main(string[] args)
        {
            Program obj1 = new Program();
            obj1.func1();
            obj1.func2();
    
            Console.ReadKey();
        }
    }
}
