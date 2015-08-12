namespace ThreeDPoint
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> pointsList;

        public Path()
        {
            this.pointsList = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get { return this.pointsList; }
            set { this.pointsList = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.pointsList.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.pointsList.Remove(point);
        }

        public void ClearPath()
        {
            this.pointsList.Clear();
        }
    }
}
