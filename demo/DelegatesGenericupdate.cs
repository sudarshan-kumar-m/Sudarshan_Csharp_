using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class DelegatesGenericupdate
    {
        public double AddNumber(int a, float b, double c)
        {
            return a + b + c;
        }
        public void AddNumber1(int a, float b, double c)
        {
            Console.WriteLine($"{a} + {b} + {c}:{a + b + c}");
        }
        public bool CheckNumber(string a)
        {
            if (a.Length > 5)
                return true;
            else return false;
        }
        public static void Main()
        {
            DelegatesGenericupdate k = new DelegatesGenericupdate();
            Func<int,float,double,double> v = k.AddNumber;
            double s = v(3, 4, 5);
            Console.WriteLine(s);
            Action<int,float,double> e = k.AddNumber1;
            e(3, 6, 9);
            Predicate<string> f = k.CheckNumber;
            bool status = f("Farefirst");
            Console.WriteLine(status);
            
            
        }
    }
}
