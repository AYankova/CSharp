//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i]contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class NumberAsArray
{
    private static int[] MakeArray(string input)
    {
        int[] arr = new int[input.Length];

        for (int index = 0; index < input.Length; index++)
        {
            arr[index] = input[input.Length - index - 1] - '0';
            if (arr[index] > 9 || arr[index] < 0)
                return new int[0];
        }
        return arr;
    }
    private static List<int> MakeSum(int[] arr1,int[] arr2)
    {
        List<int> result = new List<int>(Math.Max(arr1.Length, arr2.Length));

        int extra = 0;

        for (int i = 0; i < result.Capacity; i++)
        {
            int num = (i < arr1.Length ? arr1[i] : 0) + (i < arr2.Length ? arr2[i] : 0) + extra;
            extra = num / 10;
            result.Add(num % 10);
        }
        if (extra > 0) result.Add(extra);

        return result;
    }
    private static void PrintResult(List<int> result)
    {
        if (result.Count == 0)
            Console.Write(0);
        for (int i = result.Count - 1; i >= 0; i--)
            Console.Write(result[i]);
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter first positive number: ");
        string input1 = Console.ReadLine();
        int[] firstNum=MakeArray(input1);
        if (firstNum.Length==0)
        {
            throw new FormatException("The number must be positive and contain only digits.");
        }
        
        Console.Write("Enter second positive number: ");
        string input2 = Console.ReadLine();
        int[] secondNum=MakeArray(input2);
        if (secondNum.Length==0)
        {
            throw new FormatException("The number must be positive and contain only digits.");
        }

        List<int> result = MakeSum(firstNum, secondNum);
        Console.Write("Sum is: ");
        PrintResult(result);

    }
}

