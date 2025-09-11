using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    struct structor1
    {
        public int x;

        static void Main()
        {
            structor1 s;
            s.x = 1;

            structor1 t=s;
            
            Console.WriteLine(t.x);
            Console.WriteLine(s.x);
            s.x = 2;
            Console.WriteLine(t.x);
            Console.WriteLine(s.x);
        }
    }
}
