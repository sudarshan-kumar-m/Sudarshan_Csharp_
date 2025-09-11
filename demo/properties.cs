using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class properties
    {
        private int _age = 18;
        static string _citys="Udupi";
        public int age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 19)
                    _age = value;
            }
        }
        public static string citys //only get access
        {
            get
            {
                return _citys;
            }
        }
        static void Main(string[] args)
        {
            properties a = new properties();
            a.age = 100;
            Console.WriteLine(citys);
            Console.WriteLine(a.age);

        }
       
    }
    public class properties1
    {



        public string name
        {
            get;
        } = "sudarshan";
        static void Main()
        {
            properties1 p = new properties1();

            Console.WriteLine(p.name);
        }
    }
    

    public class NewProject
    {
        public string CardNumber;
        public string Name;
        static void Main( string[] args )
        {
            NewProject p = new NewProject()
            {
                CardNumber = "201",
                Name = "Yashvanth"
            };
            Console.WriteLine(p.CardNumber);
            Console.WriteLine(p.Name);

        }
    }
}
