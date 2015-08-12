//•	Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long number = long.Parse(Console.ReadLine());

        string binRepresentation = "";

        if (number < 0)
        {
            number = number ^ long.MinValue;
        }
            while (number != 0)
            {
                long bit = number % 2;
                binRepresentation = bit + binRepresentation;
                number /= 2;
            }

        Console.WriteLine(binRepresentation);
    }
}
