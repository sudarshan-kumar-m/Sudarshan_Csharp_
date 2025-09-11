using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections.Properties
{
    internal class ArrayListToArray
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList()
            {
                100,200,300,"India","Karnataka","Udupi","Kundapur"
            };
            foreach (var i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array 1");
            object[] array = new object[arrayList.Count];   //Array declaration
            arrayList.CopyTo(array);
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array 2");
            object[] array1 = new object[arrayList.Count+5];
            arrayList.CopyTo(array1,5);
            foreach (var i in array1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Array 2");
            object[] array2 = new object[arrayList.Count];
            arrayList.CopyTo(2, array2, 5, 2);
            foreach (var i in array2)
            {
                Console.Write(i + " ");
            }
            
            Console.WriteLine();

            arrayList.Sort();
            foreach (var i in arrayList)
            {
                Console.Write(i + " ");
            }

        }
    }
}
