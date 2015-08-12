//•	Write a program that reads a list of words, separated by spaces 
//  and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;

class OrderWords
{
    static void Main()
    {
        //Console.WriteLine("Enter the text here:");
        //string input = Console.ReadLine();
        string input = "Write a program that reads a list of words separated by spaces";
        string[] words = input.Split(' ');
        Array.Sort(words);
        Console.WriteLine("Input string:");
        Console.WriteLine(input);
        Console.WriteLine();
        Console.WriteLine("Sorted list alphabetically:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
