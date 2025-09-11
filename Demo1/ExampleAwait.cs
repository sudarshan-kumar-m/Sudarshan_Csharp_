using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class ExampleAwait
    {
        public static async Task SomeMethod()
        {
            Console.WriteLine("Some Method started");
            await Task.Delay(1000);
            Console.WriteLine("Some Method is Ended");
        }
        static void Main(string[] args)
        {
            SomeMethod();
            Console.WriteLine("Main Methos is ended");
        }
    }
}
