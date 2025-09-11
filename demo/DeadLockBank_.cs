using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace demo
{
    internal class DeadLockBank_
    {
        public static void Main()
        {
            Account AccountA = new Account(400, 5000);
            Account AccountB = new Account(501, 6000);


            AtmCenter System1 = new AtmCenter(AccountA, AccountB, 1000);
            AtmCenter System2 = new AtmCenter(AccountB, AccountA, 1500);

            Thread t1 = new Thread(System1.Transfer);
            t1.Start();
            Thread t2 = new Thread(System2.Transfer);
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine("MAIN EXISTS");
        }

    }

    public class Account
    {
        public int AcId;
        public double AcBalance;
        public Account(int AcId, double AcBalance)
        {
            this.AcId = AcId;
            this.AcBalance = AcBalance;
        }
        public void Withdraw(double Amount)
        {
            AcBalance -= Amount;
            Console.WriteLine("Remaining amount after withdraw is: " + AcBalance);
        }
        public void Deposite(double Amount)
        {
            Console.WriteLine("Balance: " + AcBalance);
            AcBalance += Amount;
            Console.WriteLine("Remaining amount after deposite is: " + AcBalance);
        }
    }

    public class AtmCenter
    {
        Account fromAtm;
        Account toAtm;
        double Amount;
        public AtmCenter(Account fromAtm, Account toAtm, double amount)
        {
            this.fromAtm = fromAtm;
            this.toAtm = toAtm;
            Amount = amount;



        }
        public void Transfer()
        {

            object _lock1, _lock2;
            if(fromAtm.AcId > toAtm.AcId)
            {
                _lock1 = fromAtm;
                _lock2 = toAtm;
            }
            else
            {
                _lock1 = toAtm;
                _lock2 = fromAtm;
                
            }
            lock (_lock1)   
            {
                Console.WriteLine(fromAtm.AcId);
                Thread.Sleep(1000); Console.WriteLine("Wakes");//A 

                lock (_lock2)// DeadLock situation
                {
                    Console.WriteLine(toAtm.AcId);
                    Console.WriteLine("executes");
                    fromAtm.Withdraw(Amount);
                    toAtm.Deposite(Amount);

                }




                //if (Monitor.TryEnter(toAtm, 3000)) //Moniter.TryEnter() to avoid deadlock
                //{
                //    try
                //    {
                //        Console.WriteLine(toAtm.AcId);
                //        Console.WriteLine("executes");
                //        fromAtm.Withdraw(Amount);
                //        toAtm.Deposite(Amount); 
                //    }
                //    finally
                //    {
                //        Monitor.Exit(toAtm);
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("unable to executes");
                //}
            }
        }
    }
}
