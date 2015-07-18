using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _04CustomTree
{
    public class BinarySearchTree<T> : IEnumerable<T>,ICloneable
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
            this.Root = null;
        }
        public BinarySearchTree(T value)
        {
            this.Root = new TreeNode<T>(value,null);
        }

        public TreeNode<T> Root{get;set;}

        public void Add(T element)
        {
            TreeNode<T> parent = null;
            var current = this.Root;
            int compare = 0;

            if (this.Root == null)
            {
                this.Root = new TreeNode<T>(element, null);
                return;
            }

            while (true)
            {
                if (current == null)
                {
                    current = new TreeNode<T>(element, parent);
                    if (compare == -1)
                    {
                        parent.Left = current;
                        break;
                    }
                    else if (compare == 1)
                    {
                        parent.Right = current;
                        break;
                    }
                }
                else
                {
                    compare = element.CompareTo(current.Value);
                    switch (compare)
                    {
                        case -1:
                            parent = current;
                            current = current.Left;
                            break;
                        case 0:
                            Console.WriteLine("Element '{0}' already exists.",element);
                            return;
                        case 1:
                            parent = current;
                            current = current.Right;
                            break;
                    }
                }
            }
        }

        public bool Contains(T element)
        {
            var current = this.Root;
            while (true)
                if (current == null)
                {
                    return false;
                }
                else if (element.Equals(current.Value))
                {
                    return true;
                }
                else
                {
                    if (element.CompareTo(current.Value) == -1)
                    {
                        current = current.Left;
                    }
                    else if (element.CompareTo(current.Value) == 1)
                    {
                        current = current.Right;
                    }
                }
        }

        public void Delete(T element)
        {
            var current = this.Root;
            try
            {
                while (true)
                    if (current == null)
                    {
                        throw new ArgumentException("element", "Element does not exist.");
                    }
                    else if (element.Equals(current.Value))
                    {
                        if (current.Left != null && current.Right != null)
                        {
                            var successor = GetInOrderSuccessor(current);
                            current.Value = successor.Value;
                            DeleteSimpleNode(successor);
                            break;
                        }

                        DeleteSimpleNode(current);
                        break;
                    }
                    else
                    {
                        if (element.CompareTo(current.Value) == -1)
                        {
                            current = current.Left;
                        }
                        else if (element.CompareTo(current.Value) == 1)
                        {
                            current = current.Right;
                        }
                    }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private TreeNode<T> GetInOrderSuccessor(TreeNode<T> nodeToRemove)
        {
            var successor = nodeToRemove.Right;
            while (successor.Left != null)
            {
                successor = successor.Left;
            }
            return successor;
        }

        private void DeleteSimpleNode(TreeNode<T> nodeToRemove)
        {
            if (nodeToRemove.Left == null && nodeToRemove.Right == null)
            {
                if (nodeToRemove.Parent.Left == nodeToRemove)
                {
                    nodeToRemove.Parent.Left = null;
                }
                nodeToRemove.Parent.Right = null;
            }
            else if (nodeToRemove.Left == null && nodeToRemove.Right != null)
            {
                nodeToRemove.Value = nodeToRemove.Right.Value;
                DeleteSimpleNode(nodeToRemove.Right);
            }
            else if (nodeToRemove.Left != null && nodeToRemove.Right == null)
            {
                nodeToRemove.Value = nodeToRemove.Left.Value;
                DeleteSimpleNode(nodeToRemove.Left);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            var current = this.Root;
            while (stack.Count != 0 || current != null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }
                current = stack.Pop();
                TreeNode<T> node = current;
                current = current.Right;

                yield return node.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return String.Join(", ",this);
        }

        public override bool Equals(object obj)
        {
            if (Object.Equals(this, null) || Object.Equals(obj, null) || obj is BinarySearchTree<T> == false)
            {
                return false;
            }
            var other = obj as BinarySearchTree<T>;
            return this.SequenceEqual(other);
        }

        public override int GetHashCode()
        {
            return this.Root.GetHashCode();
        }

        public object Clone()
        {
            if (this.Root == null)
            {
                return new BinarySearchTree<T>();
            }
            var newRoot = this.Root.Clone();
            var newTree = new BinarySearchTree<T>();
            newTree.Root = newRoot as TreeNode<T>;
            return newTree;
        }

        public static bool operator ==(BinarySearchTree<T> treeA, BinarySearchTree<T> treeB)
        {
            if (Object.Equals(treeA, null) || Object.Equals(treeB, null))
            {
                return false;
            }
            return treeA.Equals(treeB);
        }
        public static bool operator !=(BinarySearchTree<T> treeA, BinarySearchTree<T> treeB)
        {
            if (Object.Equals(treeA, null) || Object.Equals(treeB, null))
            {
                return false;
            }
            return !treeA.Equals(treeB);
        }
    }
}
