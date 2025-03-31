using System;

namespace InterfaceSegregation
{
    class Program
    {
        public static void Main(string[] args)
        {
            Implementation.Program.RunImplementation();
            Violation.Program.RunViolation();
        }
    }
    namespace Implementation 
    {
        // Separate Interfaces (Adhering to ISP)
        public interface IPrinter
        {
            void PrintDocument();
        }

        public interface IScanner
        {
            void ScanDocument();
        }

        // Class implementing only the Printer interface
        public class Printer : IPrinter
        {
            public void PrintDocument()
            {
                Console.WriteLine("Printing document...");
            }
        }

        // Class implementing only the Scanner interface
        public class Scanner : IScanner
        {
            public void ScanDocument()
            {
                Console.WriteLine("Scanning document...");
            }
        }

        // Usage
        class Program
        {
            public static void RunImplementation()
            {
                IPrinter printer = new Printer();
                printer.PrintDocument();

                IScanner scanner = new Scanner();
                scanner.ScanDocument();
            }
        }
    }
    namespace Violation 
    {
        // Large Interface (Violating ISP)
        public interface IMultiFunctionDevice
        {
            void PrintDocument();
            void ScanDocument();
            void FaxDocument();
        }

        // Class implementing a large interface but not using all methods
        public class Printer : IMultiFunctionDevice
        {
            public void PrintDocument()
            {
                Console.WriteLine("Printing document...");
            }

            public void ScanDocument()
            {
                throw new NotImplementedException("Scan function not supported.");
            }

            public void FaxDocument()
            {
                throw new NotImplementedException("Fax function not supported.");
            }
        }

        // Usage
        class Program
        {
            public static void RunViolation()
            {
                IMultiFunctionDevice printer = new Printer();
                printer.PrintDocument();

                // Attempting to call ScanDocument or FaxDocument results in runtime exceptions
                try { printer.ScanDocument(); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }

                try { printer.FaxDocument(); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }           
            }
        }
    }
}
