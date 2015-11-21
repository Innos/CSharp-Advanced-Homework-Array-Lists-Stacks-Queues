namespace _02RectangleIntersection
{
    using System;

    public class Rectangle : IComparable<Rectangle>
    {
        public Rectangle(int minX, int maxX,int minY, int maxY)
        {
            this.MinX = minX;
            this.MaxX = maxX;
            this.MinY = minY;
            this.MaxY = maxY;
        }

        public int MinX { get; private set; }

        public int MaxX { get; private set; }

        public int MinY { get; private set; }

        public int MaxY { get; private set; }

        public int CompareTo(Rectangle other)
        {
            return this.MinY.CompareTo(other.MinY);
        }
    }
}
