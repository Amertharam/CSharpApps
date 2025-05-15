using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tst
{
    class tstcls 
    {
        public List<string> vari;     
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //Many Start
            tstcls tstcls1 = new tstcls();
            tstcls tstcls2 = new tstcls();

            tstcls1.vari = new List<string>() { "abc", "xyz"};
            tstcls2.vari = new List<string>() { "123"};

            List<tstcls> obj_lst = new List<tstcls>();
            obj_lst.Add(tstcls1);
            obj_lst.Add(tstcls2);

            var res = obj_lst.SelectMany(x => x.vari);
            //Many End

            //Aggregate Start
            var res2 = tstcls1.vari.Aggregate((temp,x) =>temp+x);
            //Aggregate End

            //Zip Start
            var res3 = tstcls1.vari.Zip(tstcls2.vari, (x,y) => $"{x}++{y}");
            //Zip End
        }
    }
}
