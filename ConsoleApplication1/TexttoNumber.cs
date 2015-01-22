using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class TexttoNumber
    {
        public static int TextToNumber(this char text)
        {
            //return text
            //    .Select(c => c - 'A' + 1)
            //    .Aggregate((sum, next) => sum * 26 + next);
            return (text - 'a') + 1;
        }
    }
}
