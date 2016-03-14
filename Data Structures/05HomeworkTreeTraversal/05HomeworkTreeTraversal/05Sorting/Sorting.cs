namespace _05Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sorting
    {
        private static Dictionary<string, int> visited;

        private static string solution;

        private static int elementsTaken;

        //NOTE: The last example is clearly wrong, the numbers are not the numbers from 1 to N (instead of 5 there is 8) also it's impossible to sort the specified sequence
        public static void Main(string[] args)
        {
            int maxElement = int.Parse(Console.ReadLine());
            int[] sequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            elementsTaken = int.Parse(Console.ReadLine());
            visited = new Dictionary<string, int>();
            solution = string.Join(",", Enumerable.Range(1, maxElement));
            Console.WriteLine(Bfs(sequence));
        }

        private static int Bfs(int[] startSequence)
        {
            Queue<int[]> queue = new Queue<int[]>();
            queue.Enqueue(startSequence);
            var startSequenceKey = string.Join(",", startSequence);
            visited.Add(startSequenceKey, 0);
            if (startSequenceKey == solution)
            {
                return visited[startSequenceKey];
            }


            while (queue.Count > 0)
            {
                var currentSequence = queue.Dequeue();
                var currentSequenceKey = string.Join(",", currentSequence);
                for (int i = 0; i <= currentSequence.Length - elementsTaken; i++)
                {
                    var copy = new int[currentSequence.Length];
                    Array.Copy(currentSequence, copy, currentSequence.Length);
                    Array.Reverse(copy, i, elementsTaken);
                    var copyKey = string.Join(",", copy);
                    if (!visited.ContainsKey(copyKey))
                    {
                        visited.Add(copyKey, visited[currentSequenceKey] + 1);
                        if (solution == copyKey)
                        {
                            return visited[copyKey];
                        }
                        queue.Enqueue(copy);
                    }
                }
            }
            return -1;
        }
    }
}
