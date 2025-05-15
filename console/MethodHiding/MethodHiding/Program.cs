using System;

namespace MethodHiding
{
    public class A
    {
        //"virtual" keyword is used to denote the below method is overridable in upcoming derived classes // method overriding
        virtual public void foo() { Console.WriteLine("A"); }
    }
    public class B : A
    {
        //"override" keyword is used to denote the below method is override the base class method if that is defined as virtual, as well as this method is also overridable in upcoming derived classes // method overriding
        override public void foo() { Console.WriteLine("B"); }
    }
    public class C : B
    {
        //"new" keyword is used to intentionally hide the below method, if you doesn't put the "new" keyword below then compiler throws warning like that hiding is un-intentional // method hiding
        new public void foo() { Console.WriteLine("C"); }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            A a = new A(); //same pointer to same object-(A) //non-poly object "a"
            a.foo();                                     
            B b = new B(); //same pointer to same object-(B) //non-poly object "b"
            b.foo();                                     
            C c = new C(); //same pointer to same object-(C) //non-poly object "c"
            c.foo();
            
            A obj = new C(); //different pointer to different object-(C) //poly object "obj" 
            obj.foo();

            Console.ReadKey();
        }
    }
}
