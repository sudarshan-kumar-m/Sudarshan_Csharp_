using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    struct StructorNested
    {
        int i;
        struct StructorNested1
        {
            public StructorNested m;
            public int y;
        }
        static void Main()
        {
            StructorNested1 n;
            n.m.i = 50;
            Console.WriteLine(n.m.i);
        }
    }

    
}
