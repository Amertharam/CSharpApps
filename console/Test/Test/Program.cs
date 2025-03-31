using System;

namespace Test
{

    internal class Program
    {

        //fuctions

        //call by value
        static void func1(string str) 
        {
            string str1 = str;
            str = "123";
            //return str;
        }
        
        //call by ref
        static void func2(ref string str) 
        {
            string str1 = str;
            str = "123";
            //return str1;
        }
        //int add(int x, int y) //x=0xAA=? y=0xFF=?
        //{
        //    int result = x + y; //result=0x55=3
        //    return result; 
        //}
        int add(ref int x, ref int y) //x=0x01=1 y=0x02=2
        {
            int result = x + y; //result=0x55=3
            x = 45;
            y = 55;
            return result;
        }
        static void Main(string[] args)
        {
            int a = 1; //a=0x01=1
            int b = 2; //b=0x02=2
            Program program = new Program();
            int c = program.add(ref a, ref b); // call by ref
                                               //int c = program.add(0x01, 0x02);
            Console.WriteLine("a =" + a); //a = 45;
            Console.WriteLine("b =" + b);
            //c=0x03=3;
            ///
            //int a = 1; //a=0x01=1
            //int b = 2; //b=0x02=2
            //Program program = new Program();
            //int c= program.add(a,b); // call by value
            ////c=0x03=3;

            func1(testString); // copy by value
            func2(ref testString); // copy by ref
            //string result = func1(testString);
            //Console.WriteLine(result);
            Console.WriteLine(testString);
      
        }
    }
}

//using System;

//namespace Test
//{
//    internal class Program
//    {
//        void function1()
//        {
//        }
//        class class1
//        {
//            //data members
//            private string name_ = "";
//            //properties
//            public string Name
//            {
//                get { return name_; }
//                set { name_ = value; }
//            }
//            //member functions
//            public void changeName(string name_)
//            {
//                this.name_ = name_;
//            }
//            public string getName() { return name_; }
//        }
//        static void Main(string[] args)
//        {
//            class1 obj = new class1();
//            //obj.name = "asd";
//            obj.changeName("eswari"); // access class function
//            obj.Name = "zxcvbnm"; //
//            Console.WriteLine(obj.getName());
//        }
//    }
//}

