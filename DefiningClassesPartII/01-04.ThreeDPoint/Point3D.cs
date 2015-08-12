namespace ThreeDPoint
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D zeroPoint=new Point3D(0,0,0);

        public Point3D (double x,double y,double z):this()       
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D ZeroPoint
        {
            get { return zeroPoint; }
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}",this.X, this.Y, this.Z);
        }
    }
}
