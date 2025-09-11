using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class MultiThreadingInterLock
    {
        public static int a = 10;
        public static int b = 20;
        public static int sum;
        static void Main(string[] args)
        {
            for (int i = 0; i < a; i++)
            {
                Interlocked.Increment(ref sum);
            }
            Interlocked.Exchange(ref b, 0);
            Interlocked.CompareExchange(ref a, 20, 10); //if a=10,change to 20
            Console.WriteLine(Interlocked.Equals(b, a));

            Console.WriteLine($"sum:{ sum}, b:{ b}, a:{a}");
        }
    }
}
