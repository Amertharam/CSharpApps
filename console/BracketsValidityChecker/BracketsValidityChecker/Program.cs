using System;
using System.Collections.Generic;

namespace BracketsValidityChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string with parentheses:");
            string input = Console.ReadLine();

            if (IsValidParentheses(input))
            {
                Console.WriteLine("The parentheses are valid.");
            }
            else
            {
                Console.WriteLine("The parentheses are not valid.");
            }
        }

        public static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}
