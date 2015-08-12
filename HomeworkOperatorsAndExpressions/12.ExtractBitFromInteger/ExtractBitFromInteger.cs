//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.WriteLine("Please insert an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the bit you want to extract:");
            int bitExtract = Convert.ToInt32(Console.ReadLine());
            int mask=1<<bitExtract;
            int numberAndMask = number & mask;
            int bit=numberAndMask>>bitExtract;
            Console.WriteLine("Bit in position {0} of the integer {1} is --> {2} ",bitExtract, number, bit);

        }
    }
}
