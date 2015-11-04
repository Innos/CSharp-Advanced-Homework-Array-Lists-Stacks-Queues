namespace _03MostReliablePath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MostReliablePath
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

            int[] previous = new int[nodes];
            bool[] visited = new bool[nodes];
            List<Node> graph = new List<Node>();

            for (int i = 0; i < nodes; i++)
            {
                graph.Add(new Node(i, -1));
            }

            for (int i = 0; i < edgesCount; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                int start = int.Parse(parameters[0]);
                int end = int.Parse(parameters[1]);
                double reliability = double.Parse(parameters[2]);
                Edge edge = new Edge(start, end, reliability);
                Edge reverseEdge = new Edge(end, start, reliability);

                graph[start].Edges.Add(edge);
                graph[end].Edges.Add(reverseEdge);
            }

            Dijkstra(pathStart, pathEnd, visited, graph, previous);
            List<int> result = ReconstructPath(previous, pathStart, pathEnd, graph);
            Console.WriteLine("Most reliable path reliability: {0:0.00}", graph[pathEnd].Reliability);
            Console.WriteLine(result.Count > 0 ? string.Join(" -> ", result) : "Unreachable");
        }

        private static void Dijkstra(int node, int end, bool[] visited, List<Node> graph, int[] previous)
        {
            graph[node].Reliability = 100;
            BinaryHeap<Node> priorityQueue = new BinaryHeap<Node>();
            priorityQueue.Insert(graph[node]);
            visited[node] = true;

            while (priorityQueue.Count > 0)
            {
                Node currentNode = priorityQueue.ExtractMax();
             
                if (currentNode.Value == end)
                {
                    break;
                }

                foreach (var edge in currentNode.Edges)
                {
                    // Dijkstra with priority queue is faster, because we can save the need to check edges leading to already traversed elements,
                    // this comes from the fact that by always taking the shortest total distance possible, when we step on a node there is no shorter 
                    // path to it from an already traversed node
                    if (!visited[edge.Child])
                    {
                        priorityQueue.Insert(graph[edge.Child]);
                        visited[edge.Child] = true;

                        double currentReliability = (currentNode.Reliability * edge.Weight) / 100;
                        if (graph[edge.Child].Reliability < currentReliability)
                        {
                            graph[edge.Child].Reliability = currentReliability;
                            previous[edge.Child] = edge.Parent;                      
                            priorityQueue.Reorder(graph[edge.Child]);
                        }
                    }                    
                }          
            }
        }

        private static List<int> ReconstructPath(int[] previous, int start, int end, List<Node> graph)
        {
            if (graph[end].Reliability < 0)
            {
                return new List<int>();
            }

            List<int> path = new List<int>();
            path.Add(end);
            while (end != start)
            {
                path.Add(previous[end]);
                end = previous[end];
            }

            path.Reverse();
            return path;
        }
    }
}
