/*We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the 
binary representation of n while preserving all other bits in n.*/

using System;

namespace ModifyABit
{
    class ModifyABit
    {
        static void Main()
        {
            Console.WriteLine("Please insert an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the bit you want to extract:");
            int bitExtract = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the value you want to set (0 or 1):");
            int bitValue = Convert.ToInt32(Console.ReadLine());
            if (bitValue == 0)
            {
                int mask = ~(1 << bitExtract);
                int result = number & mask;
                Console.WriteLine("Result is "+result);
            }
            else
            {
                int mask = 1 << bitExtract;
                int result = number | mask;
                Console.WriteLine("Result is "+result);
            }
        }
    }
}

