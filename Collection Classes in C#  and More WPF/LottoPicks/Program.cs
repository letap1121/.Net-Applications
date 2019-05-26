using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoPicks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the IT 330 Pick 7 Draw! Your lucky numbers are:");
            Urn urn = new Urn(50);
            for (int i = 0; i < 28; i++)
                Console.WriteLine(urn.Draw());
            Console.WriteLine("Press any key to continue.");
            Console.WriteLine(urn.ToString());
            Console.ReadLine();
        }
    }
}
