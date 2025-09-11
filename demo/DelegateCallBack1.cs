using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo
{

    public delegate void DelegateCB1(int i);

    public class Second1
    {
        public void Print(int i)
        {
            Console.WriteLine(i);
        }
    }
    public class First1
    {
        public void Number(Second1 s)
        {
            for (int p = 0; p <= 100; p++)
            {
                //g(p);
                s.Print(10);
            }
        }
    }
    public class DelegateCallBack1
    {
        static void Main()
        {
            
            Second1 s = new Second1();
            First1 first = new First1();
            //DelegateCB1 a = new DelegateCB1(s.Print);
            first.Number(s);
            //first.Number(s.Print);

        }
    }

}

