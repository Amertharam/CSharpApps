using System;

namespace FactoryPattern
{
    //abstraction using interface
    public interface IAutomationComponent
    {
        void Operate();
    }
    //concerete class 1
    class Sensor : IAutomationComponent
    {
        public void Operate()
        {
            Console.WriteLine("Collectiong Data");
        }
    }
    //concerete class 2
    class Actuator : IAutomationComponent
    {
        public void Operate()
        {
            Console.WriteLine("Performing Action");
        }
    }
    //static factory class
    public static class Factory
    {
        //static IAutomationComponent _automationComponent;
        public static IAutomationComponent GetComponent(string componentName)
        {
            switch (componentName)
            {
                case "sensor":
                    return new Sensor();
                case "actuator":
                    return new Actuator();
                default:
                    throw new NotImplementedException();
            }
        }
    }
    //main class
    class Program
    {
        public static void Main(string[] args)
        {
            IAutomationComponent automationComponent = Factory.GetComponent("sensor");
            automationComponent.Operate();
            automationComponent = Factory.GetComponent("actuator");
            automationComponent.Operate();
            Console.ReadKey();
        }
    }
}
