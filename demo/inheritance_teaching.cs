using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class inheritance_teaching:inheritance_staff
    {
        public string qualification;
        public string subject;
        static void Main()
        {
            inheritance_teaching t= new inheritance_teaching();
            t.name = "Rajesh";
            t.id = 12;
            t.address = "XYZ";
            t.phone = 7849561235;
            t.salary = 15000;
            t.qualification = "B.E";
            t.subject = "Maths";
            Console.WriteLine($" Name:{t.name}\n ID is:{t.id} \n adress:{t.address}\n Phone No:{t.phone}\n Salary:{t.salary}\n Qualification:{t.qualification}\n Subject :{t.subject}");

        }
    }
}
