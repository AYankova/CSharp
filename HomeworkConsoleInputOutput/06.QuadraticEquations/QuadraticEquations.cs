/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
and solves it (prints its real roots).*/

using System;
using System.Globalization;
using System.Threading;

namespace QuadraticEquations
{
    class QuadraticEquations
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Please enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Math.Pow(b, 2) - (4 * a * c);
            if (d < 0) Console.WriteLine("No real roots!");
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("The roots are: \n{0} \n{1}", x1, x2);

            }
        }
    }
}
