/*Write a Boolean expression that returns if the bit at position p(counting from 0, starting from the right) 
in given integer number n, has value of 1.*/

using System;

namespace CheckABit
{
    class CheckABit
    {
        static void Main()
        {
            Console.WriteLine("Please insert an integer number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please insert the bit you want to extract:");
            int bitExtract = Convert.ToInt32(Console.ReadLine());
            int mask = 1 << bitExtract;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> bitExtract;
            bool isOne = true;
            if (bit == 1) Console.WriteLine(isOne);
            else Console.WriteLine(!isOne);
           

        }
    }
}
