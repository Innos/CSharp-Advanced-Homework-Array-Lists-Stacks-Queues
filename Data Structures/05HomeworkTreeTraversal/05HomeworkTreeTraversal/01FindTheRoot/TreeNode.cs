namespace _01FindTheRoot
{
    using System.Collections.Generic;

    public class TreeNode<T>
    {

        public TreeNode(T value, TreeNode<T> parent = null)
        {
            this.Value = value;
            this.Parent = parent;
            this.Children = new List<TreeNode<T>>();
        }

        public T Value { get; private set; }

        public TreeNode<T> Parent { get; set; }

        public List<TreeNode<T>> Children { get; private set; }
    }
}
