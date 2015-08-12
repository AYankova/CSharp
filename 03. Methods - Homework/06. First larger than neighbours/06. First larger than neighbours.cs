//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, 
//if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
{
    static int[] numbers;
    static int position;

    private static bool LargerThanNeighboursMethod(int[] numbers, int position)
    {
        bool larger = false;
        if ((position > 0 && position < numbers.Length - 1 && numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
            || (position == 0 && numbers[position] > numbers[position + 1])
            || (position == numbers.Length - 1 && numbers[position] > numbers[position - 1]))
        {
            larger = true;
        }
        return larger;
    }
    private static int FindFirstBiggest(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (LargerThanNeighboursMethod(numbers, i))
            {
                return i;
            }
        }
        return -1;    
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

        int position = FindFirstBiggest(numbers);
        if (position== -1)
        {
            Console.WriteLine("No element bigger than its neighbors.");
        }
        else
        {
            Console.WriteLine("First element bigger than its neighbors is {0} (index {1}).", numbers[position], position);
        }

    }
}
