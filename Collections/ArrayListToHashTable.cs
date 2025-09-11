using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListToHashTable
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable()
            {
                {1,100 }, {2,200}, {3,300}
            };
            Queue b = new Queue(new Object[] {50,30,920});
            Stack c = new Stack(new object[] {11,22,33,44});
            ArrayList d = new ArrayList() {"Apple","Mango","Pineapple"};
            List<int> e=new List<int>() { 10,20,30,40,50};
            Stack<string> f = new Stack<string>(new [] { "Udupi", "Mandya", "Mysore" }) ;

            a.Add(11,f);                   //Add Generic stack to Hashtable
            a.Add(10,e);                  //Add List<> to Hashtable
            a.Add(6,c);                   //Add Stact to HashTable
            a.Add(4, b);                  // Add Queue to HashTable
            a.Add(5, d);                  // Add ArrayList to HashTable
            foreach (DictionaryEntry i in a)
            {
                var key=i.Key;
                var value=i.Value;
                Console.Write($"Key:{key}, Value:");
                //one more method to access the stack
                //if (value is Stack)
                //{
                //    Console.Write("[");
                //    foreach (var p in (Stack)value)
                //    {
                //        Console.Write(p.ToString() +" ");
                //    }
                //    Console.WriteLine("]");
                //}
                //else
                //{ Console.WriteLine(); };
                //Console.WriteLine("\n");
                if (value is ArrayList g)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", g.ToArray()));
                    Console.WriteLine("]");
                }
                else if (value is Queue h)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", h.ToArray()));
                    Console.WriteLine("]");
                }
                else if (value is Stack k)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", k.ToArray()));
                    Console.WriteLine("]");
                }
                else if(value is List<int> m)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", m.ToArray()));
                    Console.WriteLine("]");
                }
                else if (value is Stack<string> n)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", n.ToArray()));
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("--------------------------");
            }































            //a.Add(4,b);
            //foreach(object i in a.Keys)
            //{

            //    if(a[i] is Queue)
            //    {
            //        Console.Write("Key:" + i);
            //        foreach (object j in (Queue)i)
            //            Console.WriteLine(j+",");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Key:{i}, Value:{a[i]}");
            //    }
            //}



        }
    }
}
