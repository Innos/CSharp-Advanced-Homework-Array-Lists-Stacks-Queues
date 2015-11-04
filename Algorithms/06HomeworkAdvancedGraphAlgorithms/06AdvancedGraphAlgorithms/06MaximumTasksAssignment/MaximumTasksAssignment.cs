namespace _06MaximumTasksAssignment
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class MaximumTasksAssignment
    {
        private static bool pathFound = false;

        private static bool[] tasksFinished;

        private static Dictionary<int, List<int>> graph;

        private static int[] path;

        private static int tasks;

        private static int counter;

        public static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine().Substring(9));
            tasks = int.Parse(Console.ReadLine().Substring(7));

            graph = new Dictionary<int, List<int>>();
            path = new int[tasks];
            tasksFinished = new bool[tasks];
            counter = 0;

            for (int i = 0; i < persons; i++)
            {
                graph.Add(i, new List<int>());
                string line = Console.ReadLine();
                for (int j = 0; j < tasks; j++)
                {
                    if (line[j] == 'Y')
                    {
                        graph[i].Add(j);
                    }
                }
            }

            FindAugmentingPathDFS(0, graph);
            if (counter < tasks)
            {
                Console.WriteLine("Impossible.");
            }
            else
            {
                for (int i = 0; i < tasks; i++)
                {
                    Console.WriteLine("{0} -> {1}", (char)('A' + i), path[i] + 1);
                } 
            }         
        }

        private static void FindAugmentingPathDFS(int node, Dictionary<int, List<int>> graph)
        {
            if (node == tasks)
            {
                pathFound = true;
                return;
            }

            foreach (var child in graph[node])
            {
                if (!tasksFinished[child])
                {
                    tasksFinished[child] = true;
                    path[node] = child;
                    counter++;
                    FindAugmentingPathDFS(node + 1, graph);
                    tasksFinished[child] = false;
                    if (pathFound)
                    {
                        return;
                    }

                    counter--;        
                }
            }
        }
    }
}
