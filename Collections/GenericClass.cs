using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericClass<T> 
    {
        public T d, e;

        public static void Waste() => Console.WriteLine("Hii");
        public T Add(T t, T u) 
        {
            dynamic d1 = t;
            dynamic d2 = u;
            return d1+d2;
        }
        
        public (string ,string ,int ,float ) Add1<T1, T2>(T1 t, T2 u)
        {
            dynamic d1 = t;
            dynamic d2 = u;
            return  (d2,d2,0,0f);
        }

    }
    public class Myclass
    {
        static void Main()
        {
            //GenericClass<int>.Waste();
            GenericClass<int> a = new GenericClass<int>();
            a.d = 100;
            a.e = 200;
            Console.WriteLine(a.Add(a.e, a.d));

            Console.WriteLine();
            GenericClass<string> b = new GenericClass<string>();
            b.d = "Sudarshan ";
            b.e = "Kumar";
            Console.WriteLine(b.Add(b.d, b.e));

            Console.WriteLine();
            GenericClass<string> c = new GenericClass<string>();
            
            var m = c.Add1(2, " sudarshan");
            var s = Tuple.Create(10, 20, 'a');
          

            //foreach (var x in m[0]) { }
            Console.WriteLine(m);
            Console.WriteLine(c.Add1<int,string>(2," sudarshan"));
        }
    }
}
