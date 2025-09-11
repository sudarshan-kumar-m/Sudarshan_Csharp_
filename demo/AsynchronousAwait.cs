using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class AsynchronousAwait
    {
        public async static Task Method1() //you can await this method if you use task instead of void
        {
            //await Task.Delay(10000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method1 is executed " + i +" " + Thread.CurrentThread.ManagedThreadId);
            }
        }
        public async static Task Method2()
        {
            //await Task.Delay(10000);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method2 is executed " + i + " " + Thread.CurrentThread.ManagedThreadId);
                //if (i == 3)
                    await Task.Delay(500);
                
            }
        }
        public async static Task Method3()
        {
            //await Task.Delay(10000);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method3 is executed " + i + " " + Thread.CurrentThread.ManagedThreadId);
                if(i==76)
                    await Task.Delay(500);
               
            }
        }

        static  async  Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Task task1 = Method1();
            Console.WriteLine("Task 1 has been called moving to task 2");
            Task task2 = Method2();
            Console.WriteLine("Task 2 has been called moving to task 3");
            Task task3 = Method3();
            Console.WriteLine("Task 3 has been called moving to awaitall");
            //Task.WaitAny(task1, task2, task3);   //allow if any one of the task is completed
            //Task.WaitAll(task1, task2, task3);
            await Task.WhenAll(task1, task2, task3);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Main programme is completed");

        }
    }
}
