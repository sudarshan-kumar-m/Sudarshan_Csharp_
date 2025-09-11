using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class staticconst1
    {
        static int i;
        int b;
        public staticconst1(int a)
        {
            b = a;
            Console.WriteLine("Nc");
        }
        static staticconst1()
        {
            i = 10;
            Console.WriteLine("Sc");
        }
            static void Main()
        {
            staticconst1 a = new staticconst1(10);
            Console.WriteLine(a.b);
            staticconst1 a1 = new staticconst1(11);
            a1.b = 11;
            Console.WriteLine(a1.b);
            Console.WriteLine(a.b);
        }
    }
}
