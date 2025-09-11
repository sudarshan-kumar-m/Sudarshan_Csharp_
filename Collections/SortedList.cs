using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SortedListProgramme
    {
        static void Main()
        {
            SortedList a = new SortedList()
            {
                {20,"Twenty" }
            };
            Console.WriteLine(a.Capacity);
            a.Add(1,"one");
            a.Add(2,"two");
            a.Add(3, "Three");
            a.Add(4, "four");


            Console.WriteLine($"Key:1, Value:{a.GetByIndex(0)}"); // access by Index
            Console.WriteLine($"Key:1, Value:{a[1]}");            //access by key

            Console.WriteLine();
            Console.WriteLine("Element access by the Keys");      //Element access by the Keys
            foreach (DictionaryEntry item in a)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            Console.WriteLine(); 
            Console.WriteLine("Element access by the Index");     //Element access by the Index
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine($"Key:{a.GetKey(i)}, Vale:{a.GetByIndex(i)}");
            }


            a.Add(6, "six");
            a.Add(5, "Five");
            a.Remove(4);
            a.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("After Add and Remove Operation");     //After Add and Remove
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine($"Key:{a.GetKey(i)}, Vale:{a.GetByIndex(i)}");
            }
            Console.WriteLine();
            Console.WriteLine("Five is present in List:" + a.ContainsKey(5));
            Console.WriteLine("Five is present in List:" + a.ContainsValue("Five"));

        }
    }
}
