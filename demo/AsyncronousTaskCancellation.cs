using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class AsyncronousTaskCancellation
    {
        public static async Task SomeWork(int n,CancellationToken Token)
        {
            Console.WriteLine("Some method started working");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                if(Token.IsCancellationRequested)
                {
                    Console.WriteLine("Some work cancelled");
                    return;
                    //throw new TaskCanceledException();

                }
            }

        }
        public static async Task Work(int n, CancellationToken Token)
        {
            Console.WriteLine("Work started");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                if (Token.IsCancellationRequested)
                {
                    Console.WriteLine("work cancelled");
                    return;
                    //throw new TaskCanceledException();

                }
            }

        }
        static async void Main()
        {
            CancellationTokenSource a= new CancellationTokenSource();
            a.CancelAfter(5000);
            int n = 10;
            //await SomeWork(n, a.Token);

            try
            {
                await SomeWork(n, a.Token);
                await Work(n, a.Token);
            }
            catch (TaskCanceledException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine("Main Method completed");
        }
    }










    internal class cancel             // Cancel()
    {
        public static async Task SomeWorkCancel(int n)
        {
            Console.WriteLine("Some method started working");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(1000);
               
            }

        }
        static async Task Main()
        {
            CancellationTokenSource a = new CancellationTokenSource();
            int n = 10;
            //await SomeWork(n, a.Token);

            SomeWorkCancel(n);
            await Task.Delay(5000);
            a.Cancel();

            Console.WriteLine("Main Method completed");
        }
    }
}
