using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Queue
            Queue<string> queue = new Queue<string>();
            //Add Item to Queue
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");
            //Remove item from Queue
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("D");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            queue.Enqueue("E");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            Console.ReadLine();



        }
    }
}
