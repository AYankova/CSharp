//•	Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter hex number: ");
        string hexNumber = Console.ReadLine().ToUpper();
        StringBuilder binRepresentation = new StringBuilder();

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0': binRepresentation.Append("0000"); break;
                case '1': binRepresentation.Append("0001"); break;
                case '2': binRepresentation.Append("0010"); break;
                case '3': binRepresentation.Append("0011"); break;
                case '4': binRepresentation.Append("0100"); break;
                case '5': binRepresentation.Append("0101"); break;
                case '6': binRepresentation.Append("0110"); break;
                case '7': binRepresentation.Append("0111"); break;
                case '8': binRepresentation.Append("1000"); break;
                case '9': binRepresentation.Append("1001"); break;
                case 'A': binRepresentation.Append("1010"); break;
                case 'B': binRepresentation.Append("1011"); break;
                case 'C': binRepresentation.Append("1100"); break;
                case 'D': binRepresentation.Append("1101"); break;
                case 'E': binRepresentation.Append("1110"); break;
                case 'F': binRepresentation.Append("1111"); break;
                default: Console.WriteLine("Invalid input!"); break;
            }
        }

        Console.WriteLine("Binary Representation of the hexadecimal number {0} is",hexNumber);
        Console.WriteLine(binRepresentation.ToString());
    }
}

