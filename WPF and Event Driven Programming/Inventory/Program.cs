using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Trace the output of this code. \n");
            Product saleProduct = new Product();
  
            //saleProduct.
            saleProduct.PriceChanged += Program.PriceChanged;
            saleProduct.Price = 30;
            Console.WriteLine(saleProduct.ToString());
            saleProduct = null; //releases for garbage collection

            saleProduct = new Product("Bat");
            saleProduct.PriceChanged += Program.PriceChanged;
            Console.WriteLine(saleProduct.ToString());
            saleProduct = null; //releases for garbage collection

            saleProduct = new Product("Bike",100);
            saleProduct.PriceChanged += Program.PriceChanged;
            Console.WriteLine(saleProduct.ToString());
            saleProduct = null; //releases for garbage collection

            saleProduct = new Product("Ball", 10);
            saleProduct.Name = "Widget";
            saleProduct.PriceChanged += Program.PriceChanged;
            saleProduct.Price = 20;
            Console.WriteLine(saleProduct.ToString());
            saleProduct = null; //releases for garbage collection

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
        }

        public static void PriceChanged(decimal oldPrice, decimal newPrice)
        {
            //Notice the string formatting:
            Console.WriteLine("I detected the price changed. Price went from {0} to {1}.", oldPrice, newPrice );
        }
    }
}
