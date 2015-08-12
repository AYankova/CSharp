//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

namespace PointACircle
{
    class PointACircle
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Enter the abzisse value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the ordinate value: ");
            double y = Convert.ToDouble(Console.ReadLine());
            int r=2;
            bool isInTheCircle=(((x*x)+(y*y))<=r*r);
            Console.WriteLine(isInTheCircle);
        }
    }
}
