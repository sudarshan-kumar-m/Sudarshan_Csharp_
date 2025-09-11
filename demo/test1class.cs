using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class test1class
    {
        public int m;
        static void Main()
        {
            test1class a1 = new test1class();
            a1.m = 10;
            test1class a2 = a1;
            Console.WriteLine(a1.m);
            Console.WriteLine(a2.m);
            a2.m = 11;
            Console.WriteLine(a1.m);
            Console.WriteLine(a2.m);
        }
    }
}
