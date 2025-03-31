using System;

namespace _3rdPartyDLL
{
    public class _3rdPartyClass 
    {
        private int field1 = 1;
        protected int field2 = 2;
        public int field3 = 3;
        public _3rdPartyClass() { }
        public int method1() { return field1; }
        public int method2() { return field2; }
        public int method3() { return field3; }
    }
    public class class1 { }
    public class class2 { }
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
