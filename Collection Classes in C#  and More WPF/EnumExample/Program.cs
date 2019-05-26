using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumExample
{
    class Program
    {
        // In this enum the numbers will go sequentially starting with 0
        enum Severity
        {
            None,
            Minor,
            Medium,
            Severe,
            Critical
        }
        static void Main(string[] args)
        {
            //Set the severity.  
            Severity currentStatus = Severity.Severe;

            //Lets use the ConsoleColor enum found in System Namespace
            //Example : Console.ForegroundColor = ConsoleColor.Red;

            //switch on the severity and print out an "appropriate" message.
            switch(currentStatus)
            {
                case Severity.None: Console.ForegroundColor = ConsoleColor.Green;  Console.WriteLine("All good!"); break;
                case Severity.Minor: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Gonig back to sleep!"); break;
                case Severity.Medium: Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("I'll just reboot it!"); break;
                case Severity.Severe: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Hoping someone else fixes it!"); break;
                case Severity.Critical: Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Don't fire me!"); break;
            }

            //Keep window open to see output.
            Console.ReadLine();
        }
    }

}
