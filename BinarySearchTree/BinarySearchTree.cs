using System;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        Node root = null;

        public void Search(int value)
        {
            if (root != null)
            {
                var node = Search(root, value);
                
                if (node != null)
                {
                    Console.WriteLine("Given node is found!");
                }
                else 
                {
                    Console.WriteLine("Given node does not exist in the BST.");    
                }
                
            }
            else
            {
                Console.WriteLine("Given node does not exist in the BST.");
            }
        }
        private Node Search(Node root, int value)
        {
            if (root.Value == value)
            {
                return root;
            }
            else if (root.Value > value)
            {
                if (root.Left != null)
                {
                    return Search(root.Left, value);
                }
            }
            else
            {
                if (root.Right != null)
                {
                    return Search(root.Right, value);
                }
            }

            return null;
        }

        public void Insert(int value)
        {
            root = Insert(this.root, value);
        }

        private Node Insert(Node root, int value)
        {
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