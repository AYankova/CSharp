using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    public class Cylinder:Figure,IAreaMeasurable,IVolumeMeasurable
    {
        
        public Cylinder(Vector3D bottom, Vector3D top, double radius)
        {
            // TODO: Complete member initialization
            this.Bottom = bottom;
            this.Top = top;
            this.Radius = radius;
        }
        
        private Vector3D Bottom
            {
            get
            {
                return new Vector3D(this.vertices[1].X, this.vertices[1].Y, this.vertices[1].Z);
            }
            set
            {
                this.vertices[1] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        private Vector3D Top
              {
            get
            {
                return new Vector3D(this.vertices[0].X, this.vertices[0].Y, this.vertices[0].Z);
            }
           set
            {
                this.vertices[0] = new Vector3D(value.X, value.Y, value.Z);
            }
        }

        private double Radius { get; set; }

        public double GetVolume()
        {
            return this.Radius * this.Radius * Math.PI * (this.Top - this.Bottom).Magnitude;
        }

        public double GetArea()
        {
            double baseArea = this.Radius * this.Radius * Math.PI;
            double topAndBottomArea = baseArea * 2;

            double basePerimeter = 2 * Math.PI * this.Radius;

            double sideArea = basePerimeter * (this.Top - this.Bottom).Magnitude;

            return sideArea + topAndBottomArea;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}
