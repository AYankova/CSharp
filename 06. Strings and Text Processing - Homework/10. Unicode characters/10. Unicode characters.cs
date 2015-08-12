//•	Write a program that converts a string to a sequence of C# Unicode character literals.
//•	Use format strings.

//Example:
//input  	output
//Hi!	    \u0048\u0069\u0021

using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.WriteLine("Enter some text to see its unicode representation:");
        string input = Console.ReadLine();

        for (int i = 0; i <input.Length; i++)
        {
            Console.Write(string.Format("\\u{0:x4}", (int)input[i]));
        }
        Console.WriteLine();
    }
}

