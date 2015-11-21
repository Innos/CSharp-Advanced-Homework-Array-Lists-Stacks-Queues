namespace _01ShortestPathInAMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortestPathInAMatrix
    {
        private static int[] prev;
        private static bool[] visited;
        private static int[,] matrix;
        private static int rows;
        private static int cols;

        public static void Main(string[] args)
        {
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            matrix = new int[rows, cols];
            int size = rows * cols;
            prev = new int[size];
            visited = new bool[size];

            // parse matrix
            for (int i = 0; i < rows; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            // initialize graph
            List<Node> graph = new List<Node>();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int element = (row * cols) + col;
                    graph.Add(new Node(element, int.MaxValue));
                    if (row - 1 >= 0)
                    {
                        int child = ((row - 1) * cols) + col;
                        graph[element].Edges.Add(new Edge(element, child, matrix[row - 1, col]));
                    }
                    if (col - 1 >= 0)
                    {
                        int child = (row * cols) + (col - 1);
                        graph[element].Edges.Add(new Edge(element, child, matrix[row, col - 1]));
                    }
                    if (col + 1 < cols)
                    {
                        int child = (row * cols) + (col + 1);
                        graph[element].Edges.Add(new Edge(element, child, matrix[row, col + 1]));
                    }
                    if (row + 1 < rows)
                    {
                        int child = ((row + 1) * cols) + col;
                        graph[element].Edges.Add(new Edge(element, child, matrix[row + 1, col]));
                    }
                }
            }

            Dijkstra(0, size - 1, graph);
            List<int> path = ReconstructPath(0, size - 1);
            Console.WriteLine("Length: {0}", graph[size - 1].Distance);
            Console.WriteLine("Path: {0}", string.Join(" ", path));
        }

        private static void Dijkstra(int start, int end, List<Node> graph)
        {
            int startRow = start / cols;
            int startCol = start % cols;
            graph[start].Distance = matrix[startRow, startCol];
            BinaryHeap<Node> priorityQueue = new BinaryHeap<Node>();
            priorityQueue.Insert(graph[start]);
            visited[start] = true;

            while (priorityQueue.Count > 0)
            {
                Node current = priorityQueue.ExtractMin();

                if (current.Value == end)
                {
                    break;
                }

                foreach (var edge in current.Edges)
                {
                    if (!visited[edge.Child])
                    {
                        priorityQueue.Insert(graph[edge.Child]);
                        visited[edge.Child] = true;
                    }

                    int currentDistance = current.Distance + edge.Distance;
                    if (graph[edge.Child].Distance > currentDistance)
                    {
                        graph[edge.Child].Distance = currentDistance;
                        prev[edge.Child] = current.Value;
                        priorityQueue.Reorder(graph[edge.Child]);
                    }
                }
            }
        }

        private static List<int> ReconstructPath(int start, int end)
        {
            List<int> path = new List<int>();
            int curRow = end / cols;
            int curCol = end % cols;
            int prevElement = int.MaxValue;
            while (true)
            {
                path.Add(matrix[curRow, curCol]);

                if (prevElement == start)
                {
                    break;
                }

                prevElement = prev[(curRow * cols) + curCol];
                curRow = prevElement / cols;
                curCol = prevElement % cols;
            }
            path.Reverse();
            return path;
        }
    }
}