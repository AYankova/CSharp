//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;

namespace _14.QuickSort
{
    class QuickSort
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

            QuickSortMethod(numbers, 0, numbers.Length - 1);
            Console.WriteLine();
            Console.WriteLine("After sorting: ");
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static void QuickSortMethod(int[] numbers, int left, int right)
        {
            int i = left, j = right;
            int pivot = numbers[(left + right) / 2];

            while (i <= j)
            {
                while (numbers[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (numbers[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = tmp;
                    i++;
                    j--;
                }
            }
            if (left < j)
            {
                QuickSortMethod(numbers, left, j);
            }
            if (i < right)
            {
                QuickSortMethod(numbers, i, right);
            }
        }
    }
}
