namespace _06MaximumTasksAssignment
{
    using System;
    using System.Collections.Generic;

    public class MaximumTasksAssignment
    {
        private static bool pathFound = false;

        private static bool[] visited;

        private static int[,] graph;

        private static int[] path;

        private static int tasks;

        public static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine().Substring(9));
            tasks = int.Parse(Console.ReadLine().Substring(7));

            graph = new int[tasks, tasks];
            path = new int[tasks];
            visited = new bool[tasks];

            for (int i = 0; i < persons; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < tasks; j++)
                {
                    if (line[j] == 'Y')
                    {
                        graph[i, j] = 1;
                    }

                }
            }
            FindAugmentingPathDFS(0);
            for (int i = 0; i < tasks; i++)
            {
                Console.WriteLine("{0} -> {1}", (char)('A' + i), path[i] + 1);
            }
        }

        static void FindAugmentingPathDFS(int loop)
        {           
            if (loop == tasks)
            {
                pathFound = true;
            }
            else
            {
                for (int nextNode = 0; nextNode < tasks; nextNode++)
                {
                    if (!visited[nextNode] && graph[loop, nextNode] > 0)
                    {
                        visited[nextNode] = true;
                        path[loop] = nextNode;
                        FindAugmentingPathDFS(loop + 1);
                        visited[nextNode] = false;
                        if (pathFound)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
