using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_reverse_a_sentence
{
    public class Program
    {
        public string reverse_a_sentence_string(string str)
        {
            string reversedSentence = "";
            Array words = str.Split(' ');
            Array.Reverse(words);

            return reversedSentence;
        }
        public static void Main(string[] args)
        {
            string str = "this is eswari"; //eswari is this 
            string reversedSentence = "";
            Array words = str.Split(' ');
            Array.Reverse(words);
            foreach (var word in words)
            {
                reversedSentence = reversedSentence + word + " ";
            }
            Console.WriteLine(reversedSentence);
            Console.ReadLine();
        }
    }
}
