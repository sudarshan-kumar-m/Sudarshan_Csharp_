using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Getter
    {
        public int s = Get();
        public static int Get()
        {

            return 8;
        }
        static void Main()
        {
            Getter getter = new Getter();
            Console.WriteLine(getter.s);
        }
    }
}
