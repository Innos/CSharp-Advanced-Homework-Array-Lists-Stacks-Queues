namespace _05ShortestPathsWithNegativeEdges
{
    using System;
    using System.Collections.Generic;

    using _01ExtendACableNetwork;

    public class ShortestPathsWithNegativeEdges
    {
        public static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine().Substring(7));
            string line = Console.ReadLine();
            string[] pathString = line
                .Substring(line.IndexOf(' '))
                .Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            int pathStart = int.Parse(pathString[0]);
            int pathEnd = int.Parse(pathString[1]);
            int edgesCount = int.Parse(Console.ReadLine().Substring(7));

            List<Edge> edges = new List<Edge>();
            long[] distances = new long[nodes];
            int?[] previous = new int?[nodes];

            for (int i = 0; i < edgesCount; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                int start = int.Parse(parameters[0]);
                int end = int.Parse(parameters[1]);
                int weight = int.Parse(parameters[2]);
                Edge edge = new Edge(start, end, weight);
                edges.Add(edge);
            }

            BellmanFord(distances, previous, edges, nodes, pathStart, pathEnd);
        }

        private static void BellmanFord(long[] distances, int?[] previous, List<Edge> edges, int nodes, int start, int end)
        {
            // initialize
            for (int i = 0; i < nodes; i++)
            {
                distances[i] = int.MaxValue;
                previous[i] = null;
            }

            distances[start] = 0;

            // relax the edges
            for (int i = 0; i < nodes - 1; i++)
            {
                foreach (var edge in edges)
                {
                    if (distances[edge.Parent] + edge.Weight < distances[edge.Child])
                    {
                        distances[edge.Child] = distances[edge.Parent] + edge.Weight;
                        previous[edge.Child] = edge.Parent;
                    }
                }
            }

            // check for negative cycles
            foreach (var edge in edges)
            {
                if (distances[edge.Parent] + edge.Weight < distances[edge.Child])
                {
                    Console.WriteLine("Negative cycle detected:");
                    List<int> pathNegative = new List<int>();
                    int? prevNegative = previous[edge.Child];
                    while (prevNegative != null && !pathNegative.Contains(prevNegative.Value))
                    {
                        pathNegative.Add(prevNegative.Value);
                        prevNegative = previous[prevNegative.Value];
                    }
                    pathNegative.Reverse();
                    Console.WriteLine(string.Join(" -> ", pathNegative));
                    return;
                }
            }

            List<int> path = new List<int>();
            path.Add(end);
            int? prev = previous[end];
            while (prev != null)
            {
                path.Add(prev.Value);
                prev = previous[prev.Value];
            }
            path.Reverse();

            Console.WriteLine("Distance [{0} -> {1}]: {2}", start, end, distances[end]);
            Console.WriteLine("Path: {0}", string.Join(" -> ", path));
        }
    }
}
