using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class method_overriding
    {
        public virtual void display()
        {
            Console.WriteLine("parent class method is being executed");
        }
        static void Main(string[] args)
        {
            method_overriding q=new method_overriding();
            q.display();

        }
    }
    class method_overriding1 : method_overriding
    {
        public void parentdisplay() // to access the display function of parent class
        {
            base.display();
        }
        public override void display()
        {
            Console.WriteLine("Child class methosd is being executed");
        }
        static void Main()
        {
            method_overriding1 a = new method_overriding1();
            a.display();
            a.parentdisplay();

            method_overriding b = a;       // parent can access the override function of child class by creating instance of parent class using child class
            b.display();

            method_overriding d = new method_overriding();
            a.display();
        }

    }
}
