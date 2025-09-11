using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    internal class MultiThreadManyMethod
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 is executed");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 is executed");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 is executed");
        }
        public static void Method4()
        {
            Console.WriteLine("Method 4 is executed");
        }
        public static void Combined1()
        {
            Method1();
            Method2();
            Method3();
        }
        static void Main()
        {
            Thread t1 = new Thread(Combined1);
            Thread t2 = new Thread(Method4);
            t1.Start();
            t2.Start();
            t1.Join(); t2.Join();
            Console.WriteLine("End of the Programme");
        }
    }
}
