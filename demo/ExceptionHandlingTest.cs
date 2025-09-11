using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class ExceptionHandlingTest
    {
        public static void Add(int a,int b)
        {
            try
            {
                Console.WriteLine("Enter the value 1:");
                int i=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(i);
            }
            catch
            {
                
            }
            finally
            {
                
            }
        }
        static void Main()
        {
            Add(4, 5);
        }
    }
}
