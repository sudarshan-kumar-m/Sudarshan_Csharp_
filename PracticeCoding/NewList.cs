using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PracticeCoding
{
  /* public class AnimalNew
    {
        public string Name;
        public int age;

    }*/
    internal class AnimalNew : IComparer<AnimalNew>//IComparable<AnimalNew>
    {
        public string Name;
        public int age;
        public static void Display(AnimalNew anim) => Console.WriteLine(anim.Name);
        static void Main()
        {

            AnimalNew a1 = new AnimalNew() { Name = "Cat", age = 10 };
            AnimalNew a2 = new AnimalNew() { Name = "Dog", age = 12 };
            AnimalNew a3 = new AnimalNew() { Name = "Elephant", age = 13 };
            List<AnimalNew> l1 = new List<AnimalNew>();
            l1.Add(a1);
            l1.Add(a2);
            l1.Add(a3);
            Display(a1);
            l1.Sort();
            foreach (AnimalNew i in l1)
            {
                Console.WriteLine(i.age);
            }

        }

        public int Compare(AnimalNew x, AnimalNew y)
        {
            if (x.Name.Length > y.Name.Length)
                return -1;
            else if (y.Name.Length > x.Name.Length)
                return 1;
            return 0;
        }

        public int CompareTo(AnimalNew other)
        {
           //return other.CompareTo(this);
            if (other.age>this.age)
                return 1;
            else if (other.age < this.age)
                return -1;
            return 0;
        }
    }
}
