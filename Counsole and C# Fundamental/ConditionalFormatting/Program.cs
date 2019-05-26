using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "Originating as the Department of Computer Science at DePaul University, the College of Computing and Digital Media (CDM) has evolved in the past two decades into an interdisciplinary college with a broad range of innovative programs. The college is organized into three schools: the School of Computing (SoC), School of Cinematic Arts (CIM) and School of Design (SoD).";

            foreach (String s in a.Split(' '))
            {
                if (s == "of")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(s);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }
}
