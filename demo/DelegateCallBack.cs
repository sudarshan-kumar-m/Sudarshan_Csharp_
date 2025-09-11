using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    
    public delegate void DelegateCB(int i);
    
    public class Second
    {
        public void Print(int i)
        {
            Console.WriteLine(i);
        }
    }
    public class First
    {
        public void Number(DelegateCB Callback)
        {
            for(int p=0;p<=100;p++)
            {
                Callback(p);
            }
        }
    }
    public class DelegateCallBack
    {
        static void Main()
        {
            Second s = new Second();
            First first = new First();
            first.Number(new DelegateCB( s.Print));

        }
    }

}
    
