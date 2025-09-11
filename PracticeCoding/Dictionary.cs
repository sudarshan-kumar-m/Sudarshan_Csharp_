using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class DictionaryProgramme
    {
        public string Name;
        public int age;

        public override int GetHashCode()
        {
            //Console.WriteLine("GetHashCode....................");
            string a = Name;
            return a.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            //Console.WriteLine("Equal Function.................");
            DictionaryProgramme person = (DictionaryProgramme)obj;
            return (this.age==person.age && this.Name==person.Name);
        }
        public DictionaryProgramme(string name, int age)
        {
            Name = name;
            this.age = age;
        }
        static void Main(string[] args)
        {
            DictionaryProgramme p1 = new DictionaryProgramme("Akash", 23);
            DictionaryProgramme p2 = new DictionaryProgramme("Yash", 21);
            Dictionary<DictionaryProgramme, string> dict = new Dictionary<DictionaryProgramme, string>()
            {
                {p1,"a" },
                {p2,"b" },
                
            };
            foreach (KeyValuePair<DictionaryProgramme, string> i in dict)
            {
                Console.WriteLine(i.Value);
            }
            DictionaryProgramme Key = dict.Keys.FirstOrDefault(Keys => Keys.Name == "Akash");
            dict.Remove(Key);
            foreach (KeyValuePair<DictionaryProgramme, string> i in dict)
            {
                Console.WriteLine(i.Value);
            }

            Console.WriteLine("............................................................................");
            Dictionary<int, string> dict1 = new Dictionary<int, string>()
            {
                {1,"One"},
                {2,"Two"},
                {3,"Three" },
                {4,"Four" },
            };

            Console.WriteLine("Using foreach loop.......................................");
            foreach(KeyValuePair<int,string> i in dict1 )
            {
                Console.WriteLine(i.Key + " " +i.Value);
            }
            Console.WriteLine("Using for loop.......................................");
            for(int i=0;i<dict1.Count;i++)
            {
                //int key=dict1.Keys.ElementAt(i);
                //string value=dict1[key];
                //Console.WriteLine(key+" " + value);

                Console.WriteLine(dict1.Keys.ElementAt(i) + " " + dict1[dict1.Keys.ElementAt(i)]);
            }


            //List<int> dictToList = dict1.Keys.ToList<int>();
            List<int> dictToList = new List<int>();
            dictToList.AddRange(dict1.Keys);
            dictToList.Add(1);
            foreach (int i in dictToList )  //dict keys to list
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Array");
            int[] arr = new int[dict1.Count];
            dict1.Keys.CopyTo(arr, 0);        //dict to array
            foreach(int i in arr )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hashset");
            HashSet<int> hash = dictToList.ToHashSet();
            foreach(int i in hash )
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Sorted Dictionary");
            SortedDictionary<int,string> sortedDict = new SortedDictionary<int,string>(dict1);
            foreach(KeyValuePair<int,string> kvp in sortedDict )
            {
                Console.WriteLine(kvp.Key +":"+kvp.Value);
            }
            Console.WriteLine();
            List<int> hashToList = hash.ToList();
            foreach(int i in hashToList)
            {
                Console.WriteLine(i);
            }

        }
    }
}
