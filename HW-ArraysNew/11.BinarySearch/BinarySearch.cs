//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];
            Console.Write("Enter the number we are looking for: ");
            int target = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arrInput[i]);
            }

            Array.Sort(numbers);
            Console.WriteLine("Sorted array ascending: ");
            Console.WriteLine(string.Join(", ", numbers));


            int start = 0; int mid = 0;
            int end = numbers.Length - 1;
            bool isFound = false;

            while (start <= end)
            {
                mid = (start + end) / 2;
                if (target < numbers[mid])
                {
                    end = mid - 1;
                }
                else if (target > numbers[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    isFound = true;
                    Console.WriteLine("Target " + target + " was found at index " + mid);
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Number {0} not found!", target);
            }


        }
    }
}


 
//  Sorting Descending Array
      
 /*
 using System;

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
            string input = Console.ReadLine();
            string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[arrInput.Length];
            Console.Write("Enter the number we are looking for: ");
            int target=int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(arrInput[i]);
            }

            Array.Sort(numbers);
            int[] descendingNumbersSort = new int[numbers.Length];
            int index = numbers.Length - 1;  

            for (int j = 0; j <numbers.Length; j++)
            {
                descendingNumbersSort[index]=numbers[j];
                index--;
            }

            Console.WriteLine("Sorted array descending: ");
            Console.WriteLine(string.Join(", ", descendingNumbersSort));
        
            int start = 0; int mid = 0;
            int end = numbers.Length-1;
            bool isFound = false;

            while (start <= end)
            {
                mid = (start+end) / 2;
                if (target < descendingNumbersSort[mid])
                { 
                    start = mid + 1;
                }
                else if (target > descendingNumbersSort[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    isFound = true;
                    Console.WriteLine("Target " + target + " was found at index " + mid);
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("Number {0} not found!", target);
            }
        }
    }
}
 */
