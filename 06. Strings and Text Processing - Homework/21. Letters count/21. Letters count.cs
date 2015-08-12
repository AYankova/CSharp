//•	Write a program that reads a string from the console and prints all different letters in the 
//  string along with information how many times each letter is found.

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        //Console.WriteLine("Enter the text here:");
       // string input = Console.ReadLine();
        string input = "Write a program that reads a string from the console and prints all different letters";
        Dictionary<char,int> dict=new Dictionary<char,int>();

        foreach (char symbol in input)
        {
            if (char.IsLetter(symbol))
            {
                if (dict.ContainsKey(symbol))
                {
                    dict[symbol]++;
                }
                else
                {
                    dict.Add(symbol, 1);
                }
            }
        }
        foreach (var element in dict)
        {
            Console.WriteLine(" '{0}' -> {1} times(s)", element.Key, element.Value);
        }
    }
}

