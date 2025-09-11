using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class ArrayListProgramme
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();  //list1
            list.Add(100);
            list.Add(200);
            list.Add(300);
            list.Add(400);
            foreach (int i in list)
            {
                Console.Write(i+" ");
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



            //Cloning
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Cloning");
            ArrayList list5 = (ArrayList) list3.Clone();
            Console.WriteLine("List 5:");
            list5[3] = "Aus";
            foreach (var i in list5)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("List 3:");
            foreach (var i in list3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //testing
            Console.WriteLine("_________________________________________________");
            ArrayList list6 = new ArrayList(list3);
            list6[1] = "Europe";
            foreach (var i in list6)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Testing....................................................");
            ArrayList list4 = list3;
            Console.WriteLine("List 4:");
            list4[3] = 55;
            foreach (var i in list3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("List 3:");
            foreach (var i in list3)
            {
                Console.Write(i + " ");
            }
        }
    }
}
