using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class method_overloading_addition
    {
        public int a, b;
        public float c, d, e;
        public int add(int a, int b)
        {
            int sum=a+b;
            return sum;
        }
        public int add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
        public float add(float a, float b)
        {
            float sum = a + b;
            return sum;
        }
        public float add(float a, float b,float c)
        {
            float sum = a + b + c;
            return sum;
        }
        public float add(int a,float b)
        {
            float sum=a + b;
            return sum;
        }
        public void display(int l)
        {
            Console.WriteLine(l);
        }
        public void display(float l)
        {
            Console.WriteLine(l);
        }
        static void Main(string[] args)
        {
            method_overloading_addition m=new method_overloading_addition();
            m.a=m.add(1, 2);
            m.display(m.a);
            m.b=m.add(2, 3,5);
            m.display(m.b);
            m.c = m.add(1.2f, 1.2f);
            m.display(m.c);
            m.d = m.add(1.2f, 1.2f, 1.2f);
            m.display(m.d);
            m.e = m.add(1, 1.2f);
            m.display(m.e);

        }
    }
}
