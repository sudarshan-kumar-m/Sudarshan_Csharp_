using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public abstract class AbstractFigures
    {
        public int x = 20;
        public double height, width, radius;
        public const float Pi = 3.14f;
        public abstract double GetPerimeter();

    }    
    public class AbstractRectange : AbstractFigures
    {
        public AbstractRectange(double x, double y)
        {
            width = x;
            height = y;
        }
        public override double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
    public class AbstractCircle :AbstractFigures
    {
        public AbstractCircle(double r)
        {
            radius = r;
        }
        public override double GetPerimeter()
        {
            return 2 * Pi * radius;
        }
    }
    public  class AbstractTrinagle:AbstractFigures
    {
        public AbstractTrinagle(double x, double y)
        {
            width = x;
            height = y;
        }
        public override double GetPerimeter()
        {
            return (width * height) / 2;
        }
    }
    public class AbstractPerimeter
    {
        static void Main()
        {
            AbstractRectange r = new AbstractRectange(4, 5);
            AbstractTrinagle t = new AbstractTrinagle(4, 5);
            AbstractCircle c = new AbstractCircle(3);
            Console.WriteLine($"Rectangle perimeter:{r.GetPerimeter()}");
            Console.WriteLine($"Tringle perimeter:{t.GetPerimeter()}");
            Console.WriteLine($"Circle perimeter:{c.GetPerimeter()}");
        }

        
    }
}
