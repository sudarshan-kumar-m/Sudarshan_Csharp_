using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{

    public interface IVehicle
    {
        void Wheels();
    }
    public class Car1 : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("It has 4 wheels");
        }
    }
    public class auto : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("It has 3 wheels");
        }
    }
    public class Bike : IVehicle
    {
        public void Wheels()
        {
            Console.WriteLine("It has 2 Wheels");
        }
    }
    public class Final
    {
        public static void ConfirmVehicle(IVehicle obj)
        {
            if (obj is Car1)
            {
                Car1 c = (Car1)obj;
                obj.Wheels();
            }
            if (obj is Bike)
            {
                Bike b = (Bike)obj;
                obj.Wheels();
            }
            if (obj is auto)
            {
                auto a = (auto)obj;
                obj.Wheels();
            }

        }
        static void Main()
        {
            Final f1 = new Final();
            IVehicle v1 = new Car1();
            IVehicle v2 = new Bike();
            IVehicle v3 = new auto();
            ConfirmVehicle(v1);
            ConfirmVehicle(v2);
            ConfirmVehicle(v3);
        }
    }
    internal class Senior
    {
    }
}
