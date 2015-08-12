//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

namespace _17.SubsetKWithGivenSumS
{
    class SubsetKWithGivenSumS
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] strInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[strInput.Length];
            Console.WriteLine("Enter the sum S: ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter number of elements in subset: ");
            int k = int.Parse(Console.ReadLine());
          
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(strInput[index]);
            }

            int[] temp = new int[k];
            for (int i = 0; i < k; i++)
                temp[i] = i;
            int start = k - 1;
            bool foundSubset = false;
            do
            {
                int sum = 0;
                for (int i = 0; i < k; i++)
                    sum = sum + numbers[temp[i]];
                if (sum == s)
                {
                    for (int i = 0; i < k; i++)
                        Console.Write(numbers[temp[i]]+" ");
                    Console.WriteLine();
                    foundSubset = true;
                }
                temp[k - 1]++;
                if (temp[k - 1] >= numbers.Length)
                {
                    while ((start >= 0) && (temp[start] > numbers.Length - (k - start) - 1))
                        start--;
                    if (start >= 0)
                    {
                        temp[start]++;
                        for (int i = start; i < temp.Length - 1; i++)
                            temp[i + 1] = temp[i] + 1;
                    }
                }
            } while (start > -1);

            if (!foundSubset) Console.WriteLine("No subset with sum {0}!", s);
        }
    }
}
