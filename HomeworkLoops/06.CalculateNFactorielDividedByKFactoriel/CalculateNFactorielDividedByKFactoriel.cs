//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

namespace _06.CalculateNFactorielDividedByKFactoriel
{
    class CalculateNFactorielDividedByKFactoriel
    {
        static void Main()
        {
            Console.Write("Please enter integer N in the range (1..100):");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter integer K in the range (1..100):");
            int k = Int32.Parse(Console.ReadLine());
            int div = 1;
            if (k > n)
            {
                Console.WriteLine("k can't be higher than n!");
            }
            else
            {
                for (int i = k + 1; i <= n; i++)
                {
                    div *= i;

                }
                Console.WriteLine(div);
            }
        }
    }
}


