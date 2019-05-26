using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize the Dictionary with a Stirng for a Key and Int as a value
            Dictionary<string, int> wordDictionary = new Dictionary<string, int>();
            String para = "Originating as the Department of Computer Science at DePaul University, the College of Computing and Digital Media (CDM) has evolved in the past two decades into an interdisciplinary college with a broad range of innovative programs. The college is organized into three schools: the School of Computing (SoC), School of Cinematic Arts (CIM) and School of Design (SoD).";
            
            //Grab each work from the paragraph
            foreach (String word in para.Split(' '))
            {
                //Check if the word is in the dictionary
                if (wordDictionary.ContainsKey(word))
                {
                    //Add one to count if it is in the dictionary
                    wordDictionary[word]++;
                }
                else
                {
                    //Add word to the dictionary
                    wordDictionary.Add(word, 1);
                }
            }

            //Loop through each key in the dictionary
            foreach(String word in wordDictionary.Keys)
            {
                //Write the word and the amount of occurances.
                Console.WriteLine("{0} - {1}", word, wordDictionary[word].ToString());
            }

            Console.ReadLine();
        }
    }
}
