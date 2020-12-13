using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Node<T> : IEquatable<Node<T>>
    {
        public Node(T val)
        {
            data = val;
            next = null;
        }

        public T data { get; set; }
        public Node<T> next { get; set; }

        public bool Equals(Node<T> other)
        {
            return this.GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            return data.GetHashCode();
        }
    }
}
