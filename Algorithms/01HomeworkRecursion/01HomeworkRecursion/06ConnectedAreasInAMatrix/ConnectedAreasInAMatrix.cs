namespace _06ConnectedAreasInAMatrix
{
    using System;
    using System.Collections.Generic;

    using Wintellect.PowerCollections;

    public class ConnectedAreasInAMatrix
    {
        private static List<char[]> matrix = new List<char[]>();

        private static OrderedSet<ConnectedArea> connectedAreas = new OrderedSet<ConnectedArea>();

        private static int size = 0;

        private static bool[,] traversed;

        public static void Main(string[] args)
        {
            String line = Console.ReadLine();

            // use the word "end" to mark end of the input
            while (line != "end")
            {
                matrix.Add(line.ToCharArray());
                line = Console.ReadLine();
            }

            traversed = new bool[matrix.Count, matrix[0].Length];
            FindNextTraversibleCell();
            PrintAreas();
        }

        private static void FindNextTraversibleCell()
        {
            for (int row = 0; row < matrix.Count; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (!traversed[row, col])
                    {
                        if (matrix[row][col] != ' ')
                        {
                            traversed[row, col] = true;
                        }
                        else
                        {
                            TraverseMatrix(row, col);
                            ConnectedArea area = new ConnectedArea(row, col, size);
                            connectedAreas.Add(area);
                            size = 0;

                        }
                    }

                }
            }
        }

        private static void TraverseMatrix(int row, int col)
        {
            if (!IsInMatrix(row, col))
            {
                return;
            }

            if (traversed[row, col])
            {
                return;
            }

            if (matrix[row][col] != ' ')
            {
                traversed[row, col] = true;
                return;
            }

            traversed[row, col] = true;
            size++;

            // left
            TraverseMatrix(row, col - 1);

            // up
            TraverseMatrix(row - 1, col);

            // right
            TraverseMatrix(row, col + 1);

            //down
            TraverseMatrix(row + 1, col);

        }

        private static bool IsInMatrix(int row, int col)
        {
            bool rowInMatrix = row >= 0 && row < matrix.Count;
            bool colInMatrix = col >= 0 && col < matrix[0].Length;
            return rowInMatrix && colInMatrix;
        }

        private static void PrintAreas()
        {
            Console.WriteLine("Total areas found: {0}", connectedAreas.Count);
            for (int i = 0; i < connectedAreas.Count; i++)
            {
                Console.WriteLine("Area #{0} at ({1}, {2}), size: {3}", i + 1, connectedAreas[i].X, connectedAreas[i].Y, connectedAreas[i].Size);
            }
        }
    }
}
