using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class ThreadException
    {
        static void Main()
        {
            Thread parentThread = new Thread(() =>
            {
                Console.WriteLine("Parent thread started.");

                Thread childThread = new Thread(() =>
                {
                    Console.WriteLine("Child thread running inside parent thread.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Child thread finished.");
                });


                childThread.Start();
                childThread.Join();                                                                 // Optional: wait for the child to finish

                Console.WriteLine("Parent thread finished.");
            });
            parentThread.Start();

            parentThread.Join();                                                                    // Wait for parent thread to finish

            Console.WriteLine("Main thread ends.");
        }
    }
    internal class ThreadException1
    {

        static void Main()
        {
            Thread childThread1 = new Thread(() =>
            {
                Thread.Sleep(2000);
                throw new Exception("Child thread 1 crashed!");
            });

            Thread childThread2 = new Thread(() =>
            {
                throw new Exception("Child thread 2 crashed!");
            });

            childThread1.Start();
            //childThread2.Start();
            //childThread1.Join();

            //childThread1.Join();                                          //Making parent wwaiting for child to complete its task.
            Thread.Sleep(4000);
            Console.WriteLine("Parent thread continues to run....................................");
            Thread.Sleep(2000);
            Console.WriteLine("Parent thread ends....................................................");
        }


        internal class ChildThreads
        {
            static void Main()
            {
                Thread t1 = new Thread(() =>
                {
                    Console.WriteLine("Parent t1");
                    Thread t11 = new Thread(() =>
                    {
                        Console.WriteLine("Child t11");
                        Thread t111 = new Thread(() =>
                        {
                            Console.WriteLine("Child t111");
                            //Thread.Sleep(5000);
                            throw new Exception();
                            DateTime currentTime = DateTime.Now;
                            Console.WriteLine($"Current local time: {currentTime}..........................................................................................");
                            
                        });
                        t111.Start();
                        Console.WriteLine("Child t11 end");
                    });
                    Thread t12 = new Thread(() =>
                    {
                        for (int i = 0; i < 10000; i++)
                        {
                            Console.WriteLine(i + " ");
                            DateTime currentTime = DateTime.Now;
                            Console.WriteLine($"Current local time: {currentTime}");
                        }
                        Console.WriteLine("Child t12");
                        //Thread t121 = new Thread(() => { throw new Exception(); });
                        //t121.Start();
                        //Thread.Sleep(1000);
                        Console.WriteLine("Child t12 end");
                    });

                    t11.Start(); t12.Start();
                    //t11.Join(); t12.Join();
                    Console.WriteLine("Parent t1 end");
                });
                t1.Start();
                //t1.Join();
                Console.WriteLine("Main Thread End");
                
            }
        }
    } 
}

