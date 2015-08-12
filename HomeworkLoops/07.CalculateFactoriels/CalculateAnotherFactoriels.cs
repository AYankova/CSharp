//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;

namespace _07.CalculateFactoriels
{
    class CalculateAnotherFactoriels
    {
        static void Main()
        {
            Console.Write("Please enter integer N in the range (1..100):");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter integer K in the range (1..100):");
            int k = Int32.Parse(Console.ReadLine());
            BigInteger nFactDividedByKfact = 1;
            BigInteger nMinusKFact = 1;
            int nMinK=n-k;

            if (k > n)
            {
                Console.WriteLine("k can't be higher than n!");
            }
            else
            {
                while (n - k >= 1)
                {
                    nFactDividedByKfact *= n;
                    n--;
                }
                while (nMinK > 1)
                {
                    nMinusKFact *= nMinK;
                    nMinK--;
                }

                Console.WriteLine(nFactDividedByKfact / nMinusKFact);
            }
        }
    }
}
