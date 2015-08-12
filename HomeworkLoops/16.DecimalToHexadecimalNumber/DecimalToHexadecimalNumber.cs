//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Please enter a decimal number: ");
            long numberDec = long.Parse(Console.ReadLine());
            string resultHex = "";
            long result=0;
            
            while (numberDec > 0)
            {
                result = numberDec%16;
                if (result == 10)
                {
                    resultHex += "A";
                }
                else if (result == 11)
                {
                    resultHex += "B";
                }
                else if (result == 12)
                {
                    resultHex += "C";
                }
                else if (result == 13)
                {
                    resultHex += "D";
                }
                else if (result == 14)
                {
                    resultHex += "E";
                }
                else if (result == 15)
                {
                    resultHex += "F";
                }
                else resultHex += result;

                numberDec /= 16;
            }
            for (int i = resultHex.Length - 1; i >= 0; i--)
            {
                Console.Write(resultHex[i]);
            }
            Console.WriteLine();
        }
    }
}
