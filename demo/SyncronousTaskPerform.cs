using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class SyncronousTaskPerform
    {
        public static Task someMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Some Method1" + " " +i);
                
            }
            return Task.CompletedTask;

        }
        public static Task<String> someMethod2()
        {
            Console.WriteLine();
            return Task.FromResult("Method 2 executed");
        }
        public static Task someMethod3(int n, CancellationToken c)
        {
            CancellationTokenSource b = new CancellationTokenSource();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Some Methood3" + " " + i);
                Thread.Sleep(1000);
                if (c.IsCancellationRequested)
                    throw new TaskCanceledException();

            }
            for(int i=0;i<20;i+=2)
            {
                Console.WriteLine(i);
                /*if(i==6)
                    return Task.FromCanceled(b.Token);*/
            }
            //return Task.FromCanceled(b.Token);
            return Task.CompletedTask;
        }
        static void Main()
        {
            CancellationTokenSource a = new CancellationTokenSource();
            a.CancelAfter(5000);
            someMethod1();
            someMethod2();
            try
            {
                someMethod3(10,a.Token);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main Method is completed");
        }
    }
}
