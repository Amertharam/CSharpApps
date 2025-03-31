using System;

namespace Non_Singleton_To_Singleton
{
    public class NonSingleton
    {
        public void Display()
        {
            Console.WriteLine("Non-Singleton Instance");
        }
    }

    //It is called Proxy Pattern or Wrapper Pattern
    public class SingletonWrapper
    {
        // Private static field to hold the single instance
        private static NonSingleton _instance;

        // Private constructor to prevent direct instantiation
        private SingletonWrapper() { }

        // Public static method to provide access to the single instance
        public static NonSingleton GetInstance()
        {

            if (_instance == null)
            {
                _instance = new NonSingleton(); // Create instance if not already created
            }
            return _instance;

        }
    }

    class Program
    {
        static void Main()
        {
            // Access the NonSingleton instance through the wrapper
            var singletonInstance1 = SingletonWrapper.GetInstance();
            var singletonInstance2 = SingletonWrapper.GetInstance();

            singletonInstance1.Display();

            // Verify that both instances are the same
            Console.WriteLine(ReferenceEquals(singletonInstance1, singletonInstance2)
                ? "Both are the same instance"
                : "Different instances");
        }
    }

}
