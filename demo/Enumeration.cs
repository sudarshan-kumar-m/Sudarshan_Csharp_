using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public enum letter
    {
        a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z
    }
    internal class Enumeration
    {
        static void Main(string[] args)
        {
            letter a = (letter)5;
            Console.WriteLine(a);
            var b = letter.m;
            Console.WriteLine((int)b);
            foreach (int i in Enum.GetValues(typeof(letter)))
                Console.WriteLine(i);
            //foreach(string s  in Enum.GetNames(typeof(letter)))
            //    Console.WriteLine(s);
            //foreach(int i in Enum.GetValues(typeof(letter)))
            //    Console.WriteLine($"{i}:{(letter)i}");


        }
    }
}
