//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of 
//them using the method GetMax()

using System;

class GetLargestNumber
{
    private static int MaxNumber(int a,int b)
    {
        if (a>=b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        int max = MaxNumber(MaxNumber(first, second), third);
        Console.WriteLine("The maximal number is {0}",max);
    }
}

