//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

namespace _18.TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("Please enter an integer n: ");
            uint n = uint.Parse(Console.ReadLine());
            BigInteger fact = 1;
            int counter = 0;
            for (int i = 2; i <=n; i++)
            {
                fact *= i;
            }
            //Console.WriteLine(fact);
            while (fact > 0)
            {
                if (fact % 10 == 0)
                {
                    counter++;
                }
                else break;
                fact /= 10;
            }
            Console.WriteLine(counter);
        }
    }
}
