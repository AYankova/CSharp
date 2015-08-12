//•	Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//•	Use variable number of arguments.

using System;

class IntegerCalculations
{
    private static int[] MakeArr(string input)
    {
        string[] arrInput = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[arrInput.Length];
        numbers = new int[arrInput.Length];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = int.Parse(arrInput[index]);
        }
        return numbers;
    }
    enum Operations
    {
        operationSum,
        operationAverage,
        operationMax,
        operationMin,
        operationProduct
    }
    private static double Calculate(Operations calc,params int[]numbers )
    {
        int sum = numbers[0];
        int min = numbers[0];
        int max = numbers[0];
        double average = numbers[0];
        int product = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];
            if (max<numbers[i])
            {
                max = numbers[i];
            }
            if (min>numbers[i])
            {
                min = numbers[i];
            }
            
        }
        average = (double)sum /numbers.Length;

        switch (calc)
        {
            case Operations.operationSum:
                return sum;
            case Operations.operationAverage:
                return average;
            case Operations.operationMax:
                return max;
            case Operations.operationMin:
                return min;
            case Operations.operationProduct:
                return product;
            default: return 0;
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter the sequence of numbers, separated by commma or space:");
        string input = Console.ReadLine(); 

        int[] numbers=MakeArr(input);

        Console.WriteLine("Sum= "+Calculate(Operations.operationSum,numbers));
        Console.WriteLine("Average= {0:F3}",Calculate(Operations.operationAverage,numbers));
        Console.WriteLine("Min= "+Calculate(Operations.operationMin,numbers));
        Console.WriteLine("Max= "+Calculate(Operations.operationMax,numbers));
        Console.WriteLine("Product= "+Calculate(Operations.operationProduct,numbers));
    }
}

