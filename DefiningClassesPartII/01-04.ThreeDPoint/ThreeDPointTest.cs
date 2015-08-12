namespace ThreeDPoint
{
    using System;
    using System.IO;

    class ThreeDPointTest
    {
        static void Main()
        {
            Point3D p1 = Point3D.ZeroPoint;
            Point3D p2 = new Point3D(1, 2, 3);
            Point3D p3 = new Point3D(1.1, 2.5, 3.4);

            Console.WriteLine("Zero point: {0}",p1);
            Console.WriteLine();
            Console.WriteLine("Distance between points ({0}) and ({1}) is {2:F3}:",p2,p3,DistanceCalculator.CalculateDistance(p2, p3));

            Path testPath = new Path();
            testPath.AddPoint(p1);
            testPath.AddPoint(p2);
            testPath.AddPoint(p3);
            PathStorage.SavePath(testPath, "test");

            testPath.RemovePoint(p1);
            PathStorage.SavePath(testPath, "test1");

            Path loadedPath = PathStorage.LoadPath("test");
            Console.WriteLine();
            Console.WriteLine("Loaded from file {0}",System.IO.Path.GetFullPath("test"));
            for (int i = 0; i < loadedPath.Points.Count; i++)
            {
                Console.WriteLine(loadedPath.Points[i]);  
            }
        }
    }
}
