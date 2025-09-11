using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace demo
{
    internal class ThreadStartMethod //Running in background
    {
        public static void Numbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Numbers);
            //t1.IsBackground = true;     // Making foreground
            t1.Start();
            Console.WriteLine("Main Programme");
        }
    }
    internal class TaskStartMethod   //Running in Foreground
    {
        public static void Numbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Task t1 = new Task(Numbers);
            t1.Start();
            Console.WriteLine("Main Programme");
        }
    }
}
