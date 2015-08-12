//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

//input array	         S	   result
//2,1,2,4,3,5,2,6	    14	   yes

using System;
using System.Collections.Generic;

namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {

        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] strInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[strInput.Length];
            Console.WriteLine("Enter the sum S: ");
            int S = int.Parse(Console.ReadLine());
            bool anySubsets = false;
            List<int> subset = new List<int>();

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(strInput[index]);
            }

            int maxSubsets = (int)Math.Pow(2, numbers.Length) - 1;
            int counter = 0;

               for (int i = 1; i <= maxSubsets; i++)
               {
           
                long tempSum = 0;
                for (int j = 0; j <= numbers.Length; j++)
                {
                    int mask = 1 << j;
                    int numbersAndMask = i & mask;
                    int bit = numbersAndMask >> j;
                    if (bit == 1)
                    {
                        tempSum = tempSum + numbers[j];
                        subset.Add(numbers[j]);
                    }
                }
                    if (tempSum == S)
                    {
                        anySubsets = true;
                        counter++;
                    }
                
               }
               
                if (!anySubsets) 
                {
                    Console.WriteLine("No subset with sum {0}!", S);
                }
                else
                {
                    Console.WriteLine("Yes!{0} subsets with sum {1}",counter,S);
                    
			   }
        }
    }
}




