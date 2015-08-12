/*Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of 
the rectangle R(top=1, left=-1, width=6, height=2)*/

using System;

namespace PointInAndOut
{
    class PointInAndOut
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Input coordinate x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input coordinate y:");
            double y = Convert.ToDouble(Console.ReadLine());
            double r=1.5;
            bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= (r*r);
            bool outRectangle = ((x < -1) || (x > 5) || (y > 1) || (y < -1));
            if (inCircle && outRectangle) Console.WriteLine("Yes");
            else Console.WriteLine("No");





        }
    }
}
