using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Shapes.Interfaces;

namespace _01Shapes.Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Radius cannot be negative or 0");
                }
                this.radius = value;
            }
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
