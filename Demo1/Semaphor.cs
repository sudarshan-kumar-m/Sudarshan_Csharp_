using System;
using System.Threading;

class sema
{
    // initialCount = 0 — no threads can enter initially
    // maximumCount = 3 — semaphore count can never exceed 3
    static Semaphore semaphore = new Semaphore(initialCount: 0, maximumCount: 3);

    static void Worker(object id)
    {
        Console.WriteLine($"Thread {id} waiting...");
        semaphore.WaitOne(); 
        Console.WriteLine($"Thread {id} ENTERED");
        Thread.Sleep(1000);  
        Console.WriteLine($"Thread {id} LEAVING");
        semaphore.Release(); 
    }

    static void Main()
    {

        for (int i = 1; i <= 5; i++)
            new Thread(Worker).Start(i);

        Thread.Sleep(500);
        Console.WriteLine("Main thread calls Release(3)");
        semaphore.Release(3);  


    }
}
