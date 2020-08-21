using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    public class SingleNode<T>
    {
        public T Data { get; set; }
        public SingleNode<T> Next { get; set; }

        public SingleNode(T value)
        {
            Data = value;
        }        
    }
}
