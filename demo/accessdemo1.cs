using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal sealed class accessdemo1:accessdemo
    {
        private accessdemo1() { }
        static void Main()
        {

            accessdemo1 g = new accessdemo1();
            //g.Setage(24);
            Console.WriteLine(g.Getage());        
            accessdemo m = new accessdemo();
        }
    }
}
