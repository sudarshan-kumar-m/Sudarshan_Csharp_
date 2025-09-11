using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class testing
    {
        public static (int sum,int difference,int Max,int min) Operation(int a,int b)
        {
            return(a+b,a-b,a>b?a:b,a<b?a:b);
        }
        static void Main()
        {
            var s = Operation(20, 10);
            Console.WriteLine($"sum:{s.sum}, difference:{s.difference}, Maximam:{s.Max}, Minimum:{s.min}");

        }
    }
    internal class tuple2
    {
        static void Main()
        {
            Tuple<string,int> s = new Tuple<string, int>("Sudarshan", 100);
            Console.WriteLine(s.Item1 + " " + s.Item2);
        }
    }
}
