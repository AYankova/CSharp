//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm

using System;
using System.Collections.Generic;

namespace _15.PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            bool[] primes = new bool[10000000];


            for (int j = 2; j < Math.Sqrt(10000000); j++)
            {
                if (primes[j] == false)
                {


                    for (int k = j * j; k <= 10000000; k += j)
                    {
                        primes[j] = true;
                    }
                }

                for (int i = 2; i < primes.Length; i++)
                {
                    if (!primes[i]) Console.Write(i + " ");
                }
            }
        }
    }
}
