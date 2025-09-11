using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Properties
{
    internal class StringBuilderMethod
    {
        static void Main()
        {
            StringBuilder b = new StringBuilder("hii");
            //b.Append("Sudarshan");
            //Console.WriteLine(b.Capacity);


            //Console.WriteLine(b);

            StringBuilder a = new StringBuilder("SudarshanSufdarshanSudarsahj");
            //Console.WriteLine(a);

            //Console.WriteLine(a.GetHashCode());

            //a.Append(" to");
            //Console.WriteLine(a);
            //a.Append(" Csharp world");
            //Console.WriteLine(a);


            //a.Remove(3, 1);  // 1st parameter Index and 2nd parameter number of letters to be removed
            //Console.WriteLine(a);


            //a.Insert(11, "my ");//1st is index number.
            //Console.WriteLine(a);

            //a.Replace("world", "universe");
            //Console.WriteLine(a);


            //a.Clear();
            //Console.WriteLine(a);


            a.Clear();
            a.Append("hii");
            Console.WriteLine(a);

            //StringBuilder b = new StringBuilder(100);

            Console.WriteLine(b);

            
            Console.WriteLine(a.Length);
            Console.WriteLine(b.Length);
            Console.WriteLine(a.Capacity);
            Console.WriteLine(b.Capacity);
            Console.WriteLine(a.MaxCapacity);
            Console.WriteLine(b.MaxCapacity);
            Console.WriteLine(a.ToString().Equals(b.ToString()));
            Console.WriteLine(a.Equals(b));


            string s = "Yashvanth";
            string d = "Yashvanth";
            Console.WriteLine(s == d);
            Console.WriteLine("Reference:" + ReferenceEquals(s, d));



            StringBuilder x = new StringBuilder(100);
        }
    }
}
