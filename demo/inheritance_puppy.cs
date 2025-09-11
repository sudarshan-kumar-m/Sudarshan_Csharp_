using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class inheritance_puppy:inheritance_dog
    {
        public new static void bark()
        {
            Console.WriteLine("Meow");
        }
        public void run()
        {
            Console.WriteLine("It can run");
        }
        static void Main()
        {
            inheritance_dog b = new inheritance_puppy();
            b.sleep();
            

            inheritance_puppy.bark();
            inheritance_puppy a = new inheritance_puppy();
            a.swim();
            a.sleep();
            a.run();
            inheritance_puppy.q = 10;
            Console.WriteLine(inheritance_dog.q);
            
        }
    }
}
