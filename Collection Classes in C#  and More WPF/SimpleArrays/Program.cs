using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize an array
            int[] items = new int[3];
            //Set each item in the array
            items[0] = 5;
            items[1] = 2;
            items[2] = 7;
            //What would happen if you uncomment the next line?
            //items[3] = 9;

            int total=0;
            foreach (int x in items)
                total = total + x;

            Console.WriteLine("Total adding all items in the array: " + total);
            //Arrays are a type in C#
            Console.WriteLine("Items in array: " + items.Count());
            Console.ReadLine();

        }
    }
}
