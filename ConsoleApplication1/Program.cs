using System;
using System.Collections.Generic;
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
            string[] words = {"SHRA'VIKA PARIKH"};
            var intsum = 0;
            foreach (string value in words)
            {
                intsum = 0;
                 foreach (char c in value)
                {
                    //Console.WriteLine(" Char -> " + c.TextToNumber());
                     intsum += (c == ' ' || c == '\'' ? 0 : c.TextToNumber());
                }
                Console.WriteLine(value + " ->" +intsum.ToString());
            }

            
        }

       
    }
}
