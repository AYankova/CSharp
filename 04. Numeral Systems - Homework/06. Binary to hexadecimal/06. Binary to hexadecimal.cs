//•	Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Text;

class BinaryToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string binNum = Console.ReadLine().ToUpper();

        if (binNum.Length % 4 > 0)
        {
            string leadingZeros = new string('0', (4 - binNum.Length % 4));
            binNum = leadingZeros + binNum;
        }

        StringBuilder hexNumber = new StringBuilder();

        for (int i = 0; i < binNum.Length; i += 4)
        {
            string digit = string.Empty; ;

            for (int j = i; j < i + 4; j++)
            {
                digit += binNum[j];
            }

            switch (digit)
            {
                case "0000": hexNumber.Append("0"); break;
                case "0001": hexNumber.Append("1"); break;
                case "0010": hexNumber.Append("2"); break;
                case "0011": hexNumber.Append("3"); break;
                case "0100": hexNumber.Append("4"); break;
                case "0101": hexNumber.Append("5"); break;
                case "0110": hexNumber.Append("6"); break;
                case "0111": hexNumber.Append("7"); break;
                case "1000": hexNumber.Append("8"); break;
                case "1001": hexNumber.Append("9"); break;
                case "1010": hexNumber.Append("A"); break;
                case "1011": hexNumber.Append("B"); break;
                case "1100": hexNumber.Append("C"); break;
                case "1101": hexNumber.Append("D"); break;
                case "1110": hexNumber.Append("E"); break;
                case "1111": hexNumber.Append("F"); break;
            }
        }
        Console.WriteLine("Hexadecimal representation is: ");
        Console.WriteLine(hexNumber.ToString());
    }
}

