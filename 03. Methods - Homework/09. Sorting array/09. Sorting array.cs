//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
{
    private static int[] MakeArray(string input)
    {
        string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[arrInput.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = int.Parse(arrInput[index]);
        }
        return numbers;
    }
    private static int MaxInteger(int[] arr,int index,int endIndex)
    {
        int max = index;
        for (int i = index+1; i <=endIndex; i++)
        {
            if (arr[max]<arr[i])
            {
                max = i;
            }
        }
        return max;
    }
    private static void Swap(int[] arr,int first,int second)
    {
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }
    private static int[] SortAscending(int[] arr)
    {
       for (int i = arr.Length - 1; i >= 0; i--)
            Swap(arr,i,MaxInteger(arr,0,i));

        return arr;
    }
    private static int[] SortDescending(int[] arr)
    {
         for (int i = 0; i < arr.Length; i++)
            Swap(arr, i, MaxInteger(arr,i,arr.Length-1));

        return arr;
    }
    static void Main()
    {
        Console.WriteLine("Enter the sequence of numbers, separated by comma or space:");
        string input = Console.ReadLine();
        int[] arr1 = MakeArray(input);

        Console.Write("Enter the index from which to start searching: ");
        int index = int.Parse(Console.ReadLine());
        if (index<0||index>=arr1.Length)
        {
            throw new ArgumentOutOfRangeException("index for searching", "out of range");
        }
        else
        {
            Console.WriteLine("Maximal number from index {0} is {1}",index,arr1[MaxInteger(arr1,index,arr1.Length-1)]);
        }

        Console.WriteLine("Sorted ascending:");
        Console.WriteLine(string.Join(", ",SortAscending(arr1)));
        Console.WriteLine("Sorted descending:");
        Console.WriteLine(string.Join(", ",SortDescending(arr1)));

    }
}
