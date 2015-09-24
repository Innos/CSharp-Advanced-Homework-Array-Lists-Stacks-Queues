namespace _06ConnectedAreasInAMatrix
{
    using System;

    public class ConnectedArea : IComparable<ConnectedArea>
    {
        public ConnectedArea(int x, int y, int size)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public int Size { get; private set; }

        public int CompareTo(ConnectedArea other)
        {
            int result = other.Size.CompareTo(this.Size);
            if (result == 0)
            {
                result = this.X.CompareTo(other.X);
            }

            if (result == 0)
            {
                result = this.Y.CompareTo(other.Y);
            }

            return result;
        }
    }
}
