using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    delegate int AddDelegate(int x,int y);
    internal class Anonymous_Method
    {
        
        static void Main()
        {
            
            AddDelegate b =(int X,int y)=>
            {
                return X + y;
            };
            Console.WriteLine(b(10,10));    
        }
    }

    internal class Anonymous_Method1
    {

        static void Main()
        {

            AddDelegate b = delegate(int X, int y) 
            {
                return X + y;
            };
            Console.WriteLine(b(10, 10));
        }
    }
}
