using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ExtensionCheck
    {
        static void Main()
        {
            ExtensionClass p = new ExtensionClass();
            p.add(10, 20);
            p.sub(20, 10);
            p.mul(20, 20);
            p.div(20, 20);
            int i = 6;
            Console.WriteLine($"The Factorial of {i} :{i.Factorial()}");
            string s = "HeLLo woRld";
            s.ToProper();
            p.Display();
            //p.Read();
        }

        
    }
}
