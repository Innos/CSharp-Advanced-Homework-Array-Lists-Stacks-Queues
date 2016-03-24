namespace _03MassEffect
{
    public class TreeNode<T> where T : IShape
    {
        public TreeNode(T value, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        } 

        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; } 
    }
}
