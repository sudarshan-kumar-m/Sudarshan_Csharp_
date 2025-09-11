using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class OperatorOverloading:Object
    {
        public int a, b, c, d, e, f;
        public OperatorOverloading(int a, int b, int c, int d, int e, int f)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
        }
        public static OperatorOverloading operator +(OperatorOverloading a, OperatorOverloading b)
        {
            OperatorOverloading c = new OperatorOverloading(a.a + b.a , a.b + b.b , a.c +b.c, a.d +b.d, a.e +b.e, a.f+b.f);
            return c;
        }
        public override string ToString()
        {
            return $"{a} {b} {c}\n{d} {e} {f}\n";
        }
        static void Main(string[] args)
        {
            OperatorOverloading a = new OperatorOverloading(100,90,80,70,60,50);
            OperatorOverloading b = new OperatorOverloading(1,2,3,4,6,6);
            OperatorOverloading c = a + b;
            int d = 2 +   5;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }
    }
}
