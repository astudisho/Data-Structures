using BinarySearchTree.Models;
using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");

            var tree = new BinaryTree<int>();

            tree.InsertNode(new Node<int>(50));
            tree.InsertNode(new Node<int>(25));
            tree.InsertNode(new Node<int>(10));
            tree.InsertNode(new Node<int>(5));
            tree.InsertNode(new Node<int>(75));
            tree.InsertNode(new Node<int>(100));
            tree.InsertNode(new Node<int>(60));

            Console.WriteLine("Pre Order");
            tree.PreOrderTraversal(x => Console.WriteLine(x.ToString()));
            Console.WriteLine();
            Console.WriteLine("In Order");
            tree.InOrderTraversal(x => Console.Write($" {x} -->"));
            Console.WriteLine();
            Console.WriteLine("Post Order");
            tree.PostOrderTraversal(x => Console.Write($" {x} -->"));

            var searchNumber = 50;
            Console.WriteLine();
            Console.WriteLine($"Found: {searchNumber} {tree.Search(searchNumber,out var node)} {node}");

            searchNumber = 5;
            Console.WriteLine();
            Console.WriteLine($"Found: {searchNumber} {tree.Search(searchNumber, out node)} {node}");

            searchNumber = 100;
            Console.WriteLine();
            Console.WriteLine($"Found: {searchNumber} {tree.Search(searchNumber, out node)} {node}");
        }
    }
}
