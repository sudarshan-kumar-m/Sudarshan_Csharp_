using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate double DelegateAddNumber(int a,float b,double c);
    public delegate void DelegateAddNumber1(int e,float f,double g);
    public delegate bool DelegateCheckNumber(string a);
    internal class DelegatesGenerics
    {
        public double AddNumber(int a, float b, double c)
        {
            return a + b + c;
        }
        public void AddNumber1(int a, float b, double c)
        {
            Console.WriteLine($"{a} + {b} + {c}:{a + b+ c }");
        }
        public bool CheckNumber(string a)
        {
            if (a.Length > 5)
                return true;
            else return false;
        }
        static void Main()
        {
            DelegatesGenerics d =new DelegatesGenerics();
            DelegateAddNumber m = d.AddNumber;
            DelegateAddNumber1 n = d.AddNumber1;
            DelegateCheckNumber o = d.CheckNumber;
            double r = m(1, 2, 3);
            Console.WriteLine(r);
            n(1, 2, 3);
            bool status=o("farefirst");
            Console.WriteLine(status);
        }
    }
}
