//•	Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Text;

class ExtractSentences
{

    static bool ContainWord(string sentence, string word)
    {
        string[] words = sentence.Split(new char[] { ' ', ',' ,'(','^','|','[',';',':','-',']',')'}, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
            if (words[i] == word)
                return true;
        return false;
    }
    static void Main()
    {
        //Console.WriteLine("Enter the text:");
        //string input = Console.ReadLine();
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        //Console.WriteLine("Enter the word:");
        //string word = Console.ReadLine();
        string word = "in";

        string[] sentences =input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < sentences.Length; i++)
        {
            if (ContainWord(sentences[i],word))
            {
                sb.Append(sentences[i].Trim()+".");
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

