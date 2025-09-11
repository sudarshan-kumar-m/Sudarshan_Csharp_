using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    abstract class Animal
    {
        public abstract void Eat();

    }

    interface IWalk
    {
        void Walk();
    }

    class Dog : Animal, IWalk
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }

        public void Walk()
        {
            Console.WriteLine("Dog is walking");
        }
        static void Main()
        {
            Dog s= new Dog();
            s.Walk();
            s.Eat();

        }
    }
    public class Test
{
    public static int DangerousMethod()
    {
        try
        {
            Console.WriteLine("In Try");
            return 1;
        }
        catch (Exception)
        {
            Console.WriteLine("In Catch");
            return 2;
        }
        finally
        {
            Console.WriteLine("In Finally");
                int d = Convert.ToInt32(Console.ReadLine());
        }
    }

    static void Main()
    {
        int result = DangerousMethod();
        Console.WriteLine("Result: " + result);
    }
}


}
