using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public interface IInterfaceMultileInheritance
    {
        void display();
    }
    public interface Interface2: IInterfaceMultileInheritance
    {
        void display();
    }
    public class InterfaceMultipleInheritane1:IInterfaceMultileInheritance,Interface2
    {
        public void display()
        {
            Console.WriteLine($"Multiple Inheritance using Interface");
        }
        static void Main()
        {
            InterfaceMultipleInheritane1 a=new InterfaceMultipleInheritane1();
            a.display();
        }

    }
}
