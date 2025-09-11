using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class accessspe1:accessspe                        //Child class
    {
        static void Main(string[] args)
        {
            accessspe1 b=new accessspe1();
            b.TestInternal();
            b.TestProtected();
            b.TestPretectedInternal();
            b.TestPublic();
        }
    }
}
