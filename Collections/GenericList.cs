using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class GenericList
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();  //list1
            list.Add((char)100);
            list.Add(200);
            list.Add(300);
            list.Add('A');

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            list.Remove(200);
            list.RemoveAt(1);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            list.Insert(2, 300);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.IndexOf(200));
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(list.Count);

            ArrayList list2 = new ArrayList(list);    //list2
            Console.WriteLine("List 2:");
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            ArrayList list3 = new ArrayList()
            {
                    "India",
                    "USA",
                    "UK",
                    "Nepal"
            };
            Console.WriteLine("List 3:");
            foreach (var i in list3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
