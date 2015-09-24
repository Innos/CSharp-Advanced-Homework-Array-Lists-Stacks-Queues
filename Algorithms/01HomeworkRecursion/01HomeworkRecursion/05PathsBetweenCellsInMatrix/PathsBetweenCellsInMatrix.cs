namespace _05PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PathsBetweenCellsInMatrix
    {
        private static int exitX = -10;

        private static int exitY = -10;

        private static List<string> solutions = new List<string>();

        private static string path = string.Empty;

        private static List<char[]> matrix = new List<char[]>();

        public static void Main(string[] args)
        {
            String line = Console.ReadLine();

            // use the word "end" to mark end of the input
            while (line != "end")
            {
                matrix.Add(line.ToCharArray());
                line = Console.ReadLine();
            }


            FindExit(0, 0, " ");
            PrintSolution();
        }

        private static bool IsInMatrix(int row, int col)
        {
            bool rowInMatrix = row >= 0 && row < matrix.Count;
            bool colInMatrix = col >= 0 && col < matrix[0].Length;
            return rowInMatrix && colInMatrix;
        }

        private static void FindExit(int row, int col, string direction)
        {
            if (!IsInMatrix(row, col))
            {
                return;
            }

            if (matrix[row][col] == '*' || matrix[row][col] == 'v')
            {
                return;
            }

            path += direction;

            if (matrix[row][col] == 'e')
            {
                solutions.Add(path.Trim());
                exitX = row;
                exitY = col;
            }

            matrix[row][col] = 'v';

            // left
            FindExit(row, col - 1, "L");

            // up
            FindExit(row - 1, col, "U");

            // right
            FindExit(row, col + 1, "R");

            // down
            FindExit(row + 1, col, "D");

            if (row == exitX && col == exitY)
            {
                matrix[row][col] = 'e';
            }
            else
            {
                matrix[row][col] = ' ';
            }

            path = path.Remove(path.Length - 1);

        }

        private static void PrintSolution()
        {
            Console.WriteLine(string.Join(Environment.NewLine, solutions));
            Console.WriteLine("Total paths found: {0}", solutions.Count);
        }

    }
}
