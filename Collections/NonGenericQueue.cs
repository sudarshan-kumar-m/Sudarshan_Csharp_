using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Collections
{
    internal class NonGenericQueue
    {
        static void Main(string[] args)
        {
            Queue a = new Queue(new object[] { 100, "Farefirst", "Amahop" });

            a.Enqueue(200);
            a.Enqueue("Abhish Games");
            foreach (var item in a)
            {
                Console.WriteLine(item + "      ");
            }
            Console.WriteLine();


            a.Dequeue();
            foreach (var item in a)
            {
                Console.Write(item + "      ");
            }
            Console.WriteLine();

            Console.WriteLine("Amahop is present in queue" + ":" + a.Contains("Amahop"));

            Console.WriteLine();
            Console.WriteLine("Queue b");
            Queue b=(Queue)a.Clone();   //Cloning
            b.Enqueue(5000);             //add 5000 to queue
            foreach (var item in b)
            {
                Console.Write(item + "      ");
            }
            Console.WriteLine();


            b.Enqueue(a);               //pushing the Queue inside the Queue
            Console.WriteLine();
            foreach (var i in b)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (var i in b)
            {
                if (i is Queue)
                {
                    foreach (var item in (Queue)i)
                    { Console.Write(item + "    "); }
                }
                else
                {
                    Console.Write(i +"    ");
                }
            }

        }
    }
}
