using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadingSemaphore
    {
        static Semaphore semaphore = new Semaphore(3,7);//first one is initila value and second one is maximum value
        static void Main()
        {
            for (int i = 0; i < 20; i++)
            {
                new Thread(Work).Start();
            }
            
        }
        public static void Work()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work Thread is waiting");
            semaphore.WaitOne();  
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work is started");
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " Work is completed");
            semaphore.Release();
          
        }
    }
}
