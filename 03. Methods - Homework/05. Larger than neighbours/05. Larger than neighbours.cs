//	Write a method that checks if the element at given position in given array of integers is larger than 
//  its two neighbours (when such exist).

using System;

class LargerThanNeighbours
{
    static int[] numbers;
    static int position;

    private static bool LargerThanNeighboursMethod(int[] numbers,int position)
    {
        bool larger = false;
        if ((position >0 && position<numbers.Length-1 && numbers[position] > numbers[position - 1] && numbers[position] > numbers[position + 1])
            ||(position==0 && numbers[position] > numbers[position + 1])
            ||(position==numbers.Length-1 && numbers[position] > numbers[position - 1] ))
        {
            larger=true;
        }
        return larger;
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

        Console.WriteLine("Enter the position: ");
        position = int.Parse(Console.ReadLine());

        if (position<0||position>=numbers.Length)
        {
            throw new ArgumentOutOfRangeException("position","out of the range of the array");
        }
        else
        {
            Console.WriteLine(LargerThanNeighboursMethod(numbers, position));
        }
        Main();
    }
}

