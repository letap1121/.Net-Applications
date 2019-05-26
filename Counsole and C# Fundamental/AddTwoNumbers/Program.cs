using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    class Program
    {
        ///Define a property on the class.
        int globalValue = 5;

        static void Main(string[] args)
        {
            Program p = new Program();
           
           Console.WriteLine("Adding 2 and 5 result in " + p.AddTwoNumbers(2, 5));
 
            //Notice here that we pass the result of one call of AddTwoNumbers into another.
           Console.WriteLine("Adding the result of adding 2 and 5 to 7 equals " + p.AddTwoNumbers(p.AddTwoNumbers(2, 6), 7));

            int x = p.AddTwoNumbers(10, 10);
            int y = p.MultiplyGlobalValueByParam(x);
            //Notice here that we pass the result of one call of AddTwoNumbers into another.
            Console.WriteLine("Lets take the result of adding 10 + 10 and pass it to MultiplyGlobalValueByParam equals " + y);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

       int AddTwoNumbers(int a, int b)
        {
            //value is locally scoped
            int _value;
            _value = a + b;
            return _value;
        }

        int MultiplyGlobalValueByParam(int a)
        {
            //notice we declare value again. We can since it is locally scoped
            globalValue = globalValue + 1;
            int value = globalValue * a;
            return value;
        }
    }
}
