// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the 
// array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter size of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}] of the array:",i);
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter value for k: ");
        int k = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Your array: ");
        Console.WriteLine(string.Join(", ", arr));

        Array.Sort(arr);
        Console.WriteLine("Sorted array: ");
        Console.WriteLine(string.Join(", ", arr));

        int position = Array.BinarySearch(arr, k);

        if (position>=0)
        {
            Console.WriteLine("Largest number, smaller or equal to {0} is {1}",k,arr[position]);
        }
        else if (position==-1)
        {
            Console.WriteLine("No such element smaller or equal to {0} in the array!",k);
        }
        else
        {
            position = Math.Abs(position + 2);
            Console.WriteLine("Largest number, smaller or equal to {0} is {1}", k, arr[position]);
        }
        

    }
}

