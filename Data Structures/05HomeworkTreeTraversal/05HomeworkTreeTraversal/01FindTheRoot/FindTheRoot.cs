namespace _01FindTheRoot
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindTheRoot
    {
        public static void Main(string[] args)
        {
            Dictionary<int, TreeNode<int>> tree = new Dictionary<int, TreeNode<int>>();
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());

            for (int i = 0; i < edges; i++)
            {
                int[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var parent = parameters[0];
                var child = parameters[1];

                var parentNode = GetNodeInTree(tree, parent);
                var childNode = GetNodeInTree(tree, child);

                parentNode.Children.Add(childNode);
                childNode.Parent = parentNode;
            }

            var roots = FindRoots(tree);
            if (roots.Count > 1)
            {
                Console.WriteLine("Multiple root nodes!");
            }
            else if (roots.Count == 0)
            {
                Console.WriteLine("No root!");
            }
            else
            {
                Console.WriteLine(roots[0]);
            }
        }

        private static TreeNode<T> GetNodeInTree<T>(Dictionary<T, TreeNode<T>> tree, T element)
        {
            if (!tree.ContainsKey(element))
            {
                var node = new TreeNode<T>(element);
                tree.Add(element, node);
                return node;
            }
            return tree[element];
        }

        private static List<T> FindRoots<T>(Dictionary<T, TreeNode<T>> tree)
        {
            var roots = tree.Values.Where(x => x.Parent == null).Select(x => x.Value).ToList();
            return roots;
        }
    }
}
