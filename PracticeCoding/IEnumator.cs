using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class IEnumatorProgramme
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Date");
            fruits.Add("Elderberry");

            // Iterate over the List using a foreach loop
            /*Console.WriteLine("Through ForEach loop");
            foreach (string fruit in fruits.ToArray())
            {
                Console.WriteLine(fruit);
                fruits.Remove(fruit);
            }*/
            Console.WriteLine(fruits.Count());

            Console.WriteLine();
            Console.WriteLine("Through IEnumerator");

            // Iterate over the List using an IEnumerator object
            IEnumerator<string> enumerator = fruits.GetEnumerator();
            while (enumerator.MoveNext())
            {
                //string fruit = (string)enumerator.Current;
                //Console.WriteLine(fruit);
                Console.WriteLine(enumerator.Current);
            }


        }
    }


























    internal class IEnumatorProgramme1
    {
        public void first3(IEnumerator a)
        {
            int count = 1;
            while(a.MoveNext())
            {
                Console.WriteLine(a.Current.ToString());
                count++;
                if (count == 3)
                    last2(a);
            }
        }
        public void last2(IEnumerator b)
        {
            while(b.MoveNext())
            {
                Console.WriteLine(b.Current.ToString());
            }
        }
        static void Main(string[] args)
        {
            IEnumatorProgramme1 p = new IEnumatorProgramme1();
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");
            fruits.Add("Date");
            fruits.Add("Elderberry");

            IEnumerator enumerator = fruits.GetEnumerator();
            
            p.first3(enumerator);

        }
    }
}
