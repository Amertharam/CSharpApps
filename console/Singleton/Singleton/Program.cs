using System;

namespace Singleton
{
    //Singleton class
    public class Singleton 
    {
        private static Singleton _instance;
        public static Singleton GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        private Singleton() { }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var instance1 = Singleton.GetInstance();
            var instance2 = Singleton.GetInstance();

            Console.WriteLine(ReferenceEquals(instance1,instance2)?"same Instance": "different Instance");
            Console.ReadKey();
        }
    }
}
