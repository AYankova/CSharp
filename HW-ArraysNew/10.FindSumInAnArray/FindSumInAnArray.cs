//Write a program that finds in given array of integers a sequence of given sum S (if present).

//Example:

//array	               S	    result
//4,3,1,4,2,5,8	       11	    4, 2, 5

using System;

namespace _10.FindSumInAnArray
{
    class FindSumInAnArray
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];
            Console.WriteLine("Enter the sum S: ");
            int S=int.Parse(Console.ReadLine());

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }

            int sum = 0;
            int last = 0;
            int start = 0;
            bool isSuchSum = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    sum += numbers[j];

                    if (sum == S)
                    {
                        isSuchSum = true;
                        start = i;
                        last = j;
                        for (int k = start; k <= last; k++)//to print all the possible subsets
                        {
                            Console.Write(k != last ? numbers[k] + ", " : numbers[k] + "\n");
                        }
                    }
                }
                sum = 0;
            }
            if (!isSuchSum)
            {
                Console.WriteLine("No subset with the given sum!");
            }

            
            
        }
    }
}
