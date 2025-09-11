using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class accessspe2   // NON CHILD CLASS
    {
        static void Main(string[] args)
        {
            accessspe a=new accessspe();
            a.TestInternal();
            a.TestPretectedInternal();
            a.TestPublic();
        }
    }
}
