using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            string rawStr = "Dhvani Research and Development Solutions | Chennai, Tamil Nadu July 2021 - October 2023\r\nSenior Technical Engineer | C# Developer\r\n●\r\nWrote production grade softwares in Microsoft .NET, C#, and C++ to create and modify the GUI for new and existing products.\r\n●\r\nDeveloped algorithms to collect and analyze data collected by the instrument.\r\n●\r\nImplemented, modified, and debugged software routines to interface with and control hardware such motors, robots, sensors and other computers.\r\n●\r\nConducted design reviews and secure consensus from partners and subject matter experts.\r\n●\r\nResolved system, subsystem issues & worked with various partners to implement solutions.";
            string str = Regex.Replace(rawStr,"[^0-9A-Za-z]"," ",RegexOptions.Compiled);
            Array words = str.Split(' ');

            // Dictionary to store distinct words and their occurrence counts
            Dictionary<string, int> words_Dictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (words_Dictionary.ContainsKey(word))
                {
                    // Increment the count if the word already exists in the dictionary
                    words_Dictionary[word]++;
                }
                else
                {
                    // Add the word to the dictionary with an initial count of 1
                    words_Dictionary[word] = 1;
                }
            }

            // Print the distinct words and their occurrence counts
            Console.WriteLine("Distinct words and their occurrence counts:");
            foreach (var entry in words_Dictionary)
            {
                Console.WriteLine($"Word: {entry.Key}, Count: {entry.Value}");
            }
        }
    }

}
