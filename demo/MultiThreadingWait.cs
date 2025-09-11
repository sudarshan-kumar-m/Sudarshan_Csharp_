using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

namespace demo
{
    internal class MultiThreadingWait
    {
        private static object _lock = new object();
        static void Main()
        {
            Thread t1 = new Thread(Display);
            Thread t2 = new Thread(Display);
            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t1.Start();
            Thread.Sleep(100);
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("Main Method completed");
        }
        public static void Display()
        {
            Monitor.Enter(_lock);
            try
            {
                Console.WriteLine(Thread.CurrentThread.Name +" Display is started");
                Monitor.Pulse(_lock);
                Monitor.Wait(_lock);

                Console.WriteLine(Thread.CurrentThread.Name + " Display is complted");
                Monitor.Pulse(_lock);
            }
            finally
            {
                Monitor.Exit(_lock);
            }

        }
    }
}
