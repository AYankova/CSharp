//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.RandomizeTheNumbers1ToN
{
    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            Console.Write("Enter an integer n: ");
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }
            while (numbers.Count > 0)
            {
                int randNum = rand.Next(0, numbers.Count);
                
                if (numbers.Count!=1)
                {
                    Console.Write(numbers[randNum]+" "); ;
                }
                else
                {
                    Console.Write(numbers[randNum]);
                }
                numbers.RemoveAt(randNum);
            }
            Console.WriteLine();
        }
    }
}