//•	Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter positive decimal number: ");
        ulong input = ulong.Parse(Console.ReadLine());
        string s = string.Empty;
        ulong tempInput = input;
        ulong temp = 0; 
        while (tempInput > 0)
        {
            temp = tempInput % 16;
            if (temp < 10)
               s+=temp;
            else
             s+=(char)(temp + 55);
            tempInput /= 16;
        }
        Console.WriteLine("Hexadecimal representation is :");
        for (int i = s.Length-1; i>=0; i--)
        {
            Console.Write(s[i]);
        }
        Console.WriteLine();

        //string result = number.ToString("X");
       // Console.WriteLine("Hexadecimal representation of number {0} is {1:x}", number, result);
    }
}

