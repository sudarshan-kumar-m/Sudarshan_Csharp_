using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MulThread
{
    internal class MutiThread
    {
        public static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1 " + i);
            }
            Console.WriteLine("Test1 Exists");
        }
        public static void Test2()
        {
            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {

                    Console.WriteLine("Test Iner thread " + i);
                    if (i == 5)
                    {
                        throw new Exception("Exception by T2");
                    }
                }
            });
            t2.Start();
            Thread.Sleep(5000);
            Console.WriteLine("Test2 Exists");
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
            Console.WriteLine("Test3 Exists");
        }

        public static void Main()
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            //T1.Join();
            T2.Start();
            //T2.Join();
            T3.Start();
            T2.Join();
            Console.WriteLine("Main Exists");
            Console.ReadLine();
        }
    }
}