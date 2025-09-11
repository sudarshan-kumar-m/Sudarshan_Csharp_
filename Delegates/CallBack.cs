using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Delegates
{
    public delegate void Sender(int i);
    internal class CallBack
    {
        static void Main(string[] args)
        {
            SomeClass a= new SomeClass();
            Thread t1 = new Thread(a.HugeProcess);
            a.sender += Receiver1;
            a.sender += Receiver2;
            a.sender += Receiver3;
            a.sender += Receiver4;
            a.sender += Vehicle.Display;

            a.sender = null; //  this will make the sender Empty, So we are using Events to avoid it


            t1.Start();
            t1.Name = "Thread 1";
            Console.WriteLine("Main Programme ends");

        }
        public static void Receiver(int i)
        {
            Console.WriteLine("Receiver"+i);
            
        }
        public static void Receiver1(int i)
        {
            Console.WriteLine("Receiver1"+i);   
            //Console.WriteLine(i);
        }
        public static void Receiver2(int i)
        {
            Console.WriteLine("Receiver2"+i);   
            //Console.WriteLine(i);
        }
        public static void Receiver3(int i)
        {
            Console.WriteLine("Receiver3"+i);   
            //Console.WriteLine(i);
        }
        public static void Receiver4(int i)
        {
            Console.WriteLine("Receiver4"+i);   
            //Console.WriteLine(i);
        }
    }
    public class Vehicle
    {
        public static void Display(int i)
        {
            Console.WriteLine("car" + i);
        }
        
    }
    public class SomeClass
    {
        public Sender sender = null;
        public void HugeProcess()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                
                
                sender(i);
            }
        }
    }
}
