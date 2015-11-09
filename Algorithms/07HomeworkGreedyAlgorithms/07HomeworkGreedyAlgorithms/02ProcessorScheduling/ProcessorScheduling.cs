namespace _02ProcessorScheduling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProcessorScheduling
    {
        public static void Main(string[] args)
        {
            int tasksCount = int.Parse(Console.ReadLine().Substring(7));
            Dictionary<int, List<Task>> tasks = new Dictionary<int, List<Task>>();
            int maxDeadline = 0;

            for (int i = 1; i <= tasksCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                int value = int.Parse(parameters[0]);
                int deadline = int.Parse(parameters[1]);
                if (deadline > maxDeadline)
                {
                    maxDeadline = deadline;
                }
                Task task = new Task(i, value, deadline);
                if (!tasks.ContainsKey(deadline))
                {
                    tasks.Add(deadline, new List<Task>());
                }
                tasks[deadline].Add(task);
            }

            BinaryHeap<Task> nextTasks = new BinaryHeap<Task>();
            List<Task> result = new List<Task>();

            for (int i = maxDeadline; i >= 1; i--)
            {
                if (tasks.ContainsKey(i))
                {
                    foreach (var task in tasks[i])
                    {
                        nextTasks.Insert(task);
                    }
                }

                if (nextTasks.Count == 0)
                {
                    continue;
                }

                result.Add(nextTasks.ExtractMax());
            }

            Console.WriteLine(
                "Optimal schedule: {0}",
                string.Join(" -> ", result.OrderBy(x => x.Deadline).ThenByDescending(x => x.Value).Select(x => x.Number)));
            Console.WriteLine("Total value: {0}", result.Sum(x => x.Value));
        }
    }
}
