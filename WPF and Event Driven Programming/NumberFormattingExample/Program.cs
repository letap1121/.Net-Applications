using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFormattingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1200.345;

            Console.WriteLine(x.ToString());
            //Currency
            Console.WriteLine(x.ToString("C"));

            //Numberic format
            Console.WriteLine(x.ToString("N"));

            //Display digit even if nonsignificant zero
            Console.WriteLine(x.ToString("0000000"));

            //Only display digit if significant.
            Console.WriteLine(x.ToString("#######"));

            //Decimal point
            Console.WriteLine(x.ToString("0.00"));
             
            //Literal String
            Console.WriteLine(x.ToString("#' pounds'"));

            DateTime dt = DateTime.Now;

            Console.WriteLine(dt.ToString());
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToUniversalTime());

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
    }
}
