using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public enum EnumCity
    {
        Bengalor,Mysure,Mangalore,Udupi,Ballary,Gadag,Hassan,Bagalkote,Belagavi,Kolar,Tumkur
    }
    public class Tour
    {
        static void Main()
        {
            EnumCity c = EnumCity.Gadag;
            Console.WriteLine(c);
            
        }
    }
}
