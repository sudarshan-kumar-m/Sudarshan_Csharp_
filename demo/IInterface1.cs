using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public interface IInterface1
    {
        void add(int x, int y);
    }
    public interface IInterface2:IInterface1
    {
        void sub(int x, int y);
    }
    public class Test1:IInterface2
    {
        public void add(int x,int y)
        {
            Console.WriteLine($"Sum is:{x + y}");
        }
        public void sub(int x,int y)
        {
            Console.WriteLine($"difference is:{x - y}");
        }
        static void Main()
        {
            Test1 t=new Test1();  // creating the object of the class
            t.add(1,2);
            t.sub(1,2);
            Console.WriteLine();
            IInterface2 i = new Test1();  // reference of the interface using child class
            i.add(40,30);
            i.sub(40, 30);
            
        }
    }
    

}
