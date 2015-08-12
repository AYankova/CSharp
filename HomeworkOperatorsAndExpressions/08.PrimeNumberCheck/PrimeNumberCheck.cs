/*Write an expression that checks if given positive integer number n (n = 100) is prime
(i.e. it is divisible without remainder only to itself and 1).*/

using System;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) Console.WriteLine("You must enter a positive integer!");
            else
            {
                int counterDiv = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        counterDiv++;
                    }
                }
                if (counterDiv == 2)
                {
                    Console.WriteLine("True -->Entered Number is a Prime Number ");
                }
                else
                {
                    Console.WriteLine("False -->Not a Prime Number");

                }

            }
        }
    }
}
