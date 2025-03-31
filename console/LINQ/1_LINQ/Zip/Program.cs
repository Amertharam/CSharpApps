using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zip
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<char> characters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' };

            var res = characters.Zip(numbers, (characters_PositionHolder, numbers_PositionHolder) => $"{characters_PositionHolder}<--->{numbers_PositionHolder}");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
