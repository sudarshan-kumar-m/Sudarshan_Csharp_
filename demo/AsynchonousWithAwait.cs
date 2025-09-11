using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace demo
{
    internal class AsynchonousWithOutAwait
    {
        public static void Method1()
        {
            Console.WriteLine("Method1 is started...");
            SomeMethod();
            Console.WriteLine("Method1 is ended");
        }
        public static void SomeMethod()
        {
            Console.WriteLine("SomeMethod starts working");
            Thread.Sleep(5000);
            Console.WriteLine();
            Console.WriteLine("SomeMethod Ends");
        }
        static void Main(string[] args)
        {
            Method1();
        }
    }
    internal class AsynchonousWithAwait
    {
        
        public async static void SomeMethod()
        {
            Console.WriteLine("SomeMethod starts working");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(3000);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Thread.CurrentThread.IsBackground = false;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Some Method number:" + i + " "+ Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine();
            Console.WriteLine("SomeMethod Ends");

        }
        static   void Main(string[] args)
        {
            Console.WriteLine("Main Method is started...");
            SomeMethod();
            Thread.Sleep(3000);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Method number:" + i  + " "+ Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("Method1 is ended");
            
        }
    }


























    public class TaskOrVoid
    {
        static async Task SomeMethod()
        {
            await Task.Delay(5000);
            throw new Exception("Something went wrong");
        }
        static async Task Main()
        {
            try
            {
                await SomeMethod();
                Console.WriteLine("Sudarshan");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            Console.WriteLine("Main method is ended");
        }
    }


    public class TaskOrVoid1
    {
        static async Task SomeMethod()
        {
            await Task.Delay(5000);
            throw new Exception("Something went wrong");
        }
        static void Main()
        {
            try
            {
                SomeMethod();
                Console.WriteLine("Sudarshan");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            Console.WriteLine("Main method is ended");
        }
    }
}
