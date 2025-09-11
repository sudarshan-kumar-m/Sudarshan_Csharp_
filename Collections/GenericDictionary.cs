using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> a = new Dictionary<int, string>()
            {
                {1,"One" },
                {2,"Two" },
                {3,"Three"},
                {4,"Four" }
            };

            a.Add(6, "Six");
            a.Add(5, "Five");
            Console.WriteLine("Accessing by for-each loop");           //accessing by for-each
            foreach(KeyValuePair<int,String> p in a)
            {
                Console.WriteLine($"Key:{p.Key}, Value:{p.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Accessing by for loop");
            for( int i=0;i<a.Count;i++)                                   //accessing by for
            {
                var key=a.Keys.ElementAt(i);
                var value = a[key]; 
                Console.WriteLine($"Key:{key}, Value:{value}");
                
            }
            Console.WriteLine();
            Console.WriteLine(a[5]);

            Console.WriteLine();
            Console.WriteLine("Access by AsParall.ForAll");              //Access by AsParall.ForAll"
            a.AsParallel().ForAll(entry => Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}"));
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location {  get; set; }
    }
    public class ComplexDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int,Student> d =new Dictionary<int,Student>()
            {
                {101,new Student(){ID=10,Name="Mohan",Location="Mangalore"} },
                {102,new Student(){ID=11,Name="Praveen",Location="Kundapur"} },
                {103,new Student(){ID=13,Name="Pream",Location="Udupi"} },
                //{101,new Student(){ID=13,Name="Pream",Location="Udupi"} } provides the error
            };
            foreach(KeyValuePair<int,Student> e in d)
                Console.WriteLine($"Key:{e.Key}, Value:ID - {e.Value.ID}  Name - {e.Value.Name} Location - {e.Value.Location}");

            Student s;
            if (d.TryGetValue(102, out s))               //TryGetValue: To check whether key is present or not
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {s.ID}, Name: {s.Name}, Branch: {s.Location}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }
        }
    }
}
