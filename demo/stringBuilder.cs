using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class stringBuilder
    {
        static void Main(string[] args)
        {
            string str = "";
            Stopwatch sw1= new Stopwatch();
            sw1.Start();
            for (int i = 0; i < 100000; i++)
            {
                str = str + i;
            }
            sw1.Stop();
            StringBuilder a = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < 100000; i++)
            {
                a.Append(i);
            }
            sw2.Stop();
            Console.WriteLine(sw1.ElapsedMilliseconds);
            Console.WriteLine(sw2.ElapsedMilliseconds);
        }
    }
}
