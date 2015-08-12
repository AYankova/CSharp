//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("Please enter integer 0<=N<=100:");
            int n = Int32.Parse(Console.ReadLine());
            BigInteger product1 = 1;//chislitel  na proizvedenieto
            BigInteger product2 = 1;//znamenatel na proizvedenieto

            for (int k=2; k <=n; k++)
            {
                product1 *= (n + k);
                product2 *= k;
            }
            Console.WriteLine(product1/product2);
        }
    }
}
