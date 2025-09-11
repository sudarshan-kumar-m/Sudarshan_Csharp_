using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class LamdaExpression
    {
        static void Main(string[] args)
        {
            int? a = 100;
            int b = 200;
            Func<int?,int,int?> c=delegate (int? x,int y) { return x + y; };
            Console.WriteLine(c(a, b));
        }
    }
}
