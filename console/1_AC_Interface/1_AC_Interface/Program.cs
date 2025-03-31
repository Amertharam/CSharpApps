using System;
namespace _1_AC_Interface 
{
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
    public class PremiumCustomer : AC_BuyCustomer
    {
        public override void Discount() { Console.WriteLine("20%"); }
    }
    public class NormalCustomer : AC_BuyCustomer, IBuyingCustomer
    {
        public override void Discount() { Console.WriteLine("10%"); }
    }
    public class EnquiryCustomer : AC_Customer    {    }

    public class Program
    {
        public static void Main()
        {
            PremiumCustomer premiumCustomer = new PremiumCustomer();
            premiumCustomer.Name = "asd";
            premiumCustomer.Enquiry();
            premiumCustomer.Discount();
            premiumCustomer.Buy();
        }
    }
}