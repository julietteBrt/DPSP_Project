using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Map<T>
    {
        Node<T> root;
        Func<T, T> function;
        ConcurrentQueue<Node<T>> waitingQueue;
        Node<T> rootResults;

        public Map(Node<T> firstElement, Func<T, T> function, Node<T> firstResult)
        {
            this.root = firstElement;
            this.function = function;
            waitingQueue = new ConcurrentQueue<Node<T>>();
            this.rootResults = firstResult;
        }

        public Node<T> run()
        {
            Node<T> current = this.root;
            Node<T> res = this.rootResults;
            while(current != null)
            {
                res.data = function(current.data);
                res = res.next;
                current = current.next;
            }
            return rootResults;
        }
        
    }
}
