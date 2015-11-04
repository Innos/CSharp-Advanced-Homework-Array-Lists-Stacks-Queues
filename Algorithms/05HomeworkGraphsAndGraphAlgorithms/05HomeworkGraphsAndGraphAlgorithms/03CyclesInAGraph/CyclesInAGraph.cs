namespace _03CyclesInAGraph
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class CyclesInAGraph
    {
        private static HashSet<string> visited;

        private static Dictionary<string, List<string>> graph;


        private static bool isAcyclic;

        public static void Main(string[] args)
        {
            isAcyclic = true;
            graph = new Dictionary<string, List<string>>();
            visited = new HashSet<string>();

            // Enter the edges as shown in the example and finish the input with an empty line
            Console.WriteLine("Enter the edges as shown in the example and finish the input with an empty line");
            string line = Console.ReadLine();

            while (line != String.Empty)
            {
                string[] parameters = line.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
                string start = parameters[0];
                string end = parameters[1];
                line = Console.ReadLine();

                if (!graph.ContainsKey(start))
                {
                    graph.Add(start, new List<string>());
                }
                if (!graph.ContainsKey(end))
                {
                    graph.Add(end, new List<string>());
                }

                graph[start].Add(end);
                graph[end].Add(start);
            }
            CheckIsAcyclic(graph.Keys.First());
            Console.WriteLine("Acyclic: {0}", isAcyclic ? "Yes" : "No");
        }

        private static void CheckIsAcyclic(string node, string prevNode = null)
        {
            if (!visited.Contains(node))
            {
                visited.Add(node);

                foreach (var child in graph[node])
                {
                    if (child != prevNode)
                    {
                        CheckIsAcyclic(child, node);
                    }
                }
            }
            else
            {
                isAcyclic = false;
            }
        }
    }
}
