using System;
using System.Collections.Generic;
namespace Collections
{
    internal class Employee
    {
        public int ID, Salary;
        public string Name, Gender;
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name="Raj",
                Salary=20000,
                Gender="Male"
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Kavitha",
                Salary = 25000,
                Gender = "Female"
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Ram",
                Salary = 15000,
                Gender = "Male"
            };
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(emp1);
            stack.Push(emp2);
            stack.Push(emp3);
            stack.Push(new Employee()
            {
                ID = 104,
                Name = "Kiran",
                Salary = 45000,
                Gender = "Male"
            });
            foreach(Employee i in stack)
            {
                Console.WriteLine($"{i.ID}, {i.Name}, {i.Gender}, {i.Salary}");
            }

            Console.WriteLine();
            Console.WriteLine("Retrive using POP Method");
            Employee e1 = stack.Pop();
            Console.WriteLine($"{e1.ID}, {e1.Name}, {e1.Gender}, {e1.Salary}");

        }
    }
}
