using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace demo
{
    public class MultiThreadingDelegate      //ThreadStart
    {
        public static void Test1(object m)
        {
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        static void Main()
        {
            //ThreadStart t = new ThreadStart(Test1);
            //ThreadStart m = Test1;

            /*ThreadStart n = delegate ()  //anonymous delagate
            {
                Test1();  //statement should be written
            };
            Thread t1 = new Thread(n);
            t1.Start();*/

            Thread t1 = new Thread(Test1);
            t1.Start((2, 2));
        }
    }
    public class MultiThreadingDelegate1
    {
        public static void Test1(object m)
        {
            int num=Convert.ToInt32(m);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
        }
        static void Main()
        {
            ParameterizedThreadStart t1 = new ParameterizedThreadStart(Test1);
            
            Thread t2 = new Thread(t1);
            t2.Start(5);
        }

    }
}
