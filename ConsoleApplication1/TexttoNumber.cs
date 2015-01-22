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
            return (text - 'a') + 1;
        }
    }
}
