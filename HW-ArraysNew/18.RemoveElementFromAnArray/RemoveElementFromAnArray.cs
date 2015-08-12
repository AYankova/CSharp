//Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that 
//the remaining array is sorted in increasing order.
//Print the remaining sorted array.

//input	                                     result
//6,1,4,3,0,3,6,4,5               	         1, 3, 3, 4, 5

using System;
using System.Collections.Generic;

namespace _18.RemoveElementFromAnArray
{
    class RemoveElementFromAnArray
    {
        static int[] numbers;
        static int[] maxSubset = new int[1];

        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] strInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numbers = new int[strInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(strInput[index]);
            }

            List<int> subset = new List<int>(); 
            MakeSubset(0, subset);

            Console.WriteLine("Longest increasing sequence is:");
            Console.Write(string.Join(", ", maxSubset));
            Console.WriteLine();
        }

        static void MakeSubset(int index, List<int> subset)
        {
            int counter = subset.Count; 
            if (counter > 1 && subset[counter - 2] > subset[counter - 1])  
                return;                                        
            if (counter >= maxSubset.Length)
            {
                maxSubset = new int[counter];
                subset.CopyTo(maxSubset);
            }
            for (int i = index; i < numbers.Length; i++) 
            {
                subset.Add(numbers[i]);
                MakeSubset(i + 1, subset);
                subset.RemoveAt(subset.Count - 1); 
            }
        }
    }
}
