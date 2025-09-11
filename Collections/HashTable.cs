using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    internal class HashTableProgramme
    {
        static void Main(string[] args)
        {
            Hashtable a = new Hashtable()
            {
                {"Location","Kundapur" },      //initialising 1st method
                {"Work Place","Mangalore" }
            };


            a[1] = "karan";                //initialising 2nd method
            a["Id"] = 30;



            a.Add("Name","sudarshan");
            a.Add("Age", 22);
            a.Add("Job", "Game Developer");
            a.Add("Salary", 15000);



            Console.WriteLine(a["Name"]);   //Extracting with Key

            foreach (object i in a.Keys)    // Extracting keys
            {
                Console.WriteLine(i + ":" + a[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Extracting through values"); //Extracting through values
            foreach (object i in a.Values)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Hashtable b = (Hashtable)a.Clone();    //Making a clone 
            b.Add("Gender", "Male");
            b["Name"] = "Karthik";
            Console.WriteLine("Cloned Element");
            foreach(DictionaryEntry i in b)
            {
                Console.WriteLine($"Key:{i.Key}  Values:{i.Value}");
            }

            Console.WriteLine(".................................................................");
            foreach(DictionaryEntry i in a)
            {
                Console.WriteLine($"Key:{i.Key}  Values:{i.Value}");
            }

           
            Console.WriteLine();
            Console.WriteLine("Converted to array form:");
            object[] m = new object[a.Count];   //converting to array
            object[] c = new object[a.Count];
            a.Keys.CopyTo(m, 0);
            a.Values.CopyTo(c, 0);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(m[i] + ":" + c[i]);
            }

            //Hashtable p = b;
            //p.Add("Year", 2025);

            //Console.WriteLine() ;
            //Console.WriteLine("object b");
            //foreach (object i in b.Keys)
            //{
            //    Console.WriteLine($"Key:{i}  Values:{b[i]}");
            //}

            //Console.WriteLine();
            //Console.WriteLine("object p");
            //foreach (object i in p.Keys)
            //{
            //    Console.WriteLine($"Key:{i}  Values:{p[i]}");
            //}

            
        }

    }
}
