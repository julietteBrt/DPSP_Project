using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class QueueEnumerator<T> : IEnumerator<T>
    {
        private int index;
        private Queue<T> queue;

        public QueueEnumerator(Queue<T> myqueue)
        {
            index = -1;
            queue = myqueue;
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            index++;
            Node<T> element = queue.getNode(index);
            return element != null;
        }

        public T Current
        {
            get
            {
                Node<T> element = queue.getNode(index);
                if (element == null)
                {
                    return default(T);
                }
                return element.data;
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
