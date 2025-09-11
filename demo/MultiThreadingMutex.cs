using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadingMutex
    {
        static Mutex mutex = new Mutex();
        static void Main()
        {
            for(int i=0;i<5;i++)
            {
                new Thread(Work).Start();
            }
            //mutex.ReleaseMutex();  //we cannot do because it is in main thread
        }
        public static void Work()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work Thread is waiting");
            mutex.WaitOne();  //mutex.WaitOne(5000);  //provide the timeout
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work is started");
            Thread.Sleep(15000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work is completed");
            mutex.ReleaseMutex();
        }

    }
}
