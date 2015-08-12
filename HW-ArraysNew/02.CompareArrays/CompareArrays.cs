//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int[] array1;
            int[] array2;

            Console.Write("Enter the length of the first array: ");
            int n = int.Parse(Console.ReadLine());
            array1 = new int[n];
            Console.Write("Enter the length of the second array: ");
            int m = int.Parse(Console.ReadLine());
            array2 = new int[m];
            bool areEqual = true;


            if (array1.Length > array2.Length)
            {
                Console.WriteLine("First array is bigger than the second.Not equal!");
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine("Second Array is bigger than the first.Not Equal!");
            }
            else
            {
                for (int index1 = 0; index1 <array1.Length; index1++)
                {
                    Console.Write("Enter numbers for the first array: ");
                    array1[index1] = int.Parse(Console.ReadLine());
                }
                for (int index2 = 0; index2 < array2.Length; index2++)
                {
                    Console.Write("Enter numbers for the second array: ");
                    array2[index2] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        Console.WriteLine("Elements {0} of the two arrays are equal!", i);

                    }
                    else
                    {
                        Console.WriteLine("Elements {0} of the two arrays are not equal!", i);
                        areEqual = false;
                    }
                }
                Console.WriteLine("Are the two arrays equal? {0} ", areEqual);
            }

        }
    }
}
