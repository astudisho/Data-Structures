using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace BinarySearchTree.Models
{
    internal class Node<T> where T : IComparable
    {
        public T Data { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public bool IsLeaf => Left is null && Right is null;

        public Node(T value)
        {
            Data = value;
        }

        public bool IsLessThan(Node<T> other)
        {
            var result = Data.CompareTo(other.Data) < 0;

            return result;
        }

        public static void PrintNode(Node<T> node)
        {
            Console.WriteLine($"Node: {node.Data.ToString()} -->");
        }

        public override string ToString()
        {
            var left = Left is null ? "Null" : Left.Data.ToString();
            var right = Right is null ? "Null" : Right.Data.ToString();
            return $"Data: {Data} Left: {left} Right: {right}";
        }
    }
}
