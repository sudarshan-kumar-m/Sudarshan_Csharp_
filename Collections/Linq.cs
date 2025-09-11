using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Linq
    {
        static void Main()
        {
            int[] arr = { 12, 30, 45, 90, 1, 3, 56, 2, 66 };
            int[] arr2 = new int[arr.Length];
            var brr2 =from i in arr select i;
            foreach (int i in brr2)
                Console.Write(i+" ");
            Console.WriteLine("\n");


            Console.WriteLine("Ascending order");
            var crr=from i in arr orderby i select i;
            foreach (int i in crr)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Descending order");
            var drr = from i in arr orderby i descending select i;
            foreach (int i in drr)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            Console.WriteLine("Above 40 and in Acesding order");
            var err= from i in arr where i>40 orderby i select i;
            foreach (int i in err)
                Console.Write(i + " ");
            Console.WriteLine("\n");

        }
    }
}
