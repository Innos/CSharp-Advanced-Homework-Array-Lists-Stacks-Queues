namespace _04LongestPathInATree
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {

        public TreeNode(T value)
        {
            this.Value = value;
            this.Parent = this;
            this.Ancestor = this;
            this.Rank = 0;
            this.IsBlack = false;
            this.IsLeaf = false;
            this.DistanceFromRoot = 0;
            this.Children = new List<TreeNode<T>>();
        }

        public T Value { get; private set; }

        public int DistanceFromRoot { get; set; }

        public int Rank { get; set; }

        public bool IsBlack { get; set; }

        public bool IsLeaf { get; set; }

        public TreeNode<T> Parent { get; set; }

        public TreeNode<T> Ancestor { get; set; }

        public List<TreeNode<T>> Children { get; private set; }
    }
}
