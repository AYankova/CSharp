//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the
//examples below. Use two nested loops.

using System;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Please enter integer 0<=N<=20:");
            int n = Int32.Parse(Console.ReadLine());
            if (n > 20)
            {
                Console.WriteLine("Not correct input!");
            }
            else
            {

                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j < i + n; j++)
                    {
                        Console.Write("{0,-3}", j);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
