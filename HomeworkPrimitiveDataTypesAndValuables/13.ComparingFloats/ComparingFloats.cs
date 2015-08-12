//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double eps = 0.000001;

            Console.WriteLine("Input first number:");
            double inputFirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input second number:");
            double inputSecondNumber = Convert.ToDouble(Console.ReadLine());
            double comparison = Math.Abs(inputFirstNumber - inputSecondNumber);
            if (comparison < eps) Console.WriteLine("Numbers are equal!");
            else Console.WriteLine("Numbers aren't equal!");


        }
    }
}

