using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    internal class SingleThreading
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i <=100; i++)
            {
                Console.WriteLine("Test2:" + i);
                if(i==51)
                {
                    Console.WriteLine("Main thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thread wake up from sleep");
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
        }
        static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            Test1();
            Test2();
            Test3();
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }
    }
}
