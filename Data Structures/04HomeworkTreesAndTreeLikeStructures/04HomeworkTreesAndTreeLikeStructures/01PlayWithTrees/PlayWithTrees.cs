namespace _01PlayWithTrees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PlayWithTrees
    {
        private static int maxDepth = 1;

        private static TreeNode<int> deepestNode;


        public static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());
            Dictionary<int, TreeNode<int>> tree = new Dictionary<int, TreeNode<int>>();

            for (int i = 1; i < nodes; i++)
            {
                int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int parent = parameters[0];
                int child = parameters[1];
                if (!tree.ContainsKey(parent))
                {
                    tree.Add(parent, new TreeNode<int>(parent, null));
                }
                if (!tree.ContainsKey(child))
                {
                    tree.Add(child, new TreeNode<int>(child, tree[parent]));
                }
                tree[parent].Children.Add(tree[child]);
                tree[child].Parent = tree[parent];
            }

            int pathSum = int.Parse(Console.ReadLine());
            int subtreeSum = int.Parse(Console.ReadLine());

            var root = FindRootNode(tree);

            Console.WriteLine("Root node: {0}", root.Value);

            Console.WriteLine("Leaf nodes: {0}", string.Join(", ", FindAllLeafNodes(tree).OrderBy(x => x).Select(x => x.Value)));

            Console.WriteLine("Middle nodes: {0}", string.Join(", ", FindAllMiddleNodes(tree).OrderBy(x => x).Select(x => x.Value)));

            var longestPath = FindLongestPath(root);
            Console.WriteLine("Longest Path: {0} (length = {1})", string.Join(" -> ", longestPath), longestPath.Count);

            var paths = FindAllPathsOfSpecificSum(pathSum, root);
            Console.WriteLine("Paths of sum {0}:", pathSum);
            foreach (var path in paths)
            {
                Console.WriteLine(string.Join(" -> ", path));
            }

            var subtrees = FindAllSubtreesOfGivenSum(subtreeSum, tree);
            Console.WriteLine("Subtrees of sum {0}:",subtreeSum);
            foreach (var subtree in subtrees)
            {
                Console.WriteLine(string.Join(" + ",subtree));
            }

        }

        private static TreeNode<T> FindRootNode<T>(Dictionary<T, TreeNode<T>> tree) where T : IComparable<T>
        {
            return tree.Values.FirstOrDefault(x => x.Parent == null);
        }

        private static IEnumerable<TreeNode<T>> FindAllMiddleNodes<T>(Dictionary<T, TreeNode<T>> tree) where T : IComparable<T>
        {
            return tree.Values.Where(x => x.Children.Count > 0 && x.Parent != null);
        }

        private static IEnumerable<TreeNode<T>> FindAllLeafNodes<T>(Dictionary<T, TreeNode<T>> tree) where T : IComparable<T>
        {
            return tree.Values.Where(x => x.Children.Count == 0);
        }

        private static List<int> FindLongestPath(TreeNode<int> root)
        {
            root.Depth = 1;
            maxDepth = 1;
            deepestNode = root;

            Dfs(root);

            return ReconstructPath(deepestNode);
        }

        private static List<List<int>> FindAllPathsOfSpecificSum(int sum, TreeNode<int> root)
        {
            //uses BFS
            root.PathSum = root.Value;
            List<List<int>> paths = new List<List<int>>();
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.PathSum == sum)
                {
                    paths.Add(ReconstructPath(currentNode));
                }
                else if (currentNode.PathSum < sum)
                {
                    foreach (var child in currentNode.Children)
                    {
                        child.PathSum = currentNode.PathSum + child.Value;
                        queue.Enqueue(child);
                    }
                }
            }

            return paths;
        }

        private static List<List<int>> FindAllSubtreesOfGivenSum(int sum, Dictionary<int, TreeNode<int>> tree)
        {
            List<List<int>> subtree = new List<List<int>>();
            foreach (var treeNode in tree.Values)
            {
                if (CalculateSubtreeSum(treeNode) == sum)
                {
                    var list = new List<int>();
                    ExtractSubtreeValues(treeNode,list);
                    subtree.Add(list);
                }
            }

            return subtree;
        }

        private static int CalculateSubtreeSum(TreeNode<int> currentNode)
        {
            if (currentNode.SubtreeSum != 0)
            {
                return currentNode.SubtreeSum;
            }

            foreach (var child in currentNode.Children)
            {
                currentNode.SubtreeSum += CalculateSubtreeSum(child);
            }
            currentNode.SubtreeSum += currentNode.Value;
            return currentNode.SubtreeSum;
        } 

        //used to calculate depth of each node from the root (for finding longest path)
        private static void Dfs(TreeNode<int> currentNode)
        {
            foreach (var child in currentNode.Children)
            {
                child.Depth = child.Parent.Depth + 1;
                if (child.Depth > maxDepth)
                {
                    maxDepth = child.Depth;
                    deepestNode = child;
                }
                Dfs(child);
            }
        }

        // helper method for reconstructing the path from the root to the current node
        private static List<T> ReconstructPath<T>(TreeNode<T> endNode) where T : IComparable<T>
        {
            var list = new List<T>();
            while (endNode != null)
            {
                list.Add(endNode.Value);
                endNode = endNode.Parent;
            }
            list.Reverse();
            return list;
        }

        //helper method for extracting all values in a subtree
        private static void ExtractSubtreeValues<T>(TreeNode<T> currentNode, List<T> values) where T : IComparable<T>
        {
            values.Add(currentNode.Value);
            foreach (var child in currentNode.Children)
            {
                ExtractSubtreeValues<T>(child, values);
            }
        }
    }
}
