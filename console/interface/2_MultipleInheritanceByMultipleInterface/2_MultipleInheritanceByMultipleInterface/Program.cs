using System;

namespace _2_MultipleInheritanceByMultipleInterface
{
    public interface IMother { void getHeight();}
    public interface IFather { void getHeight(); }
    public class Child : IMother, IFather //Multiple Interface acts like Multiple Inheritence
    {       
        void IMother.getHeight(){ Console.WriteLine("5feet"); } //explicit method naming required due to both parent interfaces has same method name
        void IFather.getHeight(){ Console.WriteLine("6feet"); } //explicit method naming required due to both parent interfaces has same method name
        public void getHeight(){ Console.WriteLine("1feet"); } 
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            IMother obj1 = new Child(); //explict upcasting required to access hidden method
            obj1.getHeight();        
            IFather obj2 = new Child(); //explict upcasting required to access hidden method
            obj2.getHeight();            
            Child obj3 = new Child();
            obj3.getHeight();

            //[Optional] other ways to cast and use the hidden methods
            (obj3 as IFather).getHeight(); //explict upcasting used here
            (obj3 as IMother).getHeight(); //explict upcasting used here

            Console.ReadKey();            
        }
    }
}
