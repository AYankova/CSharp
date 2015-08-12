/*Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits 
after the decimal point.*/

using System;

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.Write("Please enter the radius: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * r;
            double area= Math.Pow(r,2)*Math.PI;
            Console.WriteLine("Perimeter of the circle is {0:F2} and the area is {1:F2}",perimeter,area);
        }
    }
}
