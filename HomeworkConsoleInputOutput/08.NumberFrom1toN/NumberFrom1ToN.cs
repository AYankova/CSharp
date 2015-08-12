/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], 
each on a single line.*/

using System;

namespace NumberFrom1toN
{
    class NumberFrom1ToN
    {
        static void Main()
        {
            Console.Write("Please enter integer number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++) 
            {
                Console.WriteLine(i);
            }

        }
    }
}
