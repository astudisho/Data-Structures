using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Models
{
    class DoubleNode<T> : SingleNode<T>
    {
        DoubleNode<T> Previous { get; set; }

        public DoubleNode(T value) : base(value)
        {

        }
    }
}
