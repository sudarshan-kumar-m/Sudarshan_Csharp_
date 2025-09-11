using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadingMonitor
    {
        public static int sum=0;
        public static object _lock = new object();
        static void Addition()
        {

            Monitor.Enter(_lock);
            try
            {
                for(int i=0;i<100;i++)
                {
                    sum++;
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                    //Monitor.Wait(_lock);
                    //Monitor.Pulse(_lock);
                }

            }
            finally
            {
                
                    Monitor.Exit(_lock);
            }
        }
        static void Main()
        { 
            Thread a=new Thread(Addition);  
            Thread b=new Thread(Addition);
            a.Start();b.Start();
            a.Join();
            b.Join();
            Console.WriteLine(sum);
        }
    }
}
