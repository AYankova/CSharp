﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TheyAreGreen
{
    static char[] result;
    static void Main()
    {
        var numberOfLetters = int.Parse(Console.ReadLine());
        char[] letters = new char[numberOfLetters];
        for (int i = 0; i < numberOfLetters; i++)
        {
            letters[i] = char.Parse(Console.ReadLine());
        }

        var count = CountWords(letters);

        Console.WriteLine(count);
    }
    private static int CountWords(char[] letters)
    {
        Array.Sort(letters);

        var count = 0;
        do
        {
            if (IsValidWord(letters))
            {
                count++;
            }
        }
        while (NextPermutation(letters));

        return count;
    }
    private static bool IsValidWord(char[] letters)
    {
        for (int i = 1; i < letters.Length; i++)
        {
            if (letters[i] == letters[i - 1])
            {
                return false;
            }
        }

        return true;
    }
    private static bool NextPermutation(char[] array)
    {
        for (int index = array.Length - 2; index >= 0; index--)
        {
            if (array[index] < array[index + 1])
            {
                int swapWithIndex = array.Length - 1;
                while (array[index] >= array[swapWithIndex])
                {
                    swapWithIndex--;
                }

                // Swap i-th and j-th elements
                var tmp = array[index];
                array[index] = array[swapWithIndex];
                array[swapWithIndex] = tmp;

                Array.Reverse(array, index + 1, array.Length - index - 1);
                return true;
            }
        }

        // No more permutations
        return false;
    }
}


