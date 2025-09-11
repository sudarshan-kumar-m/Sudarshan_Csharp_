using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegates
{
    sealed class SingleTon
    {
        public static SingleTon instance;
        public int Id;
        private static readonly object _lock = new object();
        private SingleTon()
        {
            
        }
        public static SingleTon Instance(int id)
        {
            lock (_lock)
            {
                if (instance == null)
                {
                    instance = new SingleTon();
                    instance.Id = id;
                }
            }
            return instance;
                
        }
        
    }


    class Check
    {
        static void Main()
        {
            Thread t1 = new Thread(() =>
            {
                var first = SingleTon.Instance(1);
                Console.WriteLine(first.Id);
            });
            Thread t2 = new Thread(() =>
            {
                var second = SingleTon.Instance(2);
                Console.WriteLine(second.Id);
            });
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            var third = SingleTon.Instance(3);
            Console.WriteLine(third.Id);

            var four = SingleTon.Instance(4);
            Console.WriteLine(four.Id);
        }
    }
}
