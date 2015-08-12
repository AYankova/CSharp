//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {

            Console.Write("Please enter a binary number: ");
            string numberBin = Console.ReadLine();
            long resultDec=0;

            for (int i = 0; i < numberBin.Length; i++)
            {
                resultDec += (long.Parse(numberBin[numberBin.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
            }
            Console.WriteLine("Decimal number: "+resultDec);
        }
    }
}
