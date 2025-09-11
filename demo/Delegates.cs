using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate void AddDelegate(int a, int b);
    public delegate void GreetDelegate(string a);
    public delegate void DisplayDelegate();
    public class Delegates
    {
        public void Display()
        {
            Console.WriteLine("Welcome");
        }
        public void add(int x, int y)
        {
            Console.WriteLine($"{x} + {y}:{x+y}");
        }
        public static void Greet(string s)
        {
            Console.WriteLine(s);
        }
        static void Main()
        {
            Delegates h = new Delegates();
            AddDelegate ad = new AddDelegate(h.add);
            GreetDelegate g = new GreetDelegate(Greet);
            DisplayDelegate k = new DisplayDelegate(h.Display);
            ad(300, 400);
            g("karthik");
            k();


        }
    }
    public class Delegates1
    {
        static void Main()
        {
            Delegates d = new Delegates();
            AddDelegate m = new AddDelegate(d.add);
            GreetDelegate n = new GreetDelegate(Delegates.Greet);
            m(100, 200);
            n("Manoj");
            
        }
        
    }
}
