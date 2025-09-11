using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class IInterfaceMultiplrInheritance2:IInterfaceMultileInheritance,Interface2
    {

        void IInterfaceMultileInheritance.display()
        {
            Console.WriteLine("Execute the function of 1st interface");
        }
        //void Interface2.display()
        //{
        //    Console.WriteLine("Execute the function of 2nd interface");
        //}
        public void display()
        {
            Console.WriteLine("Execute the function of class ");
        }
        static void Main()
        {
            IInterfaceMultiplrInheritance2 k= new IInterfaceMultiplrInheritance2();
            IInterfaceMultileInheritance m = k;
            m.display();


            Interface2 n = k;
            n.display();

            k.display();
        }
    }
}
