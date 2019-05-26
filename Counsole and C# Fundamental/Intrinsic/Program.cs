using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intrinsic
{
    class Program
    {
        static void Main(string[] args)
        {

            //What is the + operator doing below?

            int _i = 0;
            Console.WriteLine("I'm an Integer stored in variable i and my value is " + _i );

            bool _b = true;
            Console.WriteLine("I'm a boolean stored in variable b and my value is " + _b );

            char _c = 'c';
            Console.WriteLine("I'm a char stored in variable c and my value is " + _c );

            bool _result;
            Console.WriteLine("Is the value 'okey dokey' a valid Boolean expression?  Lets ask the Boolean type: " + Boolean.TryParse("okey dokey", out _result));

            String x = "5";
            int _val;
            bool isInt = Int32.TryParse(x, out _val);
			
        }
    }
}
