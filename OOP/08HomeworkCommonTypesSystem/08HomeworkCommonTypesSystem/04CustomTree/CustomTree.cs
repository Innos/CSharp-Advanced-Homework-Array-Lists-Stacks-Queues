using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04CustomTree
{
    class CustomTree
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            BinarySearchTree<int> tree3 = new BinarySearchTree<int>();
            
            tree3.Add(30);
            tree3.Add(10);
            tree3.Add(5);
            tree3.Add(25);

            bst.Add(20);
            bst.Add(30);
            bst.Add(10);
            bst.Add(5);
            bst.Add(25);
            bst.Add(25);

            Console.WriteLine();
            BinarySearchTree<int> bstClone = bst.Clone() as BinarySearchTree<int>;

            Console.WriteLine(bst.Contains(10));
            Console.WriteLine(bst.Contains(11));
            Console.WriteLine(bst.Equals(tree3));
            Console.WriteLine();

            Console.WriteLine(bst == bstClone);
            Console.WriteLine(bst != bstClone);

            Console.WriteLine(bstClone.ToString());
            bstClone.Delete(5);
            Console.WriteLine(bstClone.ToString());
            Console.WriteLine(bst);
            Console.WriteLine(bst == bstClone);

            Console.WriteLine();
            foreach (var entry in bst)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine(bst.ToString());
            Console.WriteLine(bst.GetHashCode());

        }
    }
}
