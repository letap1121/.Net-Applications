using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare VendingMachine reference variable.
            VendingMachine vm;

            // Instantiate VendingMachine object.
            vm = new VendingMachine();

            // Test ToString method of vm.
            Console.WriteLine(vm.ToString());

            
            // Try to buy 6 candy bars.  vm has only five candy 
            // bars, so the 6th time will not be successful.
            // Each candy bar requires 3 quarters.
            for (int i = 1; i <= 6; i++) 
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(vm.DepositQuarter());
                }
                Console.WriteLine(vm.SelectCandy());
                Console.WriteLine(vm.ToString());
            }
            Console.ReadLine();

        }
    }
}
