using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    abstract class Method
    {
        public abstract void add(int a, int b);
        
    }
    abstract class AbstractParent:Method
    {
        public int s=20;
        public static int a;
        public AbstractParent()
        {
            Console.WriteLine("Constructor method");
        }
        public static void Display()
        {
            Console.WriteLine($"The value of a is:{a}");
        }
        public override void add(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a+b}");
        }
        public void sub(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        //public abstract void mul(int a, int b);
        //public abstract void div(int a, int b);
        static void Main()
        {
            a = 200;  //can't creat objects but we can use static members
            Display();
            

        }
    }
}
