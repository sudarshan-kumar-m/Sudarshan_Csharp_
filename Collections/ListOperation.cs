using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ListOperation
    {
        static void Main(string[] args)
        {
            List<object> a = new List<object>() { 1,2,3,4,5};

            ArrayList b = new ArrayList() { 10, 20, 30, 40, 50 };
            Hashtable c = new Hashtable()
            {
            {1,"one" },
            {2,"two"},
            {3, "Three" }
            };
            Stack d = new Stack(new object[] { 110, 120, 130, 140, 150 });
            Queue e = new Queue(new object[] { 210, 220, 230, 240, 250 });
            List<int> f = new List<int>() { 310, 320, 330, 340, 350 };
            SortedList g = new SortedList()
            {
                {5,"Five" },{6,"six" }
            };

            a.Add(c);
            a.Add(d);
            a.Add(e);
            a.Add(f);
            a.Add(g);

            Console.WriteLine();
            foreach (object i in a)
            {
                if (i is ArrayList z)
                {//Adding Arraylist to List<>

                    Console.Write("[");
                    Console.Write(string.Join(" ", z.ToArray()));
                    Console.WriteLine("]");
                }
                else if (i is Stack y)
                {//Adding Arraylist to stack
                    Console.Write("[");
                    Console.Write(string.Join(" ", y.ToArray()));
                    Console.WriteLine("]");
                }
                else if (i is Queue x)
                {//Adding Arraylist to Queue
                    Console.Write("[");
                    Console.Write(string.Join(" ", x.ToArray()));
                    Console.WriteLine("]");
                }
                else if (i is Hashtable v)
                {//Adding Arraylist to Hashtable
                    Console.Write("[");
                    foreach (DictionaryEntry entry in v)
                    {
                        Console.Write($"[{entry.Key}:{entry.Value}] ");
                    }
                    Console.WriteLine("]");
                }
                else if(i is List<int> u)
                {
                    Console.Write("[");
                    Console.Write(string.Join(" ",u.ToArray()));
                    Console.WriteLine("]");
                }
                else if(i is SortedList t)
                {
                    Console.Write("[");
                    foreach(DictionaryEntry entry in t)
                    {
                        Console.Write($"[{entry.Key}:{entry.Value}] ");
                    }
                    Console.WriteLine("]");
                }
                else { Console.WriteLine(i); }
                
            }
            
        }
    }
}
