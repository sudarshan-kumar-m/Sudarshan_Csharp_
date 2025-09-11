using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ExceptionHandlingThrow
    {
        public static int Calculator(int a, int b)
        {
            return a / b;
        }
        static void Main()
        {
            try
            {
                int d = Calculator(5, 0);
                Console.WriteLine(d);
            }
            catch(Exception) 
            {
                throw;
            }
        }
    }
    public class ExceptionHandlingThrowEx
    {
        public static int Calculator(int a, int b)
        {
            return a / b;
        }
        static void Main()
        {
            try
            {
                int d = Calculator(5, 0);
                Console.WriteLine(d);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
