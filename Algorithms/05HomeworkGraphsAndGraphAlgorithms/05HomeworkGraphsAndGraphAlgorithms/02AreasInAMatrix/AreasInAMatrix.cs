namespace _02AreasInAMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AreasInAMatrix
    {
        private static List<string> matrix;

        private static bool[,] visited;

        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine().Substring(16));
            matrix = new List<string>();
            
            // fill the matrix
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(Console.ReadLine());
            }

            int cols = matrix[0].Length;
            visited = new bool[rows, cols];
            SortedDictionary<char, int> areas = new SortedDictionary<char, int>();

            // traverse the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (!visited[i, j])
                    {
                        char letter = matrix[i][j];
                        MapSubarea(i, j, letter);
                        if (!areas.ContainsKey(letter))
                        {
                            areas.Add(letter, 0);
                        }

                        areas[letter] = areas[letter] + 1;
                    }
                }
            }

            Console.WriteLine("Areas: {0}", areas.Values.Sum());
            foreach (var pair in areas)
            {
                Console.WriteLine("Letter '{0}' -> {1}", pair.Key, pair.Value);
            }
        }

        private static void MapSubarea(int row, int col, char letter)
        {
            // is in matrix check
            if (row < 0 || row >= matrix.Count || col < 0 || col >= matrix[0].Length)
            {
                return;
            }

            // is the same letter check
            if (matrix[row][col] != letter)
            {
                return;
            }

            // is visited check
            if (visited[row, col])
            {
                return;
            }

            visited[row, col] = true;

            MapSubarea(row, col + 1, letter);
            MapSubarea(row + 1, col, letter);
            MapSubarea(row, col - 1, letter);
            MapSubarea(row - 1, col, letter);
        }
    }
}
