//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest,
//move it at the second position, etc.

using System;

namespace _07.SelectionSort
{
    class SelectionSort
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
           
            for (int j = 0; j < numbers.Length - 1; j++)
            {
              
                int iMin = j;
               
                for (int i = j + 1; i < numbers.Length; i++)
                {
                   if (numbers[i] < numbers[iMin])
                    {
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    numbers[j]=numbers[j]+numbers[iMin];
                    numbers[iMin]=numbers[j]-numbers[iMin];
                    numbers[j]=numbers[j]-numbers[iMin];
                }

            }
            Console.WriteLine("Sorted array:");
            for (int start = 0; start < numbers.Length; start++)
            {
               Console.Write(start != numbers.Length - 1 ? numbers[start] + ", " :numbers[start] + "\n"); 
            }

            Main();
        }
    }
}
