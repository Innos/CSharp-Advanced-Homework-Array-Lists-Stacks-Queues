namespace MatrixTraversal
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public class RotatingMatrixTraversal
    {
        private static Point? GetNewDirection(int[,] matrix, int row, int col, Point direction)
        {
            List<Point> directions =
                new List<Point>()
                {
                    new Point(1, 1), new Point(1, 0), new Point(1, -1), new Point(0, -1), new Point(-1, -1),
                    new Point(-1, 0), new Point(-1, 1), new Point(0, 1)
                };

            int rowChange = direction.X;
            int colChange = direction.Y;
            int count = directions.IndexOf(direction);

            for (int i = 0; i < directions.Count; i++)
            {
                if (row + rowChange >= matrix.GetLength(0) ||
                    row + rowChange < 0 ||
                    col + colChange >= matrix.GetLength(1) ||
                    col + colChange < 0 ||
                    matrix[row + rowChange, col + colChange] != 0)
                {
                    count++;
                    if (count == directions.Count)
                    {
                        count = 0;
                    }
                    rowChange = directions[count].X;
                    colChange = directions[count].Y;
                }
                else
                {
                    return new Point(rowChange, colChange);
                }
            }
            return null;
        }

        private static Point? FindNewStartingCell(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] == 0)
                    {
                        return new Point(rows, cols);
                    }
                }
            }
            return null;
        }

        private static void TraverseMatrix(int[,] matrix)
        {
            int cellValue = 1;
            int row = 0;
            int col = 0;
            int rowChange = 1;
            int colChange = 1;

            for (int i = 1; i <= matrix.Length; i++)
            {
                matrix[row, col] = cellValue;

                Point? newDirection = GetNewDirection(matrix, row, col, new Point(rowChange, colChange));
                if (newDirection.HasValue)
                {
                    rowChange = newDirection.Value.X;
                    colChange = newDirection.Value.Y;
                    row += rowChange;
                    col += colChange;
                }
                else
                {
                    //If no neighbouring cells are viable for traversing find a new starting cell
                    Point? newStartingCell = FindNewStartingCell(matrix);
                    if (newStartingCell.HasValue)
                    {
                        row = newStartingCell.Value.X;
                        col = newStartingCell.Value.Y;
                        rowChange = 1;
                        colChange = 1;
                    }
                }

                cellValue++;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0,5}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            Console.WriteLine("Enter a positive number:");
            string input = Console.ReadLine();
            int n;
            bool isWrongNumber = (!int.TryParse(input, out n) || n < 1 || n > 100);
            if (isWrongNumber)
            {
                Console.WriteLine("You haven't entered a correct positive number!");
                return;
            }

            int[,] matrix = new int[n, n];
            TraverseMatrix(matrix);
            PrintMatrix(matrix);
        }
    }
}
