using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class DeadLock
    {
        object lock1 = new object();
        object lock2 = new object();

        public void ThreadA()
        {
            lock (lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "start working.");
                Thread.Sleep(1000); // Simulate work
                lock (lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                }
            }
        }

        public void ThreadB()
        {
            lock (lock2)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "start working.");
                Thread.Sleep(1000); // Simulate work
                lock (lock1)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                }
                //if (Monitor.TryEnter(lock1, 3000))
                //{
                //    try
                //    {
                //        Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                //    }
                //    finally
                //    {
                //        Monitor.Exit(lock1);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " is not executed");
                //}
            }



        }

        static void Main()
        {
            DeadLock m = new DeadLock();
            Console.WriteLine("Main function started");
            Thread t1 = new Thread(m.ThreadA);
            Thread t2 = new Thread(m.ThreadB);
            t1.Name = "Thread T1 ";
            t2.Name = "Thread T2 ";
            t1.Start();
            t2.Start();

        }

    }


    //New class
    internal class DeadLockNew
    {
        object lock3 = new object();
        object lock4 = new object();

        public void ThreadA()
        {
            lock (lock3)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "start working.");
                Thread.Sleep(1000); 
                lock (lock4)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                }
            }
        }

        public void ThreadB()
        {
            lock (lock3)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "start working.");
                Thread.Sleep(1000); 
                lock (lock4)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                }
                //if (Monitor.TryEnter(lock1, 3000))
                //{
                //    try
                //    {
                //        Console.WriteLine(Thread.CurrentThread.Name + "finished work.");
                //    }
                //    finally
                //    {
                //        Monitor.Exit(lock1);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine(Thread.CurrentThread.Name + " is not executed");
                //}
            }



        }

        static void Main()
        {
            DeadLockNew m = new DeadLockNew();
            Console.WriteLine("Main function started");
            Thread t1 = new Thread(m.ThreadA);
            Thread t2 = new Thread(m.ThreadB);
            t1.Name = "Thread T1 ";
            t2.Name = "Thread T2 ";
            t1.Start();
            t2.Start();

        }

    }
}
