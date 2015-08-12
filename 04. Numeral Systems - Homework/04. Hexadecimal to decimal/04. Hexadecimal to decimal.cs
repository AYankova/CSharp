//•	Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Numerics;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string input = Console.ReadLine().ToUpper();
        BigInteger result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            result*= 16;
            if (input[i] >= '0' && input[i] <= '9')
            {
                result+= (input[i] - 48);
            }
            else if (input[i] >= 'A' && input[i] <= 'F')
            {
                result+= (input[i] - 55);
            }
            else
            {
                throw new FormatException("invalid hexadecimal representation");
            }
                
        }
        Console.WriteLine("Decimal representation is "+ result);   
    }
}

