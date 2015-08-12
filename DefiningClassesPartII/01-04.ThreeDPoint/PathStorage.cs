namespace ThreeDPoint
{
    using System;
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            using (StreamWriter sw = new StreamWriter(String.Format(@"..\..\{0}.txt", fileName)))
            {
                for (int i = 0; i < path.Points.Count; i++)
                {
                    sw.WriteLine(path.Points[i]);
                }
            }
        }

        public static Path LoadPath(string fileName)
        {
            Path path = new Path();
            string s;
            using (StreamReader reader = new StreamReader(String.Format(@"..\..\{0}.txt", fileName)))
            {
                string[] fields;
                s = reader.ReadLine();
                while (s != null)
                {
                    fields = s.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries);
                    path.AddPoint(new Point3D(double.Parse(fields[0]), double.Parse(fields[1]), double.Parse(fields[2])));
                    s = reader.ReadLine();
                }
            }
            return path;
        }
    }
}

