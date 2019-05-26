using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
            int _validNumber = -1;
            string _input = "";
            //Why is this flag here?  What happens when an invalid number is entered into TryParse
            bool _userNotDone = true;

            do
            {
                Console.Write("Please enter a number greater than or equal to 0:");
                _input = Console.ReadLine();
                if (!int.TryParse(_input, out _validNumber))
                {
                    Console.WriteLine("Sorry. That is not a valid number. Please try again.");
                }
                else if (_validNumber < 0)
                {
                    Console.WriteLine("Sorry. Number must be greater than or equal to 0.");
                }
                else
                {
                    _userNotDone = false;
                }
            }
            while (_userNotDone == true || _validNumber < 0) ;

            Console.WriteLine("You entered {0}", _validNumber);
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
        }
    }
}
