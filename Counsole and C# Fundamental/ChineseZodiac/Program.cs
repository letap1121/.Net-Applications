using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChineseZodiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string _input="", _animal="";
            int _year;

            //Keep going until 'q' value is entered.
            while (_input != "q")
            {
                Console.Write("Enter a legal year, \"q\" to quit: ");
                _input = Console.ReadLine();
                //Check if we have a valid int.
                if (int.TryParse(_input, out _year) && _year >= 1)
                {
                    switch (_year % 12)
                    {
                        case 0: _animal = "monkey"; break;
                        case 1: _animal = "rooster"; break;
                        case 2: _animal = "dog"; break;
                        case 3: _animal = "pig"; break;
                        case 4: _animal = "rat"; break;
                        case 5: _animal = "ox"; break;
                        case 6: _animal = "tiger"; break;
                        case 7: _animal = "rabbit"; break;
                        case 8: _animal = "dragon"; break;
                        case 9: _animal = "snake"; break;
                        case 10: _animal = "horse"; break;
                        default: _animal = "sheep"; break;
                    }
                    Console.WriteLine("The Chinese zodiac animal for the year " +
                        _year + " is the " + _animal + ".");
                }
            }
        }
    }
}
