//•	Write a program that reads a string from the console and replaces all series 
//  of consecutive identical letters with a single one.

using System;
using System.Collections.Generic;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        //Console.WriteLine("Enter the text here:");
        //string input = Console.ReadLine();
        string input = "aaaaabbbbbcdddeeeedssaa aa cc eeee defffrgaaa swweerf";

        StringBuilder sb = new StringBuilder();
        sb.Append(input);

        for (int i = 0; i < sb.Length; i++)
        {
            char letter = sb[i];
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[j] == letter)
                {
                    sb.Remove(j, 1);
                    j--;
                }
                else
                {
                    break;
                }
            }
        }
        Console.WriteLine(sb);
    }
}

