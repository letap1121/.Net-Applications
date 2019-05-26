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
            Console.WriteLine("Hello! Welcome to Pick 7 Lotto! Your lucky numbers are:");
            Urn urn = new Urn(10);
            //Urn urn2 = new Urn(100);
            //Urn urn3 = new Urn(200);
            
            for (int i = 0; i < 8; i++)
                Console.WriteLine(urn.Draw());
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }
    }
}
