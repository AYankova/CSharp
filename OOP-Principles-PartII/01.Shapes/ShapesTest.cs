namespace _01.Shapes
{
    using System;

    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Rectangle(3, 5.5),
                new Square(5),
                new Triangle(4.5, 5), 
                new Rectangle(6.5, 2),
                new Triangle(2.5, 4)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} area: {1}", shape.GetType().Name, shape.CalculateSurface());
            }

        }
    }
}
