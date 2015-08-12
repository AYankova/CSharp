//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

namespace _13.MergeSort
{
    class MergeSort
    {
        static int[] numbers;
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numbers = new int[arrInput.Length];

            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = int.Parse(arrInput[index]);
            }


            int start = 0;
            int end = numbers.Length - 1;
            MergeSortMethod(start, end);

            Console.WriteLine();
            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(", ", numbers));
        }


        static void MergeSortMethod(int start, int end)
        {
            if (end - start < 1)
            {
                return;
            }
            else
            {
                int middle = start + (end - start) / 2;
                MergeSortMethod(start, middle);
                MergeSortMethod(middle + 1, end);

                int leftPos = start;
                int rightPos = middle + 1;
                int[] tempArr = new int[end - start + 1];
                int tempPos = 0;
                do
                {
                    if (numbers[leftPos] < numbers[rightPos])
                    {
                        tempArr[tempPos] = numbers[leftPos];
                        leftPos++;
                    }
                    else
                    {
                        tempArr[tempPos] = numbers[rightPos];
                        rightPos++;
                    }
                    tempPos++;
                } while (leftPos <= middle && rightPos <= end);

                for (int i = leftPos; i <= middle; i++)
                {
                    tempArr[tempPos] = numbers[i];
                    tempPos++;
                }
                for (int i = rightPos; i <= end; i++)
                {
                    tempArr[tempPos] = numbers[i];
                    tempPos++;
                }
                Array.Copy(tempArr, 0, numbers, start, tempArr.Length);

            }
        }
    }
}
   