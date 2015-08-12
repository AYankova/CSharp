/*•	Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 
 * 20, the rest of the characters should be filled with *.
 * • Print the result string into the console.*/

using System;
using System.Text;

class StringLength
{
    const int n=20;

    static void Main()
    {
        Console.Write("Enter string (MAX LENGTH: 20 chars): ");
        string input = Console.ReadLine();
        StringBuilder output=new StringBuilder(20);

        if (input.Length > n)
        {
            Console.WriteLine("Input must contain less than 20 characters!");
        }
        else
        {
            foreach (char symbol in input)
            {
                output.Append(symbol);

            }
            if (input.Length < n)
            {
                output.Append('*', n - input.Length);
            }
            Console.WriteLine(output);
        }

    }
}
