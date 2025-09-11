using System;
using System.Threading;

class Lock
{
    static int count = 0;

    static void Add()
    {
        for (int i = 0; i < 1000; i++)
        {
            count++;  // not thread-safe
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Add);
        Thread t2 = new Thread(Add);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine("Final count: " + count);
    }
}
