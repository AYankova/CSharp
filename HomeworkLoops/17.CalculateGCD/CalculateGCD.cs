//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

using System;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Please enter an integer a=");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter an integer b=");
            int b = Int32.Parse(Console.ReadLine());
            while (b!=0)
            {
                int remainder = b;
                b = a % b;
                a = remainder;
            }
            Console.WriteLine(a);
        }
    }
}
