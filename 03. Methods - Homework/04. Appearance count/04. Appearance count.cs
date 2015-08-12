//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

//Example: 1, 2, 3, 4, 5, 8, 4, 1, 7, 4, 2, 9
//1->2times   4->3times and so on...

using System;

class AppearanceCount
{
    static int[] numbers;
    static int number;

    private static int OccurenceNumber(int[] numbers,int number)
    {
        int counter = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i]==number)
            {
                counter++;
            }
        }
        return counter;
    }
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

        Console.WriteLine("Enter the number to check how many time it presents in the array: ");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine("Number {0} has {1} ocurrence(s) in the array.",number,OccurenceNumber(numbers,number));

    }
}
