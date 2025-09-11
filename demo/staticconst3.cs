using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class staticconst3
    {
        static staticconst3()
        {
            Console.WriteLine("Static constructor is ececuted");
        }
        public void display()
        {
            Console.WriteLine("display function:");
            Display();
        }
        static void Display()
        {
            Console.WriteLine("Static function is displayed:");
        }
        static void Main(string[] args)
        {
            staticconst3 k = new staticconst3();
            Console.WriteLine("Main function");
            Display();
            k.display();

        }
    }
}
