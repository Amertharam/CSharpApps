using System;

namespace LiskovSubsitution
{
    //base class
    public class Bird
    {
       public virtual void Fly() { Console.WriteLine("bird fly"); }
    }
    //child class which implemets LSP
    public class Eagle :Bird
    { 
       public override void Fly() { Console.WriteLine("Eagle fly"); }
    }
    //child class which violates LSP
    public class Penguin: Bird
    { 
       public override void Fly() { throw new NotImplementedException(); }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Bird b = new Bird();
            b.Fly();

            b = new Eagle(); // LSP Implemented
            b.Fly();

            b = new Penguin(); // LSP Violated
            try
            {
                b.Fly(); // violation because of this
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
            Console.ReadKey();
        }
    }
}

//Explanation:
//The Penguin class is derived from Bird, but it throws an exception in the Fly() method.
//This violates the LSP because the Penguin class cannot behave as a valid replacement for the base class Bird.
//Users of the Bird class would expect all subclasses to be able to fly.