using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string _password = "";
            ConsoleKeyInfo keyPressed;
            Console.WriteLine("Please enter password:");
            do
            {
                keyPressed = Console.ReadKey(true);

                if (keyPressed.Key != ConsoleKey.Enter)
                {
                    _password += keyPressed.KeyChar;
                    Console.Write("*");
                }
            }
            while (keyPressed.Key != ConsoleKey.Enter);
            Console.WriteLine("\nYou entered: " + _password +". Press any key to continue.");
            Console.ReadLine();
        }
    }
}
