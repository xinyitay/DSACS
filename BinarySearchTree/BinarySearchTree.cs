using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public Node Find(int key)
        {
            Node curr = root;

            while (curr != null) {
                if (key == curr.Key) {
                    break;
                }
                else if (key <= curr.Key) {
                    curr = curr.Left;
                }
                else if (key > curr.Key) {
                    curr = curr.Right;
                }
            }

            return curr;
        }

        public bool Insert(Node n)
        {
            if (n == null) {
                return false;
            }

            if (root == null) {
                root = n;
            }
            else {
                Node curr = root;
                while (true) {
                    if (n.Key <= curr.Key) {
                        if (curr.Left == null) {
                            curr.Left = n;
                            break;
                        }
                        else {
                            curr = curr.Left;
                        }
                    }
                    else {
                        if (curr.Right == null) {
                            curr.Right = n;
                            break;
                        }
                        else {
                            curr = curr.Right;
                        }
                    }
                }
            }

            return true;
        }

        public bool Delete(int key)
        {
            Node curr = root;
            Node parent = null;

            while (curr != null) {
                if (key == curr.Key) {
                    // case 1: deleting a leaf node
                    if (curr.Left == null && curr.Right == null) {
                        if (parent == null) {
                            root = null;
                        }
                        else if (parent.Left == curr) {
                            parent.Left = null;
                        }
                        else {
                            parent.Right = null;
                        }
                    }
                    // case 2: deleting a node with only one child node
                    else if (curr.Left == null || curr.Right == null) {
                        Node child = (curr.Left == null) ? curr.Right : curr.Left;
                        if (parent == null) {
                            root = child;
                        }
                        else if (parent.Left == curr) {
                            parent.Left = child;
                        }
                        else {
                            parent.Right = child;
                        }
                    }
                    // case 3: deleting a node with two child nodes
                    else {
                        Node min = curr.Right;
                        Node prev = curr;
                        while (min.Left != null) {
                            prev = min;
                            min = min.Left;
                        }
                        if (min != curr.Right) {
                            prev.Left = null;
                        }
                        if (curr.Left != min) {
                            min.Left = curr.Left;
                        }
                        if (curr.Right != min) {
                            min.Right = curr.Right;
                        }

                        if (parent == null) {
                            root = min;
                        }
                        else if (parent.Left == curr) {
                            parent.Left = min;
                        }
                        else if (parent.Right == curr) {
                            parent.Right = min;
                        }
                    }
                    return true;
                }
                else if (key <= curr.Key) {
                    parent = curr;
                    curr = curr.Left;
                }
                else {
                    parent = curr;
                    curr = curr.Right;
                }
            }

            return false;
        }

        public Node GetRootNode()
        {
            return root;
        }
    }
}

