using System;

namespace CallbackBasic
{
    public delegate void delegate1(int x); // delegate type creation
    public static class Program
    {
        public static delegate1 _delegateObj; // delegate object creation
        public static void CallbackMethod(int i) { Console.WriteLine($"{i}"); } //Callback Method
        public static void normalMethod(delegate1 callbackPointer) 
        {
            Console.WriteLine("Heavy Process Started");
            for (int i = 0; i < 100; i++)
            {
                callbackPointer(i);
            }
            Console.WriteLine("Heavy Process Ended");         
        }
        public static void Main(string[] args)
        {
            _delegateObj = CallbackMethod;
            normalMethod(_delegateObj);
            Console.ReadKey();
        }
    }
}
