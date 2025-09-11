using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericIMethod
    {
        public void Add<T>(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public T AddSomeThing<T>(T a, T b) 
        {
            dynamic d3 = a;
            dynamic d4 = b;
            return d3 + d4;
        }
        public t2 Work<t1,t2>(t1 a,t2 b)
        {
            dynamic d5 = a;
            dynamic d6 = b;
            return d5 + d6;
        }


        public bool Display<T>(T a,T b)
        {
            if (a.Equals(b)) 
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            GenericIMethod s = new GenericIMethod();
            bool m = s.Display<int>(1, 2);
            Console.WriteLine(m);
            bool n = s.Display<float>(1.2f, 2.5f);
            Console.WriteLine(n);
            bool o = s.Display<char>('d', 'd');
            Console.WriteLine(o);
            bool p = s.Display<string>("Sudarshan","Sudarshan");
            Console.WriteLine(p);





            s.Add(1,2);
            s.Add("Sudarshan ", "Kumar");
            s.Add('M', 'K');


            Console.WriteLine(s.AddSomeThing<String>("PuneethRaj ", "Kumar"));

            Console.WriteLine(s.Work<int, float>(3, 5.6f));
            
        }
    }
}
