using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class GenericConstraints<T> where T:struct//class
    {
        public T Message;
        public GenericConstraints(T message)
        {
            Message = message;
        }
        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
            
        }
    }
    public class Employees
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class GenericConstraintsProgramme
    {
        static void Main()
        {
            GenericConstraints<int> intClass = new GenericConstraints<int>(10);
            intClass.Message = 30;
            intClass.GenericMethod(10, 20);
            Console.ReadKey();
        }
    }

}
