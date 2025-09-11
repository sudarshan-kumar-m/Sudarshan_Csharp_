using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadPriorities
    {
        static long count1,count2;
        public static void Increment1()
        {
            while (true)
            {
                count1 += 1;
            }
        }
        public static void Increment2()
        {
            while (true)
            {
                count2 += 1;
            }
        }
        public static void Main()
        {
            Thread t1=new Thread(Increment1);
            Thread t2=new Thread(Increment2);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;


            t1.Start();
            t2.Start();

            Console.WriteLine("Thread is gong to sleep");
            Thread.Sleep(5000);
            Console.WriteLine("Thread is wake up from the sleep");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.WriteLine("End of the programme");
        }
        
    }
    public class priority
    {
        static void Test1()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1:"+i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2:" + i);
            }
        }
        static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
        }
    }
}
