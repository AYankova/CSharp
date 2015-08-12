//•	Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        string binNumber = Console.ReadLine();
        long decimalNum = 0;
        long power = binNumber.Length-1;

        for (int i = 0; i < binNumber.Length; i++)
        {
            decimalNum += long.Parse(binNumber[i].ToString()) * (long)Math.Pow(2, power);
            power--;
        }
        Console.WriteLine(decimalNum);
    }
}

