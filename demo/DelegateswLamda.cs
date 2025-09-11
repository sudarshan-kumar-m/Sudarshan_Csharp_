using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    //public delegate string GreetingDelegate(String name);  //because we have already defined the delegate
    internal class DelegatesLamda
    {

        static void Main()
        {
            DelegatesLamda delegates = new DelegatesLamda();
            GreetingDelegate g = ( name)  =>
            {
                return "Hello " + name;
            };
            string str = g("Sudarshan");
            Console.WriteLine(str);

        }
    }
}
