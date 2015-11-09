namespace _03KnightTour
{
    using System;

    public class KnightTour
    {
        private static readonly int[] RowChanges = { 1, -1, 2, 1, -1, -2, 2, -2 };

        private static readonly int[] ColChanges = { 2, 2, 1, -2, -2, 1, -1, -1 };

        private static int[,] matrix;

        private static int size;

        private static int currentMove;

        public static void Main(string[] args)
        {
            size = int.Parse(Console.ReadLine());
            matrix = new int[size, size];

            matrix[0, 0] = 1;
            currentMove = 2;

            int row = 0;
            int col = 0;
            int roof = size * size;

            while (currentMove <= roof)
            {
                int minRow = 0;
                int minCol = 0;
                int min = int.MaxValue;

                // get the possible moves for every possible position and sets the minRow and minCol to those of the best position
                for (int i = 0; i < RowChanges.Length; i++)
                {
                    int currentMin = GetMoves(row + RowChanges[i], col + ColChanges[i]);
                    if (currentMin < min)
                    {
                        min = currentMin;
                        minRow = row + RowChanges[i];
                        minCol = col + ColChanges[i];
                    }
                }
           
                row = minRow;
                col = minCol;

                // makes the move
                matrix[row, col] = currentMove;
                currentMove++;
            }

            Print();       
        }

        // validation
        private static bool IsViableLocation(int row, int col)
        {
            if (row < 0 || row >= size || col < 0 || col >= size)
            {
                return false;
            }

            if (matrix[row, col] != 0)
            {
                return false;
            }

            return true;
        }

        // checks for the amount of viable moves that can be made from given position
        private static int GetMoves(int row, int col)
        {
            if (!IsViableLocation(row, col))
            {
                return int.MaxValue;
            }

            int moves = 0;

            for (int i = 0; i < RowChanges.Length; i++)
            {
                if (IsViableLocation(row + RowChanges[i], col + ColChanges[i]))
                {
                    moves++;
                }
            }

            return moves;
        }

        private static void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("{0,5}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
