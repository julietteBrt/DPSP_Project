using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Queue <T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new QueueEnumerator<T>(this);
        }

        public Node<T> root { get; set; }

        public void enqueue(Node<T> node)
        {
            Node<T> new_node = new Node<T>(node.data);

            if (root == null)
                root = new_node;

            else
            {
                // Get the last element of our queue.
                Node<T> current = root;
                while (current.next != null)
                    current = current.next;

                // Add the new element after the last one.
                current.next = new_node;
            }
        }

        public void dequeue()
        {
            if (root != null)
            {
                Node<T> next_node = root.next;
                Node<T> current = null;
                root = next_node;
                next_node = root.next;
                while (next_node != null)
                {
                    current = next_node;
                    next_node = current.next;
                }
            }
        }

        public Node<T> getNode(int idx)
        {
            Node<T> current = root;
            int pos = 0;

            while (current != null)
            {
                if (pos == idx)
                    return current;

                current = current.next;
                pos++;
            }

            return null;
        }

        //Override operator [] for SingleLinkedList objects
        public Node<T> this[int index]
        {
            get
            {
                return getNode(index);
            }
        }


        public Node<T> getNode(Node<T> elem)
        {
            Node<T> current = root;
            int pos = 0;

            while (current != null)
            {
                if (current.Equals(elem))
                    return current;

                current = current.next;
                pos++;
            }

            return null;
        }

        public void print()
        {
            Node<T> current = root;

            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }

    }
}
