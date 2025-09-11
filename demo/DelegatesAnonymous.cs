using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate string GreetingDelegate(String name);
    internal class DelegatesAnonymous
    {

        static void Main()
        {
            DelegatesAnonymous delegates = new DelegatesAnonymous();
            GreetingDelegate g = delegate (string name)
            {
                return "Hello " + name;
            };
            string str=g("Sudarshan");
            Console.WriteLine(str);

        }
    }
}
