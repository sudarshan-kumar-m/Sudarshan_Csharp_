using System;
using System.Reflection;
using System.Threading;

namespace ConsoleApp1
{
    internal class MultiThreaddingWaitPulseMethods
    {
        private static readonly object _locker = new object();
        public static int count = 0;
                                                                    // Shared flag

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                new Thread(Dowork).Start();
            }
        }

        public static void Dowork()
        {
            object printer = new object();
            lock (_locker) 
            {
                count++;
                Monitor.Pulse(_locker);                                                                         // Block others
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} starting...");
                Monitor.Wait(_locker);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} sleep");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ending...");
                if (count == 5)
                {
                    Monitor.Pulse(_locker);
                }
            }
        }
    }
}