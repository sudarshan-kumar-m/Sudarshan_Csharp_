using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class inheritance_add
    {
        public int A, B;
        public inheritance_add(int a,int b)
        {
            Console.WriteLine("Parent");
            A = a;
            B = b;
        }
        public void Adddisplay()
        {
            Console.WriteLine("addition of 2 number:" + (A + B));
        }
    }
}
