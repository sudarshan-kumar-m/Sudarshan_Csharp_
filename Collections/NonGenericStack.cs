using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class NonGenericStack
    {
        static void Main(string[] args)
        {
            Stack c = new Stack(); //Declaring stack

            Stack a = new Stack(new object[] {50,60});  // initialising durig declaration


            a.Push(100);           //Pushing Stack(adding)
            a.Push("Udupi");
            a.Push('c');
            a.Push(3.14f);
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine(" After Pop operation.............................................");
            a.Pop();                 //Remove the top most element
            a.Pop();
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine(a.Peek());  //returns the top most element
            Console.WriteLine(a.Count);  //return the number 



            //a.Clear();                      //Clear the stack;
            //Console.WriteLine();
            //Console.WriteLine(a.Count);


            Console.WriteLine();
            Console.WriteLine("Cloning............");
            Stack b = (Stack)a.Clone();    //cloning 
            
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Copy constructor................");
            Stack T = new Stack(b);   //Copy Constructor
            foreach (var item in T)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Converting to array........");
            object[] arr = new object[b.Count+5];         //Copy to array
            b.CopyTo(arr,5);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            b.Pop();
            b.Push("Kollur");
            b.Push(a);               //pushing the statck inside the stack
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Stack in stack............");
            foreach (var i in b)
            {
                if(i is Stack)
                {
                    foreach (var item in (Stack)i)
                        { Console.WriteLine(item); }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }



            Console.WriteLine("Example");
            Dictionary<int, List<int>> m = new Dictionary<int, List<int>>();
            //List<int> l= new List<int>()
            //{
            //    500,300,600,900,563,23
            //};
            m.Add(100, new List<int> { 500, 600, 523, 698, 756 });
            foreach (var item in m.Keys)
            {
                Console.WriteLine($"Key: {item}, Values: {string.Join(", ", m[item])}");
            }






            Console.WriteLine();
            Queue d = new Queue(new object[] { 100, "Farefirst", "Amahop" });       // adding Queue to stack
            a.Push(d);
            Console.WriteLine("Adding Queue to the stack...........");
            foreach (var i in a)
            {
                if (i is Stack)
                {
                    foreach (var item in (Stack)i)
                    { Console.WriteLine(item); }
                }
                else if(i is Queue)
                {
                    foreach (var item in (Queue)i)
                    { Console.WriteLine(item); }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Adding stack to Queue...................");
            Stack k = new Stack(new object[] { 900, 500, 125, 420 });
            d.Enqueue(k);        //adding stack to Queue
            foreach (var i in d)
            {
                if (i is Stack)
                {
                    foreach (var item in (Stack)i)
                    { Console.WriteLine(item); }
                }
                else if (i is Queue)
                {
                    foreach (var item in (Queue)i)
                    { Console.WriteLine(item); }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }








            Console.WriteLine();
            Console.WriteLine("Adding ArrayList stack.............");
            Console.WriteLine();

            ArrayList h= new ArrayList() {2,3,4,6,8};
            h.Add(k);
            foreach (var i in h)
            {
                if (i is Stack f)
                {
                    Console.Write("[");
                    Console.Write(String.Join(",", f.ToArray()));
                    Console.WriteLine("]");
                    //foreach (var item in (Stack)i)
                    //{ Console.WriteLine(item); }
                }
                else if (i is Queue)
                {
                    foreach (var item in (Queue)i)
                    { Console.WriteLine(item); }
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
