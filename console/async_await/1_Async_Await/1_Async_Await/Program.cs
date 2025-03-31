using System;
using System.Threading.Tasks;

namespace _1_Async_Await
{
    public class Program
    {
        public async void Function1() 
        {
            Console.WriteLine("Function1 Start");
            Console.WriteLine("Statement3-FF");
            Console.WriteLine("Statement4-FF");
            Console.WriteLine("Await Delay Start");
            await Task.Delay(5000); // 5 seconds delay
            Console.WriteLine("Await Delay End");
            Console.WriteLine("Statement5-FF");
            Console.WriteLine("Statement6-FF");
            Console.WriteLine("Function1 End");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Function Start");
            Program obj = new Program();

            Console.WriteLine("Statement1-MF");
            Console.WriteLine("Statement2-MF");
            obj.Function1(); // async function call
            Console.WriteLine("Statement7-MF");
            Console.WriteLine("Statement8-MF");

            Console.ReadKey();
            Console.WriteLine("\nMain Function End");
            Console.ReadKey();
        }
    }
}

//-----------------------------------------------------------------
////some functions without Await Markers
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1_Async_Await
//{
//    public class Program
//    {
//        public delegate bool dlgtFunction();
//        dlgtFunction handler;
//        public bool F1() { int count = 5; for (int i = 0; i < count; i++) { Console.WriteLine("1"); } return true; }
//        public bool F2() { int count = 5; for (int i = 0; i < count; i++) { Console.WriteLine("2"); } return true; }
//        public bool F3() { int count = 5; for (int i = 0; i < count; i++) { Console.WriteLine("3"); } return true; }
//        public bool F4() { int count = 5; for (int i = 0; i < count; i++) { Console.WriteLine("4"); } return true; }
//        public async void func1() { Console.WriteLine("Function-1 is Started"); F1(); Console.WriteLine("Function-1 is Ended"); }
//        public async void func2() { Console.WriteLine("Function-2 is Started"); await Task.Run<bool>(F2); Console.WriteLine("Function-2 is Ended"); }
//        public async void func3() { Console.WriteLine("Function-3 is Started"); F3(); Console.WriteLine("Function-3 is Ended"); }
//        public async void func4() { Console.WriteLine("Function-4 is Started"); await Task.Run<bool>(F4); Console.WriteLine("Function-4 is Ended"); }
//        public static void Main(string[] args)
//        {

//            Program obj = new Program();
//            obj.func1();
//            obj.func2();
//            obj.func3();
//            obj.func4();
//            Console.ReadKey();
//        }
//    }
//}