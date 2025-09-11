using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class inheritance_sub:inheritance_add
    {
        public int C, D;
        public inheritance_sub() : base(4, 5)
        {
            Console.WriteLine("Child");
            C= 9; D = 4;
        }
        public void subdisplay()
        {
            Console.WriteLine($"sub of 2 number:{C - D}");
        }
        static void Main()
        {
            inheritance_sub c=new inheritance_sub();
            c.Adddisplay();
            c.subdisplay();

        }
    }
}
