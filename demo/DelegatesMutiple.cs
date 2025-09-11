using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public delegate void RectDelegate(double a,double b);
    internal class DelegatesMutiple
    {
        public void GetArea(double width,double height)
        {
            Console.WriteLine($"Area of the Rectangle is:{width * height}");
        }
        public void GetPerimeter(double width,double height)
        {
            Console.WriteLine($"Perimetre of the Rectangle is:{2 * (width + height)}");
        }
        static void Main()
        {
            DelegatesMutiple a=new DelegatesMutiple();
            //a.GetPerimeter(4, 5);
            //a.GetArea(4, 5);
            Console.WriteLine();
            RectDelegate r =a.GetArea;
            //Console.WriteLine(r.Invoke(4, 5));
            r += a.GetPerimeter;
            //Console.WriteLine(r.Invoke(4,5));
            r.Invoke(4,5);

        }
    }
}
