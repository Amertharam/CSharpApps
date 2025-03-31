using System;
using System.Reflection;
using _3rdPartyDLL;

namespace _1_Reflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Load the assembly
            Assembly assembly = Assembly.LoadFile(@"C:\Users\amert\source\repos\cSharpApps\console\reflection\1_Reflection\_3rdPartyDLL\bin\Debug\_3rdPartyDLL.exe");

            // Get all types (classes) in the assembly
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine("Class: " + type.FullName);

                // Get and print all fields
                FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                foreach (FieldInfo field in fields)
                {
                    Console.WriteLine("  Field: " + field.Name + " (Type: " + field.FieldType  + ")" );
                    FieldInfo field2 = type.GetField(field.Name, BindingFlags.NonPublic | BindingFlags.Instance);
                    int result = (int)field2.GetValue(type);
                }

                // Get and print all methods
                MethodInfo[] methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
                foreach (MethodInfo method in methods)
                {
                    Console.WriteLine("  Method: " + method.Name);
                }

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}

