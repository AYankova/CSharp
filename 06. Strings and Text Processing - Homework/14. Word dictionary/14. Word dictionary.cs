/*•	A dictionary is stored as a sequence of text lines containing words and 
 * their explanations.
 •  Write a program that enters a word and translates it by using the dictionary.*/

//Sample dictionary:

//  input	        output
//  .NET	        platform for applications from Microsoft
//  CLR	            managed execution environment for .NET
//  namespace	    hierarchical organization of classes

using System;
using System.Collections.Generic;

class WordDictionary
{
    static Dictionary<string, string> myDict = new Dictionary<string, string>()
      {                               {".NET","platform for applications from Microsoft"},
                                      {"CLR","managed execution environment for .NET"},
                                      {"namespace","hierarchical organization of classes"}
      };
    static void Main()
    {
        Console.Write("Enter a word to translate:");
        string word = Console.ReadLine();

        if (myDict.ContainsKey(word))
        {
            Console.WriteLine(word+"-"+myDict[word]);
        }
        else
        {
            Console.WriteLine("No defintion for the word you've entered in this dictionary! ");
        }

    }
}
