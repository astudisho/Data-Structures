using LinkedList.Models;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List");

            var linkedList = new LinkedList<int>();

            linkedList.Insert(1);
            linkedList.Insert(3);
            linkedList.Insert(5);
            linkedList.Insert(7);
            linkedList.Insert(9);            

            linkedList.Traversal(x => Console.WriteLine($" {x} --> "));
        }
    }
}
