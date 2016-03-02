using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace _01PlayWithTrees
{
    using System.Collections.Generic;

    public class TreeNode<T> : IComparable<TreeNode<T>> where T : IComparable<T>
    {
        public TreeNode(T value, TreeNode<T> parent, params TreeNode<T>[] children)
        {
            this.Value = value;
            this.Parent = parent;
            this.Children = new List<TreeNode<T>>(children);
            this.Depth = -1;
            this.PathSum = 0;
            this.SubtreeSum = 0;
        }

        public T Value { get; set; }

        public List<TreeNode<T>> Children { get; private set; }

        public TreeNode<T> Parent { get; set; }

        public int Depth { get; set; }

        public int PathSum { get; set; }

        public int SubtreeSum { get; set; }

        public int CompareTo(TreeNode<T> other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}
