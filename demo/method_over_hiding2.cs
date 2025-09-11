using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class method_over_hiding2:method_over_hiding
    {
        public void parentdisplay()
        {
            base.display();
        }
        static void Main(string[] args)
        {
            method_over_hiding s = new method_over_hiding();     // creating reference of parent class using child class
            s.display();

            //method_over_hiding2 r=new method_over_hiding2();       //using base keyword
            //r.parentdisplay();



        }
    }
}
