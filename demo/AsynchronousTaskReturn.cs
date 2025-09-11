using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class AsynchronousTaskReturn
    {
        public static async Task<int> Add(int a, int b)
        {
            await Task.Delay(1000);
            return a+ b;
        }
        
        static async Task Main()
        {
            Console.WriteLine("The programme is started..");
            int s=await Add(1,2);
            Console.WriteLine(s);
        }

    }
    
      

}
