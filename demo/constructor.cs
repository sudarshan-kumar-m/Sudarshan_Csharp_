using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class constructor
    {
        public string name;
        public int age;

        public constructor(string name, int age )
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine($"My name is {name} and my age is {age}" );
        }
        static void Main(string[] args)
        {
            constructor a = new constructor("Vijeth" , 23);
            a.display();
            constructor b = new constructor("Raj", 24);
            b.display();
        }
    }
}
