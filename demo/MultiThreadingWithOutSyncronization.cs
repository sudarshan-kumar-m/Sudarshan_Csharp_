using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    
    internal class MultiThreadingWithOutSyncronization
    {
        public static int counter=1;
        public static void IncrementCounter()
        {
            for (int i = 1; i <= 100; i++) 
            {
                counter++;
                //Console.WriteLine(Thread.CurrentThread.Name  + i);
                //Console.WriteLine("Counter :" + counter);
            }
        }
        static void Main(string[] args)
        {
            for(int i=0;i<20;i++)
            {
                new Thread(IncrementCounter).Start();
            }
            Console.WriteLine("Counter Value:" + counter);
        }
    }
}
