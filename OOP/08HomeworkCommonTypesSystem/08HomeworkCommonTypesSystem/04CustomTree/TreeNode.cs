using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CustomTree
{
    public class TreeNode<T> : ICloneable
        where T : IComparable<T>
    {
        public TreeNode(T value, TreeNode<T> parent, TreeNode<T> left = null, TreeNode<T> right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
            this.Parent = parent;
        }

        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }
        public TreeNode<T> Parent { get; set; }

        public object Clone()
        {
            TreeNode<T> newRoot = CloneBody();
            SetParent(newRoot);
            return newRoot;
        }
        private TreeNode<T> CloneBody()
        {
            TreeNode<T> left = null;
            TreeNode<T> right = null;
            if (this.Left != null)
            {
                left = this.Left.CloneBody() as TreeNode<T>;
            }
            if (this.Right != null)
            {
                right = this.Right.CloneBody() as TreeNode<T>;
            }
            return new TreeNode<T>(Value, Parent, left, right);
        }

        private void SetParent(TreeNode<T> node)
        {
            if (node == null) return;
            if (node.Left != null)
            {
                node.Left.Parent = node;
                SetParent(node.Left);
            }
            if (node.Right != null)
            {
                node.Right.Parent = node;
                SetParent(node.Right);
            }      
        }
    }
}
