//Write a program that finds the sequence of maximal sum in given array.

//Example:

//     input	                                             result
//     2,3,-6,-1,2,-1,6,4,-8,8	                             2, -1, 6, 4

using System;

namespace _08.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {

            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }

            int maxSum = int.MinValue;
            int sum =0;
            int last = 0;
            int start = 0;
            int first = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                sum+=numbers[j];
                if (maxSum<sum)
                {
                    maxSum = sum;
                    last = j;
                    first = start;
                }
                if (sum<=0)
                {
                    sum = 0;
                    start=j+1;
                }
            }
            Console.WriteLine("Elements with maximal sum:");
            for (int i = first; i <= last; i++)
            {
                Console.Write(i != last?numbers[i]+ ", " : numbers[i]+"\n");
            }

        }
    }
}
