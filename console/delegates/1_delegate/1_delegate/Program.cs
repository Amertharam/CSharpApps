using System;

namespace _1_delegate
{
    //delegate type declaration
    public delegate int delegateNAME(int a, int b);
    public class Program
    {
        //method decalartions
        public int add(int a, int b) { int result = a + b; return result; }
        public int sub(int a, int b) { int result = a - b; return result; }
        public int mul(int a, int b) { int result = a * b; return result; }
        public int div(int a, int b) { int result = a / b; return result; }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            int response = 0;
            //delegate object decalration 
            delegateNAME delegateOBJECT;

            //delegate instansiation to add
            delegateOBJECT = new delegateNAME(obj.add);
            response=delegateOBJECT(1, 2);
            Console.WriteLine("add result :" +response);

            //delegate instansitation to sub
            delegateOBJECT = new delegateNAME(obj.sub);
            response = delegateOBJECT(1, 2);
            Console.WriteLine("sub result :" + response);

            //delegate instansitation to mul
            delegateOBJECT = new delegateNAME(obj.mul);
            response = delegateOBJECT(1, 2);
            Console.WriteLine("mul result :" + response);

            //delegate instansitation to div
            delegateOBJECT = new delegateNAME(obj.div);
            response = delegateOBJECT(1, 2);
            Console.WriteLine("div result :" + response);

            Console.ReadKey();
        }
    }
}
