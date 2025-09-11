using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class DivideByOddNumberException:Exception
    {
        public override String Message
        {
            get
            {
                return "Exception:Attempted wth a odd number";
            }
        }
    }
    internal class ExceptionHandlingApplication1
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter the 1st element:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd Element:");
                int b = int.Parse(Console.ReadLine());
                if (b % 2 != 0)
                {
                    throw new DivideByOddNumberException();
                }
                int z = a / b;
                Console.WriteLine(z);
            }

            finally
            {
                Console.WriteLine("Finally is executed");
            }
            Console.WriteLine("End of the Programme");
        }
    }
}
