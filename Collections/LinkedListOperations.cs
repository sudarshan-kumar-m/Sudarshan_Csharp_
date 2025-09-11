using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class LinkedListOperations
    {
        static void Main(string[] args)
        {
            LinkedList<object> list = new LinkedList<object>(new object[] {10,20,30,40,50});
            List<int> a = new List<int>() { 110,120,130,140,150};
            Queue<int> q = new Queue<int>(new [] {210,220,230,240,250});
            Stack<int> s = new Stack<int>(new [] { 310, 320, 330, 340, 350 });
            list.AddLast(a);
            list.AddLast(q);
            list.AddLast(s);

            foreach (object i in list)

            {
                if (i is List<int> g)
                {

                    Console.Write("[");
                    Console.Write(string.Join(",", g));
                    Console.WriteLine("]");
                }
                else if (i is Stack<int> m)
                {
                    Console.Write("[");
                    Console.Write(string.Join(",", m));
                    Console.WriteLine("]");
                }
                else if (i is Queue<int> n)
                {
                    Console.Write("[");
                    Console.Write(string.Join(",", n));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
