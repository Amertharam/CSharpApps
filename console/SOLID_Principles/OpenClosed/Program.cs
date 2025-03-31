using System;
using System.Collections.Generic;

namespace OpenClosed.Implementation
{
    public interface IAutomationComponent
    {
        void Excecute();
    }
    public class StartCommand : IAutomationComponent
    {
        public void Excecute()
        {
            Console.WriteLine("Starting machine...");
        }
    }
    public class StopCommand : IAutomationComponent
    {
        public void Excecute()
        {
            Console.WriteLine("Stopping machine...");
        }
    }
    //public class PauseCommand : IAutomationComponent
    //{
    //    public void Excecute()
    //    {
    //        Console.WriteLine("Pausing machine...");
    //    }
    //}
    //public class ResumeCommand : IAutomationComponent
    //{
    //    public void Excecute()
    //    {
    //        Console.WriteLine("Resuming machine...");
    //    }
    //}    

    public class Command // this class not closed for modification but open for accomodating new features
    {
        List<IAutomationComponent> _automationCommands = new List<IAutomationComponent>();
        public void AddCommand(IAutomationComponent command)
        {
            _automationCommands.Add(command);
        }
        public void ProcessCommands()
        {
            foreach (var command in _automationCommands)
            {
                command.Excecute();
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            Command commandProcessor = new Command();
            commandProcessor.AddCommand(new StartCommand());
            commandProcessor.AddCommand(new StopCommand());
            //commandProcessor.AddCommand(new PauseCommand());
            //commandProcessor.AddCommand(new ResumeCommand());
            commandProcessor.ProcessCommands();
            Console.ReadKey();
        }
    }
}

//namespace OpenClosed.Violation
//{
//    public class Command
//    {
//        public void ProcessCommand(string commandName)
//        {
//            switch (commandName)
//            {
//                case "startCommand":
//                    Console.WriteLine("starting machine...");
//                    break;
//                case "stopCommand":
//                    Console.WriteLine("stoping machine...");
//                    break;
//                default:
//                    Console.WriteLine("not implemented command !!!");
//                    break;
//            }
//        }
//    }
//    public class Program
//    {
//        public static void Main()
//        {
//            Command commandProcessor = new Command();
//            commandProcessor.ProcessCommand("startCommand");
//            commandProcessor.ProcessCommand("stopCommand");
//            commandProcessor.ProcessCommand("newCommand");
//            Console.ReadKey();
//        }
//    }
//}

//namespace OpenClosedExample2
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Implementation.Program.Implementation();
//            Violation.Program.Violation();
//            Console.ReadKey();
//        }
//    }
//    namespace Implementation
//    {
//        public abstract class Employee
//        {
//            public abstract void CalculateBonus();
//        }

//        public class Developer : Employee
//        {
//            public override void CalculateBonus()
//            {
//                Console.WriteLine("Bonus for Developer is calculated.");
//            }
//        }

//        public class Manager : Employee
//        {
//            public override void CalculateBonus()
//            {
//                Console.WriteLine("Bonus for Manager is calculated.");
//            }
//        }

//        class Program
//        {
//            public static void Implementation()
//            {
//                Employee dev = new Developer();
//                Employee mgr = new Manager();

//                dev.CalculateBonus();
//                mgr.CalculateBonus();
//            }
//        }

//    }
//    namespace Violation
//    {
//        public class Employee
//        {
//            public void CalculateBonus(string employeeType)
//            {
//                if (employeeType == "Developer")
//                {
//                    Console.WriteLine("Bonus for Developer is calculated.");
//                }
//                else if (employeeType == "Manager")
//                {
//                    Console.WriteLine("Bonus for Manager is calculated.");
//                }
//            }
//        }

//        class Program
//        {
//            public static void Violation()
//            {
//                Employee emp = new Employee();

//                emp.CalculateBonus("Developer");
//                emp.CalculateBonus("Manager");
//            }
//        }

//    }
//}
