using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class constructor1
    {
        public string tittle;
        public string author;
        public int year;
        public constructor1(string t, string a, int y)
        {
            tittle = t;
            author = a;
            year = y;
        }
        public void display()
        {
            Console.WriteLine($"The book tittled {tittle}, which is written by {author} was published on {year}");
        }
        static void Main()
        {
            constructor1 s = new constructor1("Smart reader for blind people", "Raj", 2025);
            s.display();
        }
    }
}
