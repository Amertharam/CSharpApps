using System;

namespace AC_plus_Interface_Implementation_in_SingleClass
{
    //AC
    public abstract class AC { public virtual void print() { Console.WriteLine("I am AC base Impl"); } }
    //Inf
    interface Inf { void print(); }
    //MainClass
    public class Program : AC, Inf
    {
        //AC Impl
        public new void print() { Console.WriteLine("I am a AC derived Impl"); }
        //Inf Impl
        void Inf.print() { Console.WriteLine("I am a Inf Impl"); }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.print(); // AC derived Impl
            (obj as AC).print();// AC base Impl
            (obj as Inf).print(); // Inf Impl
            Console.ReadKey();
        }
    }
}
