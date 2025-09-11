using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ExceptionHandlingreturn
    {
        public object Test()
        {
            try
            {
                Console.Write("Enter the 1st number:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd number:");
                int b = int.Parse(Console.ReadLine());
                int v = 2 * (a + b);
                return v;
            }
            catch(Exception ex) 
            { 
                return ex.Message;
            }
            finally
            {
                Console.WriteLine("Finally executed");
            }
        }
    }
    public class ExceptionHandlingreturn2:ExceptionHandlingreturn
    {
        static void Main()
        {
            ExceptionHandlingreturn r = new ExceptionHandlingreturn2();
            object s=r.Test();
            Console.WriteLine(s);
        }
    }
}
