//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            Console.Write("Enter some text: ");
            char[] arr1 = Console.ReadLine().ToCharArray();
            Console.Write("Enter text to compare with the first one: ");
            char[] arr2 = Console.ReadLine().ToCharArray();
            bool areEqual = true;

            if (arr1.Length != arr2.Length)
            {
                Console.WriteLine("Not Equal!Different length!");
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        areEqual = false;
                    }
                }
                Console.WriteLine("Are the two arrays equal? {0}", areEqual);

            }

        }
    }
}
