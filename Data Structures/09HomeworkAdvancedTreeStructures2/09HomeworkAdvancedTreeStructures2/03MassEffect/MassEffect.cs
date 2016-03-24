namespace _03MassEffect
{
    using System.Linq;

    using global::System;
    using global::System.Collections.Generic;

    public class MassEffect
    {
        public static void Main(string[] args)
        {
            int systemsCount = int.Parse(Console.ReadLine());
            List<StarSystem> systems = new List<StarSystem>();
            for (int i = 0; i < systemsCount; i++)
            {
                string[] parameters = Console.ReadLine().Split();
                systems.Add(new StarSystem(parameters[0], double.Parse(parameters[1]), double.Parse(parameters[2])));
            }

            var kdTree = new KdTree<StarSystem>(systems);

            string[] searchParams = Console.ReadLine().Split();
            var point = new StarSystem(searchParams[0], double.Parse(searchParams[1]), double.Parse(searchParams[2]));
            var result = kdTree.FindElementsInRadius(point, double.Parse(searchParams[3]));

            Console.WriteLine();
            Console.WriteLine("Search Results:");
            Console.WriteLine(string.Join(Environment.NewLine, result.Select(x => x.Name)));
        }
    }
}
