//•	Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class BinaryShort
{
    static void Main()
    {
        Console.Write("Enter a number from type short-signed or unsigned: ");
        short number = short.Parse(Console.ReadLine());

        string binRepresent = string.Empty;
        for (int i = 15; i >= 0; i--)
        {
            binRepresent = ((number % 2) & 1) + binRepresent;
            number >>= 1;
        }

        Console.WriteLine(binRepresent);
    }
}
