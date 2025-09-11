using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class variables
    {
        static int v;
        public int y;
        const int x=4;
        readonly int z=1000;
        public variables(int num)
        {
            z = num;
            z = 300;
        }
        public variables(variables other)
        {
            z = other.z+100;
        }
        static void Main(string[] args)
        {
            variables d = new variables(500);
            variables b = new variables(d);
            v = 100;
            d.y = 200;
            Console.WriteLine($"{v}\n{d.y}\n{x}\n{b.z}");
        }

    }
}
;