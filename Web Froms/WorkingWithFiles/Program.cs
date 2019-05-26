using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";
            const string filePath = "cache.txt";
            //Open a stream to APPEND to the file
            StreamWriter writer = new StreamWriter(filePath,true);
            //Give the user instructions
            Console.WriteLine("Enter text to add to file and then press enter. Enter X to Exit.");
            do
            {
                //Check if the user entered input
                if(!String.IsNullOrEmpty(val))
                    //Write input to file
                    writer.WriteLine(val);
                //Read input from user
                val = Console.ReadLine();
            }
            //Check if user entered X to exit.
            while (val != "X");
            //Close the stream
            writer.Close();

            //Write the file content to the screen.
            Console.WriteLine("\nContents of the File:");
            Console.ForegroundColor = ConsoleColor.Green;
            //Open the Reader stream
            StreamReader reader = new StreamReader(filePath);
            Console.WriteLine(reader.ReadToEnd());
            Console.ForegroundColor = ConsoleColor.Gray;
            //Close the reader stream.
            reader.Close();
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
    }
}
