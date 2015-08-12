//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Input side a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input side b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input height h:");
            double h = Convert.ToDouble(Console.ReadLine());
            double area=((a+b)/2)*h;
            Console.WriteLine("The area is: "+area);

        }
    }
}
