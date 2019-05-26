using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickCounter3
{
    class Program
    {
        static void Main(string[] args)
        {
            int _numClicks = 0;
            string _val = "";
            Console.WriteLine("Press the return key multiple times.");
            Console.Write("Press X to terminate the application.");
            do
            {
                _val = Console.ReadLine().ToLower();
                if (_val != "x")
                {
                    _numClicks++;
                    Console.Write("Number of clicks is " + _numClicks + ".");
                }
            }
            while (_val != "x");
            Console.WriteLine("Thanks for using the application! Press any key to continue.");
            Console.ReadLine();
        }
    }
}
