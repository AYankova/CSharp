//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            Console.Write("Please enter a word: ");
            string word = Console.ReadLine().Trim().ToUpper();
            int[] letters=new int[26];

            for (int i = 65; i <= 90; i++)
            {
                letters[i - 65] = i;
            }
            foreach (char symbol in word)
            {
                Console.WriteLine("Letter {0} has index {1} in the array and ASCII code {2} "
                                    ,symbol,Array.IndexOf(letters,symbol),(int)symbol); 
            } 
               
        }
    }
}
