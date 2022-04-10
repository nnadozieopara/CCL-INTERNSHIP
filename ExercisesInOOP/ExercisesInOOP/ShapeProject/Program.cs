using System;

namespace ShapeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = { new Circle(5.5), new Rectangle(3, 5), new Triangle(6,78) };
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(myShapes[i].Calculatesurface());  
            }
        }
    }
}
