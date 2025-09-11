using System;
using System.Collections;

namespace PracticeCoding
{
    internal class Animal
    {
        public string Name;
        public int age;

        public override int GetHashCode()
        {
            Console.WriteLine("GetHashCode....................");
            //string a = Name ;
            return age.GetHashCode();
            //return Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Equal Function.................");
            Animal animal = (Animal)obj;
            //return this.age.Equals(animal.age) && this.Name.Equals(animal.Name);
            return this.age.Equals(animal.age);

        }

        public Animal(string name, int age)
        {
            Name = name;
            this.age = age;
        }
        public Animal(int age)
        {
            this.age = age;
        }
        public override string ToString()
        {
            return $"Name:{Name}, age:{age}";
        }
        static void Main(string[] args)
        {
            Animal a1 = new Animal("Karthik", 20);
            Animal a2 = new Animal("Akash", 21);
            Animal a3 = new Animal("Yashvanth", 23);
            Hashtable h1 = new Hashtable();
            //Hashtable h2 = new Hashtable();
            h1.Add(a1, 103);
            Console.WriteLine("-------------------------------------------------------------------------- 0");
            h1.Add(a2, 200);
            Console.WriteLine("-------------------------------------------------------------------------- 0.5");
            h1.Add(a3, 500);
            h1.Add(new Animal("Lion", 22), 250);

            ////h1.Add(a4,600);
            ////-------------------------------------------------------------------------------------------
            ////Console.WriteLine(a1.Name.GetHashCode());
            ////Console.WriteLine(a2.Name.GetHashCode());
            ////Console.WriteLine(a3.Name.GetHashCode());
            //Console.WriteLine("-------------------------------------------------------------------------- 1");
            //Console.WriteLine(a1.Name.Equals(a2.Name));
            //Console.WriteLine(a1.Name.Equals(a3.Name));
            //Console.WriteLine("-------------------------------------------------------------------------- 2");
            ////-------------------------------------------------------------------------------------------
            //string s = "Sudarshan";
            //string s1 = "Sudarshan";

            //Console.WriteLine(s.GetHashCode());
            //Console.WriteLine(s1.GetHashCode());
            //Console.WriteLine("-------------------------------------------------------------------------- 3");

            //Console.WriteLine(a1.Equals(a2));
            //Console.WriteLine(a1.Equals(a1));
            //Console.WriteLine(a1.GetHashCode());
            //Console.WriteLine(a2.GetHashCode());
            //Console.WriteLine("-------------------------------------------------------------------------- 4");
            //Console.WriteLine(h1.Contains(a1));
            ////Console.WriteLine(a1);
            //Console.WriteLine();
            //foreach (Animal j in h1.Keys)
            //{
            //    Console.WriteLine(j.Name+" "+j.age);
            //}
            //h1.Remove(new Animal(22));
            //Console.WriteLine();
            //foreach (Animal j in h1.Keys)
            //{
            //    Console.WriteLine(j.Name+" "+j.age);
            //}





            foreach (Animal j in h1.Keys)
            {
                Console.WriteLine(j.Name + " " + j.age);
            }
            Console.WriteLine("---------------------------------------------------------5");
            a3.age = 20;
            foreach (Animal j in h1.Keys)
            {
                Console.WriteLine(j.GetHashCode());
                Console.WriteLine(j.Name + " " + j.age);
            }
            Console.WriteLine("---------------------------------------------------------6");
            Animal anim = new Animal("Lion", 23);
            foreach (DictionaryEntry j in h1)
            {
                //Console.WriteLine($"{((Animal)(j.Key)).Name}, {((Animal)(j.Key)).age}, {j.Key.GetHashCode()}:{j.Value}");
                if ((int)j.Value == 500)
                {
                    Console.WriteLine(((Animal)j.Key).GetHashCode());
                    //Console.WriteLine(((Animal)j.Key).age);
                    anim = (Animal)j.Key;
                }
            }


            Console.WriteLine(h1[anim]);

            Console.WriteLine("---------------------------------------------------------7");
            Console.WriteLine(h1[new Animal("Lion", 23)]);
            Console.WriteLine("---------------------------------------------------------8");
            Console.WriteLine(h1[a1]);
            Console.WriteLine(h1[a3]);
            Console.WriteLine(h1.Count);
            Console.WriteLine("---------------------------------------------------------9");
            foreach(DictionaryEntry i in h1)
                { Console.WriteLine(i.Key + " " +i.Value); }
        }
    }
}
