// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Try programiz.pro");


        Animal a1 = new Animal(1, "Cat");
        Animal a2 = new Animal(2, "Dog");
        Animal a3 = new Animal(1, "Cat");

        Dictionary<Animal, int> l = new Dictionary<Animal, int>();
        l[a1] = 100;
        l[a2] = 200;
        l[a3] = 300;

        // l.Add(a1,100);
        //l.Add(a2,200);
        // l.Add(a3,300);


        Console.WriteLine("Size " + l.Count);
        foreach (KeyValuePair<Animal, int> kvp in l)
        {

            Console.WriteLine("Key = {0},/// Value = {1}", kvp.Key, kvp.Value);
        }
    }

    public class Animal
    {
        public int age;
        public string name;

        public Animal(int age, string name)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object other)
        {


            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (!(other is Animal)) return false;
            Animal a = other as Animal;

            Console.WriteLine("Equals called, a.age " + a.age + " this.age " + this.age);
            return a.name == this.name && a.age == this.age;

        }

        public override string ToString()
        {
            return $"age {age} name {name}";
        }

        public override int GetHashCode()
        {
            //Console.WriteLine ("GetHashCode called");
            unchecked
            {
                int hashCode = name.GetHashCode();
                hashCode = (hashCode * 397) ^ age.GetHashCode();

                Console.WriteLine("GetHashCode called, this.age " + this.age);
                return hashCode;
            }
        }


    }
}