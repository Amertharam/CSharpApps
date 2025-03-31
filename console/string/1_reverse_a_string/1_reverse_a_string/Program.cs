using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to reverse:");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

        ////by built in reverse function-start
        //Array.Reverse(charArray);
        //string reversedString = new string(charArray);
        ////by built in reverse function-end
        
        //by manual reverse function-start
        char[] reversedCharArray = new char[charArray.Length];
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            reversedCharArray[i] = charArray[charArray.Length - 1 - i];
        }
        string reversedString = new string(reversedCharArray);
        //by manual reverse function-end

        Console.WriteLine("Reversed string: " + reversedString);
        Console.ReadKey();
    }
}
