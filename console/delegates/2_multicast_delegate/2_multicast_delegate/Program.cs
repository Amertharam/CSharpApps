using System;

namespace _2_multicast_delegate
{
    //delegate type definition
    public delegate void dlgtCalculator(int a, int b);
    public class Program
    {
        //function definitions
        public void add(int a, int b) { int result = a + b; Console.WriteLine("add result is :" + result); }
        public void sub(int a, int b) { int result = a - b; Console.WriteLine("sub result is :" + result); }
        public void mul(int a, int b) { int result = a * b; Console.WriteLine("mul result is :" + result); }
        public void div(int a, int b) { int result = a / b; Console.WriteLine("div result is :" + result); }

        public static void Main(string[] args)
        {
            Program obj = new Program();

            //delegate object decalration
            dlgtCalculator calculator;

            //delegate object instansiation
            calculator = new dlgtCalculator(obj.add); //for add
            //multi-cast instatiations
            calculator += new dlgtCalculator(obj.sub); //for sub
            calculator += new dlgtCalculator(obj.mul); //for mul
            calculator += new dlgtCalculator(obj.div); //for div

            calculator(1, 2); // by this single delgate call. multiple functions associated with this delegate gets called at once.
            Console.ReadKey();
        }
    }
}
