using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace PracticeCoding
{
    internal class Test
    {
        static void Main()
        {
            Thread T1 = new Thread(() =>
            {
                throw new Exception("Error...........................................................................................................");
            });
            Thread T2 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if(i ==999998)
                    {
                    Console.WriteLine(i + Thread.CurrentThread.Name);

                    }
                }
            });
            Thread T3 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if (i == 999998)
                    {
                        Console.WriteLine(i + Thread.CurrentThread.Name);

                    }
                }
            });
            Thread T4 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if (i == 999998)
                    {
                        Console.WriteLine(i + Thread.CurrentThread.Name);

                    }
                }
            });
            Thread T5 = new Thread(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    if (i == 999998)
                    {
                        Console.WriteLine(i + Thread.CurrentThread.Name);

                    }
                }
            });
            T1.Name = "Thread 1";
            T2.Name = "Thread 2";
            T3.Name = "Thread 3";
            T4.Name = "Thread 4";
            T5.Name = "Thread 5";

            T1.Start();
            T2.Start();
            T3.Start();
            T4.Start();
            T5.Start();
            Console.WriteLine("Main Ends");
        }
    }
}
