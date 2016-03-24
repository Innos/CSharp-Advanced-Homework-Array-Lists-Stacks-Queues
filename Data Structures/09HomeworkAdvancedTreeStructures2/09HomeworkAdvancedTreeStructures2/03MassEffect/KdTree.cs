namespace _03MassEffect
{
    using System;
    using System.Collections.Generic;

    public class KdTree<T> where T : IShape
    {
        private int dimensions;

        private TreeNode<T> root;

        public KdTree(List<T> items)
        {
            this.GetDimensions(items);
            this.root = this.BuildTree(items);
        }

        public IEnumerable<T> FindElementsInRadius(IShape point, double radius)
        {
            var range = new List<T>();
            this.FindRadius(this.root, range, point, radius);
            return range;
        }

        public void Add(T element)
        {
            if (this.root == null)
            {
                this.root = new TreeNode<T>(element);
            }
            else
            {
                this.InnerInsert(this.root, element);
            }
        }

        private void FindRadius(TreeNode<T> current, List<T> containedItems, IShape point, double radius, int depth = 0)
        {
            if (current == null)
            {
                return;
            }

            if (this.IsInRadius(current.Value, point, radius))
            {
                containedItems.Add(current.Value);
            }

            if (current.Value.Dimensions[depth] > point.Dimensions[depth] - radius)
            {
                this.FindRadius(current.Left, containedItems, point, radius, (depth + 1) % this.dimensions);
            }

            if (current.Value.Dimensions[depth] < point.Dimensions[depth] + radius)
            {
                this.FindRadius(current.Right, containedItems, point, radius, (depth + 1) % this.dimensions);
            }
        }

        private bool IsInRadius(IShape current, IShape point, double radius)
        {
            double totalDistance = 0;
            for (int i = 0; i < current.Dimensions.Length; i++)
            {
                var distance = current.Dimensions[i] - point.Dimensions[i];
                totalDistance += distance * distance;
            }

            if (totalDistance <= radius * radius)
            {
                return true;
            }

            return false;
        }

        private void InnerInsert(TreeNode<T> current, T element, int depth = 0)
        {
            if (element.Dimensions[depth] < current.Value.Dimensions[depth])
            {
                if (current.Left == null)
                {
                    current.Left = new TreeNode<T>(element);
                }
                else
                {
                    this.InnerInsert(current.Left, element, (depth + 1) % this.dimensions);
                }
            }
            else
            {
                if (current.Right != null)
                {
                    current.Right = new TreeNode<T>(element);
                }
                else
                {
                    this.InnerInsert(current.Left, element, (depth + 1) % this.dimensions);
                }
            }
        }


        private TreeNode<T> BuildTree(List<T> items, int depth = 0)
        {
            items.Sort((x1, x2) => x1.Dimensions[depth].CompareTo(x2.Dimensions[depth]));
            var mid = items.Count / 2;
            var median = items[mid];

            if (items.Count == 1)
            {
                return new TreeNode<T>(median);
            }
            else if (items.Count == 2)
            {
                return new TreeNode<T>(median, this.BuildTree(items.GetRange(0, 1), (depth + 1) % this.dimensions));
            }
            else
            {
                return new TreeNode<T>(
                median,
                this.BuildTree(items.GetRange(0, mid), (depth + 1) % this.dimensions),
                this.BuildTree(items.GetRange(mid + 1, items.Count - mid - 1), (depth + 1) % this.dimensions));
            }
        }

        private void GetDimensions(List<T> items)
        {
            if (items.Count == 0)
            {
                throw new ArgumentException("Cannot instantiate a new KD Tree from an empty collection!");
            }

            this.dimensions = items[0].Dimensions.Length;
        }
    }
}
