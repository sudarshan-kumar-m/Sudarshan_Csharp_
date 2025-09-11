using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ExceptionHandlingTestcs
    {
        static void Main(string[] args)
        {
            int a=0, b=0;
            try
            {
                a = 1;b = 2;
                Console.Write("Enter the number:");
                int c= int.Parse(Console.ReadLine());
                
                Console.WriteLine(a +" "+b);
                
            }
            catch
            {
                a = 2;
                Console.WriteLine(a);
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
