using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CallingCppFunctions
{
    public class Program
    {
        [DllImport("C:\\Users\\amert\\source\\repos\\cppApps\\console\\CppFunctionExportProject\\x64\\Debug\\CppFunctionExportProject")]
        public static extern int add(int a, int b);
        public static void Main(string[] args)
        {
            int x = 0;
            x = add(100, 200);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
