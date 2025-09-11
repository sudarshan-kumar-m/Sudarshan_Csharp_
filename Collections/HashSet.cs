using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class GenericHashSet
    {
        static void Main(string[] args)
        {
            HashSet<object> list = new HashSet<object>();  //list1
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(500);
            list.Add(100); //duplicate

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            list.Remove(200);
            //list.RemoveAt(1);       cannot access with index
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //list.Insert(2, 300);   does not have insert
            
            Console.WriteLine(list.Count);

            //HashSet<int> list2 = new HashSet<int>(list);    //list2
            //Console.WriteLine("List 2:");
            //foreach (int i in list2)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();


            HashSet<string> list3 = new HashSet<string>()
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


            List<int> list4 = new List<int>() { 10, 20, 30, 40, 50, 60 };
            list.Add(list4);
            foreach (var i in list)
            {
                if (i is List<int> j)
                {
                    Console.Write("[");
                    Console.Write(string.Join(" ", j));
                    Console.Write("]");
                }
                else
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
