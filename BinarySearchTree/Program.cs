using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(new Node(7));
            bst.Insert(new Node(5));
            bst.Insert(new Node(9));
            bst.Insert(new Node(8));
            bst.Insert(new Node(6));
            bst.Insert(new Node(15));
            bst.Insert(new Node(3));
            bst.Insert(new Node(12));

            // bst.Delete(3);
            // bst.Delete(5);
            bst.Delete(9);
            // bst.Delete(7);
        }
    }
}
