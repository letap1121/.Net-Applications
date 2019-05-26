using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeder
{
    class Program
    {
        static void Main(string[] args)
        {
            string _input;
            int _speed = 0;
            Console.Write("Please enter your speed:");
            _input = Console.ReadLine();
            if (int.TryParse(_input, out _speed))
            {
                if (_speed <= 30)
                {
                    Console.WriteLine("You are going slow.");
                }
                else if (_speed > 30 && _speed <= 55)
                {
                    Console.WriteLine("You are going normal speed.");
                }
                else if (_speed > 55 && _speed < 100)
                {
                    Console.WriteLine("You are going too fast.");
                }
                else
                {
                    Console.WriteLine("You're crazy!");
                }
            }
            else
            {
                Console.WriteLine("Not a valid number.");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

        }
    }
}
