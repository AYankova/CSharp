//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max]

using System;

namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {

            Console.Write("Please enter integer n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter integer min value:");
            int min = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter integer max value:");
            int max = Int32.Parse(Console.ReadLine());
            Random rand = new Random();

            if (min==max)
            {
                Console.WriteLine("Min must be different from max!");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(rand.Next(min, max+1)+" ");
                   
                }
                Console.WriteLine();

            }

           
        }
    }
}
