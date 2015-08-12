/* •	We are given a string containing a list of forbidden words and a text containing some of these words.
   •	Write a program that replaces the forbidden words with asterisks.
 *
  Example text: 
  Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is 
  implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: 
 ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is 
 implemented as a dynamic language in ***.  */

using System;
using System.Collections.Generic;

class ForbiddenWords
{
    static void Main()
    {
        //Console.WriteLine("Enter the text: ");
        //string input = Console.ReadLine();
        string input = " Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        //Console.WriteLine("Enter the forbidden words, separated by comma or/and space:");
        //string notAllowed = Console.ReadLine();
        string notAllowed = "PHP, CLR, Microsoft";

        List<string> forbidden = new List<string> (notAllowed.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries));

        string[] words = input.Split(new char[]{' ','.','!','?','-',',',':',';'}, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbidden.Count; i++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if (words[j] == forbidden[i])
                {
                    input = input.Replace(forbidden[i], new string('*', forbidden[i].Length));
                }
            }
        }
        Console.WriteLine(input);

        

    }
}

