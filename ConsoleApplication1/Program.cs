using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string s = "PEACE";
            string[] words = File.ReadLines(@"..\..\File\american-words.txt").ToArray();
            var intsum = 0;
            foreach (string value in words)
            {
                intsum = 0;
                 foreach (char c in value)
                {
                     intsum += (c == ' ' || c == '\'' ? 0 : c.TextToNumber());
                     //Console.WriteLine("char ->" + c + "number " + c.TextToNumber().ToString());
                }
                //Console.WriteLine(value + " ->" +intsum.ToString());
                 if (intsum == 100)
                     Console.WriteLine("100 words -> " + value);
            }

            
        }

       
    }
}
