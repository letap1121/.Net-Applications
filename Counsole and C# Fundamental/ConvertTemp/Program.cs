using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int _cel, _fahr;
            Console.Write("Enter a Celsius temperature: ");
            string _input = Console.ReadLine();
            //Int32.Parse. What is wrong with this code?
             _cel = Int32.Parse(_input);
            //_fahr = 9 * _cel / 5 + 32;
            _fahr = (((9 * _cel) / 5) + 32);
            string _output = _fahr.ToString();
            //Console.WriteLine("Fahrenheit temperature is " + _output + ".");
            Console.WriteLine($"Fahrenheit temperature is {_output}.");
            Console.ReadLine();

            
        }
    }
}
