using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        Node root = null;

        public void Insert(int value)
        {
            root = Insert(this.root, value);
        }

        private Node Insert(Node root, int value) {
            if (root == null) {
                root = new Node(value);
            }
            else if (value < root.Value) {
                root.Left = Insert(root.Left, value);
            }
            else if (value > root.Value) {
                root.Right = Insert(root.Right, value);
            }

            return root;
        }

        public void Traverse()
        {
            if (root != null) {
                Traverse(root);
            }
            else
            {
                Console.WriteLine("BST is empty");
            }
        }

        private void Traverse(Node root)
        {
            if (root != null)
            {
                Traverse(root.Left);
                Console.WriteLine(root.Value);
                Traverse(root.Right);
            }
        }
    }
}