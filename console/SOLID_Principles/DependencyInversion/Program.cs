using System;

namespace DependencyInversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            Implementation.Program.RunImplementation();
            Violation.Program.RunViolation();
            Console.ReadKey();
        }
    }
    namespace Implementation 
    {
        // Abstraction (Interface)
        public interface IMessageSender
        {
            void SendMessage(string message);
        }

        // Low-level Module
        public class EmailSender : IMessageSender
        {
            public void SendMessage(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        // High-level Module
        public class Notification
        {
            private readonly IMessageSender _messageSender;

            public Notification(IMessageSender messageSender)
            {
                _messageSender = messageSender;
            }

            public void Notify(string message)
            {
                _messageSender.SendMessage(message);
            }
        }

        // Usage
        class Program
        {
            public static void RunImplementation()
            {
                IMessageSender emailSender = new EmailSender();
                Notification notification = new Notification(emailSender);
                notification.Notify("Hello World!");
            }
        }
    }
    namespace Violation
    {
        // Low-level Module
        public class EmailSender
        {
            public void SendEmail(string message)
            {
                Console.WriteLine($"Email sent: {message}");
            }
        }

        // High-level Module
        public class Notification
        {
            private readonly EmailSender _emailSender;

            public Notification()
            {
                _emailSender = new EmailSender();
            }

            public void Notify(string message)
            {
                _emailSender.SendEmail(message);
            }
        }

        // Usage
        class Program
        {
            public static void RunViolation()
            {
                Notification notification = new Notification();
                notification.Notify("Hello World!");
            }
        }
    }
}
