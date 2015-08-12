//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Please enter a hexadecimal number: ");
            string numberHex = Console.ReadLine();
            long resultDec = 0;
            for (int i = 0; i < numberHex.Length; i++)
            {
                 switch (numberHex[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                        resultDec += (long.Parse(numberHex[i].ToString())) * (long)Math.Pow(16,numberHex.Length-1- i);
                        break;  
                case 'A':
                    resultDec += 10 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'B':
                    resultDec += 11 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'C':
                    resultDec += 12 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'D':
                    resultDec += 13 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'E':
                    resultDec += 14 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
                case 'F':
                    resultDec += 15 * (long)Math.Pow(16, numberHex.Length - 1 - i);
                    break;
            }
        }
            Console.WriteLine("Decimal number is: {0}", resultDec);
    }
    }
}
