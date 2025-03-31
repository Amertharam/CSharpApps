using System;

namespace MethodHiding
{
    public class A
    {
        //"virtual" keyword is used to denote the below method is overridable in upcoming derived classes // method overriding
        virtual public void foo()         {            Console.WriteLine("A");        }
    }
    public class B : A
    {
        //"override" keyword is used to denote the below method is override the base class method if that is defined as virtual, as well as this method is also overridable in upcoming derived classes // method overriding
        override public void foo()         {            Console.WriteLine("B");        }
    }
    public class C : B
    {
        //"new" keyword is used to intentnally hide the below method, if you doesn't put the "new" keyword below then compiler throws warning like that hiding is un-intentnal // method hiding
        new public void foo()        {            Console.WriteLine("C");        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            A a = new A(); //base pointer to same object-(A)
            a.foo();
            B b = new B(); //base pointer to same object-(B)
            b.foo();
            C c = new C(); //base pointer to  same object-(C)
            c.foo();
            
            A obj = new C(); //base pointer to super-base object-(A)
            obj.foo();

            Console.ReadLine();
        }
    }
}
