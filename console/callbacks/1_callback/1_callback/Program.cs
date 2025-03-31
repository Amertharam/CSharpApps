using System;
using System.Threading.Tasks;

namespace _1_callback
{
    public class Program
    {
        public delegate void CallbackName(int i);   //  delegate creation
        public void download(CallbackName callbackObject, string name) // actually this line make delegate as a callback, because we pass delegateObject as a parameter to a function
        {
            Console.WriteLine("download started");            
            for(int i=0; i<=100; i++) //Long running Loop
            {
              // delegate call
              callbackObject(i); //sending "i" variable's live data to "callback function" via passed "delegateObject"(or)"callbackObject"
            };
            Task.Delay(5000).Wait();          
            Console.WriteLine("download ended");
        }
        public void downloadingPercentage(int i) // callback function
        {
            Console.WriteLine("downloading :"+i+"%");
        }
        public static void Main(string[] args)
        {
            Program obj = new Program();
            
            CallbackName callbackObject; // delegate object creation
            callbackObject = obj.downloadingPercentage; // assigning "callback function" with "delegateObject"(or)"callbackObject"
            obj.download(callbackObject, "file1");  // passing "delegateObject"(or)"callbackObject" as a parameter

            Console.ReadKey();
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1_callback
//{
//    public class Program
//    {
//        public delegate void downloadedSuccessfullyCallback(string name);

//        public void download(downloadedSuccessfullyCallback dsCB, string name)
//        {
//            Console.WriteLine("download started");
//            for (int i = 0; i < 20; i++) { Console.WriteLine("Downloading"); };
//            Task.Delay(5000).Wait();
//            dsCB(name);
//        }
//        public void downloadSuccessfully(string name)
//        {
//            Console.WriteLine(name + " downloaded succesfully");
//        }
//        public static void Main(string[] args)
//        {
//            Program obj = new Program();
//            downloadedSuccessfullyCallback downloadedSuccessfullyCBobject = new downloadedSuccessfullyCallback(obj.downloadSuccessfully);
//            obj.download(downloadedSuccessfullyCBobject, "file1");

//            Console.ReadKey();
//        }
//    }
//}
