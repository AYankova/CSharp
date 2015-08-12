/*Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("Please enter integer number n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int first=0;
            int second = 1;
            int sum = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ",first);
                first = second;
                second = sum;
                sum = first + second;
                
            }
        }
    }
}
