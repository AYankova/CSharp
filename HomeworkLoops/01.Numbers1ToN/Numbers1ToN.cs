//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line,
//separated by a space.

using System;

namespace Numbers1ToN
{
    class Numbers1ToN
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number n: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");

            }
            Console.WriteLine();
        }
    }
}
