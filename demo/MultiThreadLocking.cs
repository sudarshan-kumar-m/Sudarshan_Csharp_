using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    internal class MultiThreadLocking
    {
        static void Display()
        {
            Console.Write("Welcome to");
            Thread.Sleep(5000);
            Console.WriteLine(" Csharp World");
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(Display);
            Thread t2=new Thread(Display);
            Thread t3=new Thread(Display);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
    public class MultiThreadLocking1
    {
        private object obj=new object();
        public void Display()
        {
            //Console.Write("Today is Wednesday");
            //Console.WriteLine(" and today is raining.");

            lock (obj)
            {
                Console.Write("Welcome to");
                Thread.Sleep(5000);
                Console.WriteLine(" Csharp World.");
            }
        }
        static void Main(string[] args)
        {
            MultiThreadLocking1 p = new MultiThreadLocking1();
            MultiThreadLocking1 p1 = new MultiThreadLocking1();
            MultiThreadLocking1 p2 = new MultiThreadLocking1();
            MultiThreadLocking1 p3 = new MultiThreadLocking1();
            Thread t1 = new Thread(p.Display);
            Thread t2 = new Thread(p.Display);
            Thread t3 = new Thread(p.Display);
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
