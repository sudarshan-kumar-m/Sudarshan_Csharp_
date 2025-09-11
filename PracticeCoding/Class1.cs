using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    public class Animal1:IComparable<Animal1>
    {
        public string Name;
        public int Age;
        public Animal1(string name,int age)
        {
            Name=name;  
            Age=age;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public int CompareTo(Animal1 other)
        {
            //if (other.Age > this.Age)
            //    return 1;
            //else if (other.Age < this.Age)
            //    return -1;
            //else
            //    return 0;
            return other.Name.CompareTo(this.Name);
            

        }

        public override bool Equals(object obj)
        {
            Console.WriteLine(obj);
            Console.WriteLine(typeof(Animal1) == obj.GetType());
            if (obj == null) return false;
            //if (!(obj is Animal1)) return false;

            if (!(typeof(Animal1) == obj.GetType()))
            {
                Console.WriteLine("Wrong");
                return false;
            }
            Animal1 ob = (Animal1)obj;
            return ob.Name == this.Name && ob.Age == this.Age;
        }
    }
    
    internal class Class1:IComparer<Animal1>
    {
        public static void Display(List<Animal1> a)
        {
            foreach(Animal1 c in a)
            {
                Console.WriteLine(c.Name+ " "+ c.Age);
            }
            
        }
        static void Main()
        {
            Class1 cl1 = new Class1();
            Animal1 a1 = new Animal1("cat", 5);
            Animal1 a2 = new Animal1("Dog", 6);
            Animal1 a3 = new Animal1("cat", 7);
            List<Animal1> l1 = new List<Animal1>();
            l1.Add(a1);
            l1.Add(a2);
            l1.Remove(a3);
            Car c1= new Car();
            //List<Animal1> l2 = new List<Animal1>(l1);
            //a1.Name = "bird";
            Console.WriteLine("-------------------------------------");
            a1.Equals(a1);
            l1.Sort(cl1);
            Display(l1);
        }

        public int Compare(Animal1 x, Animal1 y)
        {
            //if(x.Age>y.Age)
            //    return 1;
            //if (x.Age < y.Age)
            //    return -1;
            //return 0;
            return y.Name.CompareTo(x.Name);
        }
    }
    public class Car
    {

    }
}
