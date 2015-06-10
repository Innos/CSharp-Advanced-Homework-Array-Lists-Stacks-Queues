using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01Shapes.Interfaces;

namespace _01Shapes.Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Width cannot be negative or 0");
                }
                this.width = value;
            }         
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Height cannot be negative or 0");
                }
                this.height = value;
            }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
