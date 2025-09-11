using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading; 

namespace demo
{
    internal class MultiThreading
    {
        public static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test1:" + i);
                
            }
            Console.WriteLine("Thread1 exiting");
            
            
        }
        public static void Test2()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 31)
                {
                    Console.WriteLine("Main thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Main thread wake up from sleep");
                }
            }
            Console.WriteLine("Thread2 exiting");
        }
        public static void Test3()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread3 exiting");
        }
        static void Main()
        {
            Thread t = new Thread(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine("Thread 1");
                }
            });
            t.Start();

            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread exiting.");
        }
    }
}
