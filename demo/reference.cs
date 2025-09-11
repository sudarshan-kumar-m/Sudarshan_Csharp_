using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class reference
    {
        public string name;
        public void dispaly()
        {
            Console.WriteLine("reference method");
        }
        static void Main()
        {
            reference f;
            reference b = new reference(); //instance of the class
            reference c = b;      //reference of the class
            b.dispaly();
            c.dispaly();

        }
        

    }
}
