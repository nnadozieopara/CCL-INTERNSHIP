using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Height = radius;
            Width = radius;
        }
        public override double Calculatesurface()
        {
            return Width * Height * Math.PI;
        }
        public double Radius
        {
            get { return Height; }
        }
    }
}
