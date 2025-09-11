using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace demo
{
    
    internal class MultiThreadingThreadPoolTime
    {
        public static void Test(object obj)
        {

        }
        public static void MethodByThread()
        {
            for (int i = 0; i < 100000; i++) 
            {
                Thread thread = new Thread(Test);
                thread.Start();
            }
        }
        public static void MethodByThreadPool()
        {
            for (int i = 0; i < 100000; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }
        static void Main()
        {
            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            sw1.Start();
            MethodByThread();
            sw1.Stop();
            sw2.Start();
            MethodByThreadPool();
            sw2.Stop();
            Console.WriteLine($"Time taken by the Thread:{sw1.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time taken by the Thread Pool:{sw2.ElapsedMilliseconds} ms");
        }
    }
}
