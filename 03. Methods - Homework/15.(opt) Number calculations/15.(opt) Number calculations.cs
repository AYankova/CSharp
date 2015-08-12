//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;

class NumberCalculations
{
    enum Operations
    {
        operationSum,
        operationAverage,
        operationMax,
        operationMin,
        operationProduct
    }
    private static T Calculate<T>(Operations calc, params T[] numbers) where T:IComparable
    {
        dynamic sum = numbers[0];
        T min = numbers[0];
        T max = numbers[0];
        dynamic average = numbers[0];
        dynamic product = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];
            if (max .CompareTo(numbers[i])>0)
            {
                max = numbers[i];
            }
            if (min.CompareTo(numbers[i])<0)
            {
                min = numbers[i];
            }

        }
        average = sum / numbers.Length;

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
            default: return min;
        }
    }

    static void Main()
    {
        //working with an example sequence, which consists of both integers and floating-point numbers
        //1, -2.5, 3, -4, 5.2, -6, 7

        Console.WriteLine("Sum= " + Calculate(Operations.operationSum, 1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("Average= {0:F3}", Calculate(Operations.operationAverage, 1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("Min= " + Calculate(Operations.operationMin, 1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("Max= " + Calculate(Operations.operationMax, 1, -2.5, 3, -4, 5.2, -6, 7));
        Console.WriteLine("Product= " + Calculate(Operations.operationProduct, 1, -2.5, 3, -4, 5.2, -6, 7));
    }
}

