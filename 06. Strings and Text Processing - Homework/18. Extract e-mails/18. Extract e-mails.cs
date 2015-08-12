//•	Write a program for extracting all email addresses from given text.
//•	All sub-strings that match the format @… should be recognized as emails.


using System;
using System.Text;

class ExtractEMails
{
    static void Main()
    {
        //Console.WriteLine("Enter some text:");
        //string input = Console.ReadLine();
        string input = "This is our mail: hello@abv.bg. Please use it instead of office@abv.bg, since it is our old one. This is fake mail: com.yahoo@office";
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i]=words[i].TrimEnd(new char[] {'.','!','?',','});
            if (words[i].Contains("@")&&words[i].Contains("."))
            {
                if (words[i].IndexOf('@')<words[i].IndexOf('.'))
                {
                    Console.WriteLine(words[i]); 
                } 
            }
        }

    }
}

