using System;
namespace _1_AC_Interface 
{
    //no-logic
    interface IEnquiryCustomer 
    {
        string Name { get; set; }
        void Enquiry();
    }
    interface IBuyingCustomer : IEnquiryCustomer
    {
        void Discount();
        void Buy();
    }

    //partial logic
    public abstract class AC_Customer : IEnquiryCustomer
    {
        public string Name { get; set; } = "";
        public void Enquiry() { Console.WriteLine("What is the Price"); }
    }
    public abstract class AC_BuyCustomer : AC_Customer, IBuyingCustomer
    {
        public void Buy() { Console.WriteLine("Buy"); }

        public abstract void Discount();
    }

    //full logic or concerete logic
    public class PremiumCustomer : AC_BuyCustomer
    {
        public PremiumCustomer()
        {
            Console.WriteLine("i am a premium customer");
        }
        public override void Discount() { Console.WriteLine("20%"); }
    }
    public class NormalCustomer : AC_BuyCustomer
    {
        public NormalCustomer()
        {
            Console.WriteLine("i am a normal customer");
        }
        public override void Discount() { Console.WriteLine("10%"); }
    }
    public class EnquiryCustomer : AC_Customer {
        public EnquiryCustomer()
        {
            Console.WriteLine("i am a Enquiry customer");
        }
    }

    public class Program
    {
        public static void Main()
        {
            PremiumCustomer premiumCustomer = new PremiumCustomer();
            premiumCustomer.Name = "asd";
            premiumCustomer.Enquiry();
            premiumCustomer.Discount();
            premiumCustomer.Buy();

            NormalCustomer normalCustomer = new NormalCustomer();
            normalCustomer.Name = "qwe";
            normalCustomer.Enquiry();
            normalCustomer.Discount();
            normalCustomer.Buy();

            EnquiryCustomer enquiryCustomer = new EnquiryCustomer();
            enquiryCustomer.Name = "zxc";
            enquiryCustomer.Enquiry();
            //enquiryCustomer.Discount();
            //enquiryCustomer.Buy();
            Console.ReadKey();
        }
    }
}