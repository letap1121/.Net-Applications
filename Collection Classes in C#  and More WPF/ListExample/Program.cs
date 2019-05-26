using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);
            List<string> cities = new List<string>();
            
            cities.Add("Chicago");
            cities.Add("San Diego");
            cities.Add("Atlanta");
            cities.Add("Boston");
            cities.Add("Seattle");
            cities.Add("Dallas");
            cities.Add("Kalamazoo");

            Console.WriteLine("\nView the List");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\nView the List Sorted.");
            cities.Sort();
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("\nView the List Reversed.");
            cities.Reverse();
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();

        }
    }
}
