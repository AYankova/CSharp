//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

namespace _05.CalculateFactoriels
{
    class CalculateFactoriels
    {
        static void Main()
        {
            Console.Write( "Please enter integer N:");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter integer X:");
            int x = Int32.Parse(Console.ReadLine());
            decimal sum=1;
            int fact=1;
            for (int i = 1; i <= n; i++)
            {
                fact*=i;
                sum+=(decimal) fact/(decimal) Math.Pow(x,i); 
            }
            Console.WriteLine("Sum is {0:F5}",sum);
        }
    }
}
