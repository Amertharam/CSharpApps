using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_throw_throwEX
{
    class class1forTHROW 
    {
        public static void func1()
        {
            try
            {
                func2();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void func2()
        {
            throw new Exception();
        }
    }

    class class2forTHROW_EX
    {
        public static void func1()
        {
            try
            {
                func2();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void func2()
        {
            throw new Exception();
        }
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            /*class1forTHROW.func1 ();*/ // throw example. it will throw exception, so see that exception call-stack. it preserves the origin of exception source.
            //!!!NOTE: comment the above statement, before running below statement. due of intentional throw-ing of exception. program can't continue further.
            class2forTHROW_EX.func1(); // throw_ex example. it will throw exception, so see that exception call-stack. it resets the origin of exception source.
        }
    }
}
