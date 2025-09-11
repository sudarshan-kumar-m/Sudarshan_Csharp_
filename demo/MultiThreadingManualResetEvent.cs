using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace demo
{
    internal class MultiThreadingManualResetEvent
    {
        static ManualResetEvent mre = new ManualResetEvent(true);
        public static void write()
        {
            Console.WriteLine("Write Thread Working");
            mre.Reset(); 
            Thread.Sleep(5000);
            Console.WriteLine("Write Thread completed");
            mre.Set();    
        }
        public static void Read()
        {
            Console.WriteLine("Read Thread wait");
            mre.WaitOne(); //true allow if false block
            Console.WriteLine("Read Thread completed");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(write);
            t1.Start();
            for(int i = 0;i<5;i++)
            {
                new Thread(Read).Start();
            }
        }
    }
}
