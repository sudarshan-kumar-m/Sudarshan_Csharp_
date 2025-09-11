using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class copyconst
    {
        int i,k;
      public copyconst(int s)
        {
            i = s;
        }
        public copyconst(copyconst obj)
        {
            i = obj.i;
        }
        public void Display()
        {
            Console.WriteLine(i);
        }

        static void Main()
        {
            copyconst a=new copyconst(10);
            copyconst b = new copyconst(a);
            copyconst c = a;
            a.i = 20;
            //b.i = 0;
            a.Display();
            b.Display();
        }
    }
}
