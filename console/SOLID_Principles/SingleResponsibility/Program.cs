using System;

namespace SingleResponsibility
{
    namespace Action 
    {
        public class Program 
        {
            public static void Main() 
            {
                Implementation.Program.Implementation();
                Violation.Program.Violation();
            }
        }
    }
    namespace Implementation
    {
        public class Invoice
        {
            public void CalculateTotal() // Single Responsibility
            {
                Console.WriteLine("Calculating total for the invoice...");
            }
        }

        public class InvoicePrinter // Single Responsibility
        {
            public void PrintInvoice()
            {
                Console.WriteLine("Printing the invoice...");
            }
        }

        public class Program
        {
            public static void Implementation()
            {
                Invoice invoice = new Invoice();
                invoice.CalculateTotal();

                InvoicePrinter printer = new InvoicePrinter();
                printer.PrintInvoice();
            }
        }
    }
    namespace Violation
    {
        using System;

        public class Invoice
        {
            public void CalculateTotal() // Single Responsibility
            {
                Console.WriteLine("Calculating total for the invoice...");
            }

            public void PrintInvoice() // Extra or Additional Responsibility
            {
                Console.WriteLine("Printing the invoice...");
            }
        }

        public class Program
        {
            public static void Violation()
            {
                Invoice invoice = new Invoice();
                invoice.CalculateTotal();
                invoice.PrintInvoice(); // Printing and business logic combined in one class
            }
        }
    }
}
