using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedClass
{
    internal sealed class Outer
    {
        private static int s=10;
        public class Inner
        {
            public int d=Outer.s;
             public void Method2()
            {
                Console.WriteLine("Method 2 of inner class is executed....");
            }
            public static void StaticMethod1()
            {
                Console.WriteLine("Static method 1 is printed..........");
            }
            static void Main()
            {
                Outer c = new Outer();
                Inner a = new Inner();
                a.Method2();
                c.Method();
                s = 40;
                //c.d = 100;
                StaticMethod2();
                StaticMethod1();
            }
        }
        public void Method()
        {
            Console.WriteLine("Method 1 of Outer class is executed.....");
        }
        private static void StaticMethod2()
        {
            Console.WriteLine("Static method 2 is printed..........");
        }
        static void Main()
        {
            Outer.Inner e = new Outer.Inner();
            Outer b = new Outer();
            Inner d = new Inner();  
            b.Method();
            d.Method2(); 
            e.Method2();
            Inner.StaticMethod1();
            StaticMethod2();
            //e.Method();  cannot access
        }
    }
    internal class NestedClass
    {
        static void Main()
        {
            Outer.Inner a = new Outer.Inner();
            a.Method2();
            
            
        }
    }

}
