using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string _name = Console.ReadLine();
            //Concatination
            // Console.WriteLine("Hello, " + _name + ".");
            //Formatted String
            Console.WriteLine("Hello, {0}.", _name);
            //C# 6.0 formatted string
            //Console.WriteLine($"Hello, {_name}.");
            Console.ReadLine();
        }
    }
}
