//•	Write a program to convert from any numeral system of given base s to any other 
//  numeral system of base d (2 ≤s, d ≤ 16).

using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{

    static void Main()
    {
        List<char> numbers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', 
                                                  '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        Console.Write("Enter source base: ");
        byte sourceBase = byte.Parse(Console.ReadLine());
        Console.Write("Enter destination base: ");
        byte destBase = byte.Parse(Console.ReadLine());
        Console.Write("Enter the number to convert: ");
        string input = Console.ReadLine().ToUpper();

        long convertToDec = 0;
        for (int i = 0; i < input.Length; i++)
        {
            convertToDec = convertToDec * sourceBase;
            byte tmp = (byte)numbers.IndexOf(input[i]);
            if (tmp > sourceBase)
            {
               throw new ArgumentException("incorrect input");
            }
            convertToDec = convertToDec + (long)tmp;
        }

        string output = string.Empty;
        while (convertToDec > 0)
        {
            output = numbers[(int)(convertToDec % destBase)] + output;
            convertToDec = convertToDec / destBase;
        }
        Console.WriteLine("{0} in base {1} is {2} in base {3}",input,sourceBase,output,destBase);
    }
}

