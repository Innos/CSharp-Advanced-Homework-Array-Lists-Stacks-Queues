namespace _03Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public delegate void OnOpenCellEventHandler(object sender, OnOpenCellEventArgs args);

    public class Cell
    {
        private static int openedCells = 0;

        private readonly Position position;

        private readonly List<Cell> neighbourCells;

        private char symbol;

        private bool isBomb;

        public Cell(int x, int y)
        {
            this.symbol = '?';
            this.position = new Position(x, y);
            this.neighbourCells = new List<Cell>();
        }

        public event OnOpenCellEventHandler OpenBomb;

        public event OnOpenCellEventHandler OpenNonBomb;

        public char Symbol
        {
            get
            {
                return this.symbol;
            }
        }

        public bool IsBomb
        {
            get
            {
                return this.isBomb;
            }
            set
            {
                this.isBomb = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.position;
            }
        }

        public override string ToString()
        {
            return this.Symbol.ToString();
        }

        public void OpenCell()
        {
            if (this.IsBomb)
            {
                this.symbol = '*';
                if (this.OpenBomb != null)
                {
                    this.OpenBomb(this, new OnOpenCellEventArgs(openedCells));
                }
            }
            else
            {
                int adjacentBombs = this.neighbourCells.Count(cell => cell.isBomb);
                this.symbol = char.Parse(adjacentBombs.ToString());
                openedCells++;
                if (openedCells == (Engine.BoardCols * Engine.BoardRows) - Engine.NumberOfBombs)
                {
                    if (this.OpenNonBomb != null)
                    {
                        this.OpenNonBomb(this, new OnOpenCellEventArgs(openedCells));
                    }
                }
            }
        }

        public void Initialize()
        {
            this.GetNeighbours();
            openedCells = 0;
        }

        private void GetNeighbours()
        {
            for (int positionX = this.Position.X - 1; positionX <= this.Position.X + 1; positionX++)
            {
                for (int positionY = this.Position.Y - 1; positionY <= this.Position.Y + 1; positionY++)
                {
                    if (positionX >= 0
                        && positionX < Engine.BoardRows
                        && positionY >= 0
                        && positionY < Engine.BoardCols
                        && (this.Position.X != positionX || this.Position.Y != positionY))
                    {
                        this.neighbourCells.Add(Engine.Field[positionX, positionY]);
                    }
                }
            }
        }

    }
}
