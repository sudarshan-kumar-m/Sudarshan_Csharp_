using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    
    internal class AbstractChild:AbstractParent
    {
        //public override void mul(int a, int b)
        //{
        //    Console.WriteLine($"{a} * {b} = {a*b}");
        //}
        //public override void div(int a, int b)
        //{
        //    Console.WriteLine($"{a} / {b} = {a/b}");
        //}
        public new void Display()
        {
            Console.WriteLine("Method in child class");
        }
        static void Main()
        {
            AbstractParent m = new AbstractChild();
            m.add(4, 6);
            m.sub(9, 5);
            //m.mul(10, 5);
            //m.div(10, 5);
            Console.WriteLine();
            AbstractChild n= new AbstractChild();
            n.add(100, 50);
            n.sub(100, 50);
            //n.mul(100, 50);
            //n.div(100, 50);
            n.Display();
        }
    }
}
