using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
             //Trace the output before running it

            //Initialize Stack
            Stack<string> stack = new Stack<string>();
            //Add Item to Stack
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            //Remove item from Stack
            Console.WriteLine(stack.Pop());
            stack.Push("D");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Push("E");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
