using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    static class ExtensionMethod
    {
        public static void mul(this ExtensionClass e, double a, double b)
        {
            Console.WriteLine($"{a} * {b}:{a*b}");
        }
        internal static void div(this ExtensionClass d, double a, double b)
        {
            Console.WriteLine($"{a} / {b}:{a/b}");
        }
        public static double Factorial(this Int32 e)
        {
            if (e == 0 || e == 1)
                return e;
            else
                return e * Factorial(e - 1);
        }
        public static void Display(this ExtensionClass a)
        {
            Console.WriteLine("Extension of method");
        }
        public static void ToProper(this string s)
        {
            string str = "";
            if (s.Trim().Length>0)
            {
                s=s.ToLower();
                char p = Char.ToUpper(s[0]);
                str += p;
                for(int i=1; i<s.Length; i++)
                {
                    if((char)s[i-1] != ' ' )
                    {
                        str += s[i];
                    }
                    else
                    {
                        p=char.ToUpper(s[i]);
                        str += p;
                    }
                }
            }
            Console.WriteLine(str);
        }
        public static void Read(this InterfaceClass d)
        {
            Console.WriteLine("Reading");
        }
    }
}
