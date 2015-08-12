//•	Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	    output
//sample	elpmas

using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.WriteLine("Enter some text:");
        string input = Console.ReadLine();
        string output = new string(input.Reverse().ToArray());
        Console.WriteLine(output);
    }
}
