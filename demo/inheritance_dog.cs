using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class inheritance_dog
    {
        public static int q;
        public int s=10;
        //public inheritance_dog()
        //{
        //    Console.WriteLine("Constructor of parent class");
        //}
        public static void bark()
        {
            Console.WriteLine("It can bark ");
        }
        protected void swim()
        {
            Console.WriteLine("It can swim");
        }
        public void sleep()
        {
            Console.WriteLine("It can sleep");
        }
    }
}
