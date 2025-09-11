using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Collections
{
    internal class LinkedListProgramme
    {
        
        static void Main(string[] args)
        {
            LinkedList<int> a = new LinkedList<int>();
            var node =a.AddFirst(1);             //creat a node
            a.AddFirst(25);
            //LinkedListNode<int> node = new LinkedListNode<int>();
            a.AddAfter(node, 36);
            var node1 = a.Find(1);             //assign the value to the node
            Console.WriteLine(node1.Next.GetHashCode());
            Console.WriteLine(node1.Previous.GetHashCode());
            Console.WriteLine(node.Value);
            Console.WriteLine("\n");
            a.AddBefore(node1, 90);
            a.AddAfter(node1, 120);
            
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine();
            LinkedList<int> d = new LinkedList<int>(new[]{ 23, 30, 40, 360, 420,90 });
            var node2 = d.Find(420);
            d.Remove(node2 );
            a.AddAfter(node1, node2);
            LinkedListNode<int> newNode = new LinkedListNode<int>(900);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            a.AddAfter(node2 , newNode );
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class LinkedObject
    {
        public string Name;
        public int AGe;
        public override int GetHashCode()
        {
            Console.WriteLine("GetHashCode..............");
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Equals.............");
            //return base.Equals(obj);

            return obj is LinkedObject other && this.AGe == other.AGe;
        }
        public LinkedObject(string name,int age)
        {
            Name= name;
            AGe= age;
        }
        public static void Main()
        {
            LinkedObject l1 = new LinkedObject("Sudarshan", 100);
            LinkedObject l2 = new LinkedObject("Akash", 200);
            LinkedObject l3 = new LinkedObject("Yashvanth", 300);
            LinkedObject l4 =new LinkedObject("Sukesh", 500);
            LinkedList<LinkedObject> linkedlist = new LinkedList<LinkedObject>();
            linkedlist.AddFirst(l1);
            linkedlist.AddFirst(l2);
            linkedlist.AddFirst(l3);
            //linkedlist.AddFirst(l4);



            foreach (LinkedObject l in linkedlist)
            {
                Console.WriteLine(l.Name + " " + l.AGe);
            }
            Console.WriteLine("---------------------------------------------------------------------1");
            
            LinkedListNode<LinkedObject> current = linkedlist.First;
            while (current != null)
            {
                var next = current.Next;
                if (current.Value.Name == "Sudarshan")
                    linkedlist.Remove(current);
                current = next;

            }
            //linkedlist.Remove(l1.Name);
            foreach (LinkedObject l in linkedlist)
            {
                Console.WriteLine(l.Name+" "+ l.AGe);
            }
            Console.WriteLine("---------------------------------------------------------------------2");

            var matchnode = linkedlist.Find(linkedlist.First(p => p.AGe == 200));
           
            if (matchnode != null)
            {
            
                //linkedlist.AddAfter(matchnode, new LinkedObject("Karthik", 500));
                linkedlist.AddAfter(matchnode, l4); //Add
            }
            Console.WriteLine("---------------------------------------------------------------------3");

            linkedlist.AddAfter(linkedlist.Find(new LinkedObject("Akash", 200)), l4);     //Add
            Console.WriteLine("--------------------------");
            foreach (LinkedObject l in linkedlist)
            {
                Console.WriteLine(l.Name + " " + l.AGe);
            }

          
        }
    }
}
