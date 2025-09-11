using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class ExceptionHandlingApplication
    {
        static void Main()
        {
            Console.Write("Enter the 1st element:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the 2nd Element:");
            int b = int.Parse(Console.ReadLine());
            if(b%2!=0)
            {
                throw new Exception("Attempted with odd number");
            }
            int z = a / b;
            Console.WriteLine(z);
        }
    }
}
