namespace Matrix
{
    using System;
    using System.Linq;

    class WalkInMatrica
    {
        static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;

            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }

            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }
        static bool FindUnvisitedNeighbouringCell(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < dirX.Length; i++)
            {
                if (x + dirX[i] < arr.GetLength(0) &&
                    x + dirX[i] >= 0 &&
                    y + dirY[i] < arr.GetLength(1) &&
                    y + dirY[i] >= 0 &&
                    arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        static void FindNewStartingCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr.GetLength(1); cols++)
                {
                    if (arr[rows, cols] == 0)
                    {
                        x = rows;
                        y = cols;
                        return;
                    }
                }

            }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //}

            int n = 6;
            int[,] matrix = new int[n, n];
            int cellValue = 1;
            int row = 0;
            int col = 0;
            int rowChange = 1;
            int colChange = 1;
            matrix[row, col] = cellValue;
            int maxValue = n * n;

            while (cellValue < maxValue)
            {
                if (FindUnvisitedNeighbouringCell(matrix, row, col))
                {
                    while (row + rowChange >= n ||
                            row + rowChange < 0 ||
                            col + colChange >= n ||
                            col + colChange < 0 ||
                            matrix[row + rowChange, col + colChange] != 0)
                    {
                        ChangeDirection(ref rowChange, ref colChange);
                    }

                    row += rowChange;
                    col += colChange;
                }
                else 
                {
                    //If no neighbouring cells are viable for traversing find a new starting cell
                    FindNewStartingCell(matrix, out row, out col);
                    rowChange = 1;
                    colChange = 1;
                }

                cellValue++;
                matrix[row, col] = cellValue;
                
            }

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write("{0,3}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
        }
    }
}
