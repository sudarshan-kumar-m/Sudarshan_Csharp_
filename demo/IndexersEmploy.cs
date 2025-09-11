using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public struct IndexersEmploy
    {
        string name;
        int age;
        int salary;
        string job;
        string dname;
        string location;
        public IndexersEmploy(string n,int a,int s, string j, string d, string l)
        {
            name = n;
            age = a;
            salary = s;
            job = j;
            dname = d;
            location = l;

        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return name;
                else if (index == 1)
                    return age;
                else if (index == 2)
                    return salary;
                else if (index == 3)
                    return job;
                else if (index == 4)
                    return dname;
                else if (index == 5)
                    return location;
                return null;
            }
            set
            {
                if (index == 0)
                    name = (string)value;
                else if (index == 1)
                    age = (int)value;
                else if(index == 2)
                    salary = (int)value;
                else if (index == 3)
                    job = (string)value;
                else if(index==4)
                    dname = (string)value;
                else if (index==5)
                    dname = (string)value;
            }
        }
    }
    public class IndexersEmployDetail
    {
        static void Main()
        {
            IndexersEmploy i = new IndexersEmploy("Raj",23,15000,"Developer","IT","Mangalore");
            Console.WriteLine(i[0]);
            Console.WriteLine(i[1]);
            Console.WriteLine(i[2]);
            Console.WriteLine(i[3]);
            Console.WriteLine(i[4]);
            Console.WriteLine(i[5]);
            Console.WriteLine();
            i[3] = "senior Developer";
            i[2] = 50000;
            Console.WriteLine(i[3]);
            Console.WriteLine(i[2]);
        }
    }
}
