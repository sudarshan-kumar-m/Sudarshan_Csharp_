using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    
    internal class MultiThreadingWaitMultiple
    {
        static object _lock =new object();
        static int lastNumber=30;
        static void EvenNumber()
        {
            
            try
            {
                Monitor.Enter(_lock);
                for(int i = 0; i <= 30;i+=2)
                {
                    if(i%2==0)
                    {
                        Console.Write(i + " ");
                        Monitor.Pulse(_lock);
                        bool Last = false;
                        if(i==lastNumber)
                        {
                            Last = true;
                            
                        }
                        if(!Last)
                        {
                            Monitor.Wait(_lock);
                        }
                    }
                }
                
            }
            finally
            {
                Monitor.Exit(_lock);
            }


        }
        static void OddNumber()
        {
            try
            {
                Monitor.Enter(_lock);
                for (int i = 1; i <= 30; i+=2)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write(i + " ");
                        Monitor.Pulse(_lock);
                        bool Last = false;
                        if (i == lastNumber-1)
                        {
                            Last = true;
                        }
                        if (!Last)
                        {
                            Monitor.Wait(_lock);
                        }
                    }
                }
            }
            finally
            {
                Monitor.Exit(_lock);
            }
        }
        static void Main(string[] args)
        {
            Thread t1=new Thread(EvenNumber);
            Thread t2=new Thread(OddNumber);
            t1.Start();
            Thread.Sleep(100);
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine();
            Console.WriteLine("Execution completed");
        }
    }
}
