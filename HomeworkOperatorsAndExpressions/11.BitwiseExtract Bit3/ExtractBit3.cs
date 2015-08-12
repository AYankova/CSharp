/*Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.*/

using System;

namespace BitwiseExtract_Bit3
{
    class ExtractBit3
    {
        static void Main()
        {
            Console.WriteLine("Plese enter an unsigned integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int p = 3;
            int mask = 1 << p;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> p;
            Console.WriteLine("The bit in position 3 is--->"+bit);

        }
    }
}

