using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class IndexersEmploy2
    {
        string name;
        int age;
        int salary;
        string job;
        string dname;
        string location;
        public IndexersEmploy2(string n, int a, int s, string j, string d, string l)
        {
            name = n;
            age = a;
            salary = s;
            job = j;
            dname = d;
            location = l;

        }
        public object this[char index]
        {
            get
            {
                if (index == 'a')
                    return name;
                else if (index == 'b')
                    return age;
                else if (index == 'c')
                    return salary;
                else if (index == 'd')
                    return job;
                else if (index == 'e')
                    return dname;
                else if (index == 'f')
                    return location;
                return null;
            }
            set
            {
                if (index == 'a')
                    name = (string)value;
                else if (index == 'b')
                    age = (int)value;
                else if (index == 'c')
                    salary = (int)value;
                else if (index == 'd')
                    job = (string)value;
                else if (index == 'e')
                    dname = (string)value;
                else if (index == 'f')
                    dname = (string)value;
            }
        }
    }
    public class IndexersEmployDetail2: IndexersEmploy2
    {
        public IndexersEmployDetail2(string n, int a, int s, string j, string d, string l):base(n,a,s, j, d, l)
        {
        }
        static void Main()
        {
            IndexersEmployDetail2 i = new IndexersEmployDetail2("puneeth", 32, 35000, "Manger", "sales", "Mangalore");
            Console.WriteLine(i['a']);
            Console.WriteLine(i['b']);
            Console.WriteLine(i['c']);
            Console.WriteLine(i['d']);
            Console.WriteLine(i['e']);
            Console.WriteLine(i['f']);
            Console.WriteLine();
            i['d'] = "senior Developer";
            i['c'] = 70000;
            Console.WriteLine(i['d']);
            Console.WriteLine(i['c']);
        }
    }
}
