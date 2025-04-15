using System;

namespace FactoryPattern
{
    //enum
    public enum AutomationComponent {Sensor,Actuator }
        
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
        public static IAutomationComponent GetComponent(AutomationComponent componentName)
        {
            switch (componentName)
            {
                case AutomationComponent.Sensor:
                    return new Sensor();
                case AutomationComponent.Actuator:
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
            IAutomationComponent automationComponent = Factory.GetComponent(AutomationComponent.Sensor);
            automationComponent.Operate();
            automationComponent = Factory.GetComponent(AutomationComponent.Actuator);
            automationComponent.Operate();
            Console.ReadKey();
        }
    }
}
