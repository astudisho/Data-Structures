using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree.Models
{
    class BinaryTree<T> where T : IComparable
    {
        Node<T> Root;

        static int NodeCount = 0;

        public void InsertNode(Node<T> node)
        {
            if (Root is null)
            {
                Root = node;
                return;
            }
            InsertNode(Root, node);
            NodeCount++;
        }

        private void InsertNode(Node<T> root, Node<T> node)        
        {
            // Base Case.
            if (root is null)
            {
                root = node;
                return;
            }

            // Less than.
            if (node.IsLessThan(root))
            {
                if(root.Left is null)
                {
                    root.Left = node;
                    return;
                }
                InsertNode(root.Left, node);
                return;
            }
            if (root.Right is null)
            {
                root.Right = node;
                return;
            }
            // Greater than.
            InsertNode(root.Right, node);
        }

        public void PreOrderTraversal(Action<T> action) => PreOrderTraversal(action, Root);
        private void PreOrderTraversal(Action<T> action, Node<T> node)
        {
            // Base case, is a leaf.
            if (node is null) return;

            // Process actual node.
            action(node.Data);
            // Process minor node.
            PreOrderTraversal(action, node.Left);
            // Process greater node.
            PreOrderTraversal(action, node.Right);
        }

        public void InOrderTraversal(Action<T> action) => InOrderTraversal(action, Root);

        private void InOrderTraversal(Action<T> action, Node<T> node)
        {
            // Base case, is a leaf.
            if (node is null) return;

            // Process minor node.
            InOrderTraversal(action, node.Left);
            // Process actual node.
            action(node.Data);
            // Process greater node.
            InOrderTraversal(action, node.Right);
        }
        public void PostOrderTraversal(Action<T> action) => PostOrderTraversal(action, Root);

        private void PostOrderTraversal(Action<T> action, Node<T> node)
        {
            // Base case, is a leaf.
            if (node is null) return;

            // Process minor node.
            PostOrderTraversal(action, node.Left);
            // Process greater node.
            PostOrderTraversal(action, node.Right);
            // Process actual node.
            action(node.Data);
        }

    }
}

