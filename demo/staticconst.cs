using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class staticconst
    {
        public int i;
        static staticconst()
        {
            Console.WriteLine("The static statement is executed");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main function is being executed");
        }
    }
}
