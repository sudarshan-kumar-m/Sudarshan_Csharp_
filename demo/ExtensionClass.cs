using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ExtensionClass 
    {
        public void Write()
        {
            Console.WriteLine("Writing....");
        }
        public void add(double a,double b)
        {
            Console.WriteLine($"{a} + {b}:{a + b}");
        }public void sub(double a, double b)
        {
            Console.WriteLine($"{a} - {b}:{a - b}");
        }
        public void Display()
        {
            Console.WriteLine("Method in main class");
        }
        static void Main()
        {
            ExtensionClass a= new ExtensionClass();
            a.mul(10, 20);
            a.div(100, 200);
        }
        
    }
    interface InterfaceClass
    {
        void Write();
    }
}
