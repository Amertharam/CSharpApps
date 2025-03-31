using System;
using System.Threading.Tasks;

namespace DependentMethodsExample
{
    public class Program
    {
        public const int const1 = 100;
        public const int const2 = 1000;
        public const int const3 = 10000;

        public static int Method1(int x)
        {
            Task.Delay(1000);
            return const1 + x;
        }
        public static int Method2(int x)
        {
            Task.Delay(1000);
            return const2 + x;
        }
        public static int Method3(int x)
        {
            Task.Delay(1000);
            return const3 + x;
        }
        public static async Task Async_Method(int UserInput) // Return Type of Async Method must be Void or Task or Task<T> or ValueTask<T> Always
        {
            int i = await Task<int>.Run(() => Method1(UserInput));
            Console.WriteLine(i);
            int j = await Task<int>.Run(() => Method2(i));
            Console.WriteLine(j);
            int k = await Task<int>.Run(() => Method3(j));
            Console.WriteLine(k);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("M start");
            Program.Async_Method(System.Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("M : " + 1);
            Console.WriteLine("M : " + 2);
            Console.WriteLine("M : " + 3);
            Console.ReadKey();
        }
    }
}
