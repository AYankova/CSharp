/*Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the 
reminder of the division by 5 is 0.*/

using System;

namespace NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main()
        {
            Console.Write("Please enter integer number n: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Please enter integer number m: ");
            uint m = Convert.ToUInt32(Console.ReadLine());
            uint counter = 0;
            for (uint i = n; i <= m; i++)
            {
                if (i % 5 == 0)
                {
                    counter += 1;
                    Console.Write(i + " ");
                }
            }   
            
            Console.WriteLine("\nNumbers divisible to 5 are: "+counter);
        }
    }
}
