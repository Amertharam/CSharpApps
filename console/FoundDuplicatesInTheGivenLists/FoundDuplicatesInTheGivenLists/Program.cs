using System;
using System.Collections.Generic;

namespace FoundDuplicatesInTheGivenLists
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> lst1 = new List<int>() { 1, 2, 3, 2, 1 };
            List<int> lst2 = new List<int>() { 2, 2, 3 };
            List<int> ResultList = new List<int>();
            foreach (var item1 in lst1)
            {
                foreach (var item2 in lst2)
                {
                    if (item1 == item2)
                    {
                        if (!ResultList.Contains(item2))
                        {
                            ResultList.Add(item2);
                        }                   
                    }
                }
            }
            foreach (var item in ResultList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
