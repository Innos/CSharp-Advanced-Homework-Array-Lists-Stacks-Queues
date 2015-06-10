using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Shapes.Shapes;
using _01Shapes.Interfaces;

namespace _01Shapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[] 
            {
                new Triangle(5,10),
                new Triangle(2.5,7.5),
                new Triangle(13.78,15.11),
                new Rectangle(5,10),
                new Rectangle(2.5,7.5),
                new Rectangle(13.78,15.11),
                new Circle(5),
                new Circle(7.5),
                new Circle(13.78)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Area: {0,-10:F2} Perimeter: {1,-10:F2}",shape.CalculateArea(),shape.CalculatePerimeter());
            }
        }
    }
}
