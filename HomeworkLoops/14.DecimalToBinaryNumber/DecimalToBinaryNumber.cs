//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            string numberDecStr = Console.ReadLine();
            long numberDec = long.Parse(numberDecStr);
            string numberBinReversed = "";

            while (numberDec > 0)
            {
                numberBinReversed += numberDec % 2;
                numberDec /= 2;
            }
            for (int i = numberBinReversed.Length - 1; i >= 0; i--)
            {
                Console.Write(numberBinReversed[i]);
            }
            Console.WriteLine();

        }
    }
}

