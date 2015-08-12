//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Console.WriteLine("Please input the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the height of the rectangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = width * height;
            double perimeter = 2*(width + height);
            Console.WriteLine("The area of the rectangle is: "+area +"\nThe perimeter of the rectangle is: "+perimeter);
        }
    }
}
