using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class main
    {
        static void Main(string[] args)
        {
            Queue<string> l = new Queue<string>();

            l.enqueue(new Node<string>("Hello"));
            l.enqueue(new Node<string>("World\n"));
            Console.Write("Printing the content of our queue:\n");
            l.print();

            Console.Write("Using dequeue one time.\nPrinting the content of our queue:\n");
            l.dequeue();
            l.print();
            Queue<int> a = new Queue<int>();
            for (int i=1; i< 20; i++)
            {
                a.enqueue(new Node<int>(i));
                Console.WriteLine("Enqueuing > {0}", i);
            }
            Console.Write("Here is the queue:\n");
            a.print();

            for (int i = 1; i < 5; i++)
            {
                a.dequeue();
                Console.WriteLine("Dequeuing {0} time(s).", i);
            }

            Console.WriteLine("Here is the queue:\n");
            a.print();

            Console.WriteLine("\nPrinting with foreach:\n");
            foreach (int node in a)
            {
                Console.Write("{0} ", node);
            }
            Console.ReadKey();

        }
    }
}
