namespace _03Game
{
    #region

    using System;

    #endregion

    public struct Position
    {
        private int x;

        private int y;

        public Position(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }

            set
            {
                if (value < 0 || value >= Engine.BoardRows)
                {
                    throw new ArgumentOutOfRangeException(
                        "position X", 
                        "Position X cannot be outside of the playing field.");
                }

                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                if (value < 0 || value >= Engine.BoardCols)
                {
                    throw new ArgumentOutOfRangeException(
                        "position Y", 
                        "Position Y cannot be outside of the playing field.");
                }

                this.y = value;
            }
        }
    }
}