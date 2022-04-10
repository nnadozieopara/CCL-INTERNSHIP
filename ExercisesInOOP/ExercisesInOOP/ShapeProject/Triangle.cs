using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public class Triangle : Shape
    {
        public Triangle(double triangleBase, double triangleWidth)
        {
            Width = triangleWidth;
            Height = triangleWidth;
        }
        public override double Calculatesurface()
        {
            return 0.5 * Width * Height;
        }
    }
}
