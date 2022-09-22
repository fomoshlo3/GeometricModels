using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geom.Con
{
    public class Cylinder : Circle
    {
        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Cylinder(double radius, double height) : base(radius)
        {
            Height = height;
        }

        public double CalculateVolume()
        {
            double area = Area;
            return area * _height;
        }
    }
}
