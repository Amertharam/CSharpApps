using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var objects = new List<Class1> {
                new Class1 { normalMemberVariable = 1, listMemberVariable=new List<string>{ "asd","zxc","qwe"} },
                new Class1 { normalMemberVariable = 2, listMemberVariable=new List<string>{ "bnm","jkl"} }
            };

            var combine_Desired_List_Member_Values_Across_All_The_Objects = objects.SelectMany(obj => obj.listMemberVariable);
            Console.Read();
        }
    }

    public class Class1 
    {
        public int normalMemberVariable;
        public List<string> listMemberVariable;
    }
}
