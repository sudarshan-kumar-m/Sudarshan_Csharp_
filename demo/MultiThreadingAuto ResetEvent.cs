using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadingAuto_ResetEvent
    {
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        static void Worker()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is waiting...");
            autoEvent.WaitOne(); 
            Console.WriteLine($"{Thread.CurrentThread.Name} is proceeding...");
        }

        static void Main()
        {
            Thread t1 = new Thread(Worker);
            t1.Name = "Thread 1";

            Thread t2 = new Thread(Worker); 
            t2.Name = "Thread 2";

            t1.Start();
            t2.Start();

            Thread.Sleep(1000); 

            autoEvent.Set(); // Will allow one thread
            Thread.Sleep(500); 
            autoEvent.Set(); // Will allow the other

        }
    }
}
