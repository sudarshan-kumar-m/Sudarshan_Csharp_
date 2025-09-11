using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace demo
{

    public class AsynchronousTashRun
    {
       
        public  static void LongRunning()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Long Threading is Running " + i + " " + Thread.CurrentThread.ManagedThreadId);
                //await Task.Delay(500);
                Thread.Sleep(100);
            }
        }
        static  void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "Thread 1 ";
              Task.Run(() =>
            {
                LongRunning();
            });

            //Thread thread = new Thread(LongRunning);
            //thread.Start();

            
            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Main Threading is Running " + i + " "  + " " + Thread.CurrentThread.ManagedThreadId);
                //Thread.Sleep(200);
                //await Task.Delay(100);
                Console.WriteLine("Sudarshan");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            }
            //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
        }
    }
}
