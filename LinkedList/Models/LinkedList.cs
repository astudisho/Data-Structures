using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    public class LinkedList<T>
    {
        private SingleNode<T> Start { get; set; }

        private static int _nodeCount = 0;

        public static int NodeCount => _nodeCount;

        public void Insert(T value) => Insert(value, Start);

        private void Insert(T value, SingleNode<T> current)
        {
            if(current is null)
            {
                current = new SingleNode<T>(value);
            }
            else
            {
                Insert(value, current.Next);
            }
        }

        private bool Delete(T value, SingleNode<T> currentNode, SingleNode<T> previousNode = null)
        {
            if (currentNode is null) return false;

            if(value.Equals(currentNode.Data))
            {
                currentNode = null;
                return true;
            }
            else
            {
                var result = Delete(value, currentNode.Next, currentNode);
                return result;
            }
        }

        public void Traversal(Action<T> action) => Traversal(action, Start);
        private void Traversal(Action<T> action, SingleNode<T> currentNode)
        {
            if (currentNode is null) return;

            action(currentNode.Data);
            Traversal(action, currentNode.Next);
        }
    }
}
