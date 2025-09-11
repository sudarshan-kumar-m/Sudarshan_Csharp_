using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first element:");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the second element:");
                int b = int.Parse(Console.ReadLine());
                int z = a / b;
                Console.WriteLine(z);
                

            }
            catch (DivideByZeroException )
            {
                throw;


            }
            catch (FormatException ex2)
            {
                Console.WriteLine($"Exception: {ex2.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }




            //catch(Exception ex)
            //{
            //    if(ex is DivideByZeroException)
            //        Console.WriteLine(ex.Message);
            //    else if(ex is FormatException)
            //        Console.WriteLine($"Exception: {ex.Message}");
            //    else if(ex is ArithmeticException)
            //         Console.WriteLine(ex.Message);
            //    else
            //        Console.WriteLine($"Exception: {ex.Message}");
            //}


            //catch (Exception ex)
            //{
            //    switch(ex)
            //    {
            //        case DivideByZeroException ex2 :
            //            {
            //                Console.WriteLine(ex2.Message);
            //                break;
            //            }
            //        case FormatException ex3 :
            //            {
            //                Console.WriteLine(ex3.Message);
            //                break;
            //            }
            //        case ArithmeticException ex4 :
            //        {
            //            Console.WriteLine(ex4.Message);
            //            break;
            //        }
            //        case Exception ex5 :
            //            {
            //                Console.WriteLine(ex5.Message); 
            //                break;
            //            }

            //    }

        }
    }
}
