using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    internal class Class1
    {
        int i;
        public Class1(int x)
        {
            i = x;
        }
        static void Main(string[] args)
        {
            Class1 a = new Class1(10);
            Console.WriteLine(a.i);
        }
    }
}
