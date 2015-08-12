//•	Write a program that reads a string from the console and lists all different words in the 
//  string along with information how many times each word is found.

using System;
using System.Collections.Generic;

class WordsCount
{
    static void Main()
    {
        //Console.WriteLine("Enter the text here:");
        //string input = Console.ReadLine();
        string input = "Write a program that reads a string from the console and prints all different words in the string";
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (dict.ContainsKey(word))
            {
                dict[word]++;
            }
            else
            {
                dict.Add(word,1);
            }
        }
        foreach (var element in dict)
        {
            Console.WriteLine(" {0,-15}-->{1} time(s)",element.Key,element.Value);
        }

    }
}

