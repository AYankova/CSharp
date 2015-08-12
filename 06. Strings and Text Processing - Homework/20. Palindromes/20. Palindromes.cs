//•	Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;

class Palindromes
{
    static void Main()
    {
        //Console.WriteLine("Enter some text:");
        //string input = Console.ReadLine();
         string input = "I love ABBA very much. I listen to their music when making exe files. What the hell is lamal?";
        //string input = "deleveled, individual, detartrated, specific, devoved principle, dewed,identified, racecar, create, radar, derived,economic, testset, involved";

        string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            int halfLen = words[i].Length / 2;
            char[] singleWord = words[i].ToCharArray();
            bool match = false;

            for (int j = 0; j < halfLen; j++)
            {
                if (singleWord[j]==singleWord[words[i].Length-j-1])
                {
                    match = true;
                }
                else
                {
                    break;
                }
            }
            if (match)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
