using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class ParamThreadDemo
    {
        int num1;
        int num2;
        int num3;

        public static void Add(object obj)
        {
            var (n1, n2, n3) = ((int, int, int))obj;
            Console.WriteLine(n1 + n2 + n3);
        }
        public static void Add2(object obj)
        {
            ParamThreadDemo data = (ParamThreadDemo)obj;
            Console.WriteLine(data.num1 + data.num2 + data.num3);
        }
        static async Task Main()
        {

            //ParameterizedThreadStart m1 = new ParameterizedThreadStart(Add);
            //Thread t = new Thread(m1);

            Thread t1 = new Thread(Add);
            t1.Start((1, 2, 3));

            // or

            ParamThreadDemo obj = new ParamThreadDemo() { num1 = 10, num2 = 20, num3 = 12 };
            Thread t2 = new Thread(Add2);
            t2.Start(obj);

            // or 

            //await Task.Run(() => Add((1,2,3)));
            await Task.Run(() => Add2(obj));
        }
    }
}