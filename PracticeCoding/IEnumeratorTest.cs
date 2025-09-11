using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class IEnumeratorTest
    {
        static void Main()
        {
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Elephant");
            animals.Add("Monkey");
            //IEnumerator<string> enumerator = animals.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    string anim = (string)enumerator.Current;
            //    Console.WriteLine(anim);
            //    animals.Remove(enumerator.Current);
            //}
            //Console.WriteLine(animals.Count);

            foreach (string animal in animals.ToArray())
            {
                animals.Remove(animal);
            }
            Console.WriteLine(animals.Count);
        }
    }
    /// <summary>
    /// 
    /// Remove the same id from the list
    /// 
    /// </summary>
    internal class  car
    {
        
        public string name;
        public int id;
    }
    internal class IEnumeratorTest1
    {
        static void Main()
        {
            List<car> cars = new List<car>();
            car c1 = new car() { name = "car1", id = 1 };
            car c2 = new car() { name = "car2", id = 2 };
            car c3 = new car() { name = "car3", id = 3 };
            car c4 = new car() { name = "car4", id = 1 };
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);

            foreach (car c in cars.ToArray())
            {
                Console.WriteLine(c.name +" "+ c.id);
                if(c.id == 1)
                    cars.Remove(c);
            }

            Console.WriteLine();
            foreach (car c in cars.ToArray())
            {
                Console.WriteLine(c.name +" "+ c.id);
                
            }
        }
    
    }
    /// <summary>
    /// 
    /// IEnumerator for dictionary
    /// 
    /// </summary>

    internal class IEnumerator2
    {
        static void Main()
        {
            DictionaryProgramme p1 = new DictionaryProgramme("Akash", 23);
            DictionaryProgramme p2 = new DictionaryProgramme("Yash", 21);
            Dictionary<DictionaryProgramme, string> dict = new Dictionary<DictionaryProgramme, string>()
            {
                {p1,"a" },
                {p2,"b" },

            };
            IEnumerator<KeyValuePair<DictionaryProgramme, string>> enumerator = dict.GetEnumerator();
            while (enumerator.MoveNext())
            {
                //KeyValuePair<DictionaryProgramme,string> e = enumerator.Current;
                Console.WriteLine(enumerator.Current.Key.age);
            }
        }
    }


    internal class Enumerator
    {
        static void Main()
        {
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dog");
            animals.Add("Elephant");
            animals.Add("Monkey");

            //IEnumerator enumerator1 = animals.ToArray().GetEnumerator();
            IEnumerator<string> enumerator = ((IEnumerable<string>)animals.ToArray()).GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Current == "Elephant")
                    animals.Remove(enumerator.Current);
            }
            Console.WriteLine(animals.Count);

            //foreach (string animal in animals.ToArray())
            //{
            //    animals.Remove(animal);
            //}
            //Console.WriteLine(animals.Count);
        }
    }



}
