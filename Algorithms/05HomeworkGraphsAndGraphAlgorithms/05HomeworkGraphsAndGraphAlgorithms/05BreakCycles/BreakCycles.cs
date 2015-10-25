namespace _05BreakCycles
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BreakCycles
    {
        private static SortedDictionary<string, List<string>> graph;

        private static int removedEdges = 0;

        private static HashSet<string> visited; 

        public static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            graph = new SortedDictionary<string, List<string>>();

            // filling the graph
            Console.WriteLine("Enter the edges as shown in the example and finish your input with a blank line");
            string line = Console.ReadLine();
            while (line != String.Empty)
            {
                string[] parameters = line.Split(new char[] { ' ', '-', '>',',' }, StringSplitOptions.RemoveEmptyEntries);
                string key = parameters[0];
                graph.Add(key, new List<string>());
                for (int i = 1; i < parameters.Length; i++)
                {
                    graph[key].Add(parameters[i]);
                }

                line = Console.ReadLine();
            }

            // traversing each edge of the graph
            foreach (var key in graph.Keys)
            {
                graph[key].Sort();
                for (int i = 0; i < graph[key].Count; i++)
                {
                    // remove the edge
                    string end = graph[key][i];
                    graph[key].RemoveAt(i);
                    graph[end].Remove(key);

                    // check if it made a cycle
                    visited = new HashSet<string>();
                    if (CheckIfEdgeIsRemovable(key, end, visited))
                    {
                        removedEdges++;
                        result.AppendFormat("{0} - {1}\n", key, end);
                    }
                    else
                    {
                        // if it isn't return the edge
                        graph[end].Add(key);
                        graph[key].Insert(i, end);
                    }
                }
            }
            // print
            Console.WriteLine("Edges to remove: {0}", removedEdges);
            Console.WriteLine(result.ToString());
        }

        // BFS if we can find another route between the elements of the edge we removed then the edge was making a cycle
        private static bool CheckIfEdgeIsRemovable(string start, string end, HashSet<string> visited)
        {
            var nodes = new Queue<string>();
            visited.Add(start);
            nodes.Enqueue(start);

            while (nodes.Count > 0)
            {
                var node = nodes.Dequeue();
                if (node == end)
                {
                    return true;
                }

                foreach (var child in graph[node])
                {
                    if (!visited.Contains(child))
                    {
                        visited.Add(child);
                        nodes.Enqueue(child);
                    }
                }
            }

            return false;
        }
    }
}
