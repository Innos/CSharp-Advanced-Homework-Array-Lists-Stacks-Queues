namespace _04LongestPathInATree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LongestPathInATree
    {
        private static int longestDistance = int.MinValue;

        private static int firstLeaf;

        private static int secondLeaf;

        private static int ancestor;

        public static void Main(string[] args)
        {
            Dictionary<int, TreeNode<int>> tree = new Dictionary<int, TreeNode<int>>();
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());
            for (int i = 0; i < edges; i++)
            {
                int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var parent = parameters[0];
                var child = parameters[1];
                var parentNode = GetNodeInTree(tree, parent);
                var childNode = GetNodeInTree(tree, child);
                parentNode.Children.Add(childNode);

            }

            var root = FindRoot(tree);
            var leaves = FindLeaves(tree);
            foreach (var node in leaves)
            {
                node.IsLeaf = true;
            }
            CalculateDistancesFromRootDfs(root, 0);
            TarjanOLCA(leaves, root);

            Console.WriteLine("Longest Distance: {0}, between nodes {1} and {2}, with least common ancestor {3}", longestDistance, firstLeaf, secondLeaf,ancestor);

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

        private static TreeNode<T> FindRoot<T>(Dictionary<T, TreeNode<T>> tree)
        {
            return tree.Values.FirstOrDefault(x => x.Parent == x);
        }

        private static List<TreeNode<T>> FindLeaves<T>(Dictionary<T, TreeNode<T>> tree)
        {
            return tree.Values.Where(x => x.Children.Count == 0).ToList();
        }

        private static void CalculateDistancesFromRootDfs(TreeNode<int> current, int distance)
        {
            current.DistanceFromRoot = distance + current.Value;
            foreach (var child in current.Children)
            {
                CalculateDistancesFromRootDfs(child, current.DistanceFromRoot);
            }
        }

        private static void TarjanOLCA(List<TreeNode<int>> leaves, TreeNode<int> current)
        {
            current.Ancestor = current;
            foreach (var child in current.Children)
            {
                TarjanOLCA(leaves, child);
                Union(current, child);
                Find(current).Ancestor = current;
            }
            current.IsBlack = true;

            if (current.IsLeaf)
            {
                foreach (var node in leaves)
                {
                    if (node.IsBlack && current != node)
                    {
                        var commonAncestor = Find(node).Ancestor;
                        int distanceA = current.DistanceFromRoot - commonAncestor.DistanceFromRoot;
                        int distanceB = node.DistanceFromRoot - commonAncestor.DistanceFromRoot;
                        var totalDistance = distanceA + distanceB + commonAncestor.Value;
                        if (totalDistance > longestDistance)
                        {
                            longestDistance = totalDistance;
                            firstLeaf = current.Value;
                            secondLeaf = node.Value;
                            ancestor = commonAncestor.Value;
                        }
                    }
                }
            }
        }



        private static void Union<T>(TreeNode<T> first, TreeNode<T> second)
        {
            var firstRoot = Find(first);
            var secondRoot = Find(second);
            if (firstRoot.Rank > secondRoot.Rank)
            {
                secondRoot.Parent = firstRoot;
            }
            else if (firstRoot.Rank < secondRoot.Rank)
            {
                firstRoot.Parent = secondRoot;
            }
            else if (firstRoot != secondRoot)
            {
                secondRoot.Parent = firstRoot;
                firstRoot.Rank += 1;
            }
        }

        private static TreeNode<T> Find<T>(TreeNode<T> node)
        {
            if (node.Parent == node)
            {
                return node;
            }
            else
            {
                node.Parent = Find(node.Parent);
                return node.Parent;
            }
        }
    }
}
