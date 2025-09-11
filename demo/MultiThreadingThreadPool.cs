using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    internal class MultiThreadingThreadPool
    {
        public static void MyMethod(object obj)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine($"Backgroud:{thread.IsBackground}Thread pool:{thread.IsThreadPoolThread} ThreadId:{thread.ManagedThreadId}");
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(MyMethod);
            }
            Thread.Sleep(2000);
        }
    }
}
