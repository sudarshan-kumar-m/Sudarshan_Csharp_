using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    
    internal class List1
    {
        public string Name;
        public int Age;
        public List1(string name,int age) 
        {
            Name = name;
            Age = age;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            List1 l = obj as List1;
            return this.Name == l.Name && this.Age == l.Age ;
            //return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}";
        }
        static void Main()
        {
            List<List1> list = new List<List1>();
            List1 l1 = new List1("Akash", 21);
            List1 l2 = new List1("Yashvanth", 22);
            List1 l3 = new List1("Sudarshan", 21);
            list.Add(l1);
            list.Add(l2);
            list.Add(l3);
            list.Add(new List1("Karthik", 30));
            foreach (List1 l in list)
            {
                Console.WriteLine(l.Name +" "+ l.Age);
            }
            Console.WriteLine(list.Contains(l3));

            List1 l4 = new List1("Sudarshan", 21);
            Console.WriteLine(list.Contains(l4));
            Console.WriteLine(list.Contains(new List1("Karthik", 29)));
            Console.WriteLine("...........................");
            Console.WriteLine(list.Find(g => g.Name == "Akash"));


            List1 a = list[0];
            Console.WriteLine(a.Name);
            Console.WriteLine(a.Age);
        }
    }
}
