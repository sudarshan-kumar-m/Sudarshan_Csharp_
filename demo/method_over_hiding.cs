using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class method_over_hiding                       //parent class
    {
        public void display()
        {
            Console.WriteLine("Original statement");
        }
       
    }
    public class method_overhiding1:method_over_hiding   //child class
    {

        public new void display()
        {
            Console.WriteLine("Altered statement");
        }
        static void Main(string[] args)
        {
            method_over_hiding n=new method_over_hiding();  //to access the parent display by ceating the instance of parent class
            n.display();
            method_overhiding1 d= new method_overhiding1();  
            d.display();
            method_over_hiding m = new method_overhiding1();//to access the parent class ny creating the reference of the parent using child class
            m.display();

    
        }
    }
}
