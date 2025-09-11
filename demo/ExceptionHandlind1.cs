using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class ExceptionHandlind1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the 1st element:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the 2nd Element:");
                int b = int.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine(z);
                if (z == 1)
                {
                    return;
                }
                
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
                
            }
            finally
            {
                Console.WriteLine("Finally is executed");
                try
                {
                    Console.Write("Enter the number:");
                    int m = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            Console.WriteLine("End of the Programme");
        }
    }
}
