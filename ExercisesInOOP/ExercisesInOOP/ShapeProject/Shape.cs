using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProject
{
    public abstract class Shape
    {
        public abstract double Calculatesurface();
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
