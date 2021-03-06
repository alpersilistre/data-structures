﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree();

            bst.Insert(50); 
            bst.Insert(30); 
            bst.Insert(20); 
            bst.Insert(40); 
            bst.Insert(70); 
            bst.Insert(60); 
            bst.Insert(80);

            bst.Traverse();

            bst.Search(40);
            bst.Search(45);
        }
    }
}
