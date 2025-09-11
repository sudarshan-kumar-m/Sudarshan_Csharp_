using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class accessspe
    {
        private void TestPrivate()
        {
            Console.WriteLine("Private is working");
        }
        internal void TestInternal()
        {
            Console.WriteLine("internal is working");
        }
        protected void TestProtected()
        {
            Console.WriteLine("Protected is working");
        }
        protected internal void TestPretectedInternal()
        {
            Console.WriteLine("Protected internal is working");
        }
        public void TestPublic()
        {
            Console.WriteLine("Public is working");
        }
        static void Main(string[] args)
        {
            accessspe a=new accessspe();
            a.TestPrivate();
            a.TestInternal();
            a.TestProtected();
            a.TestPretectedInternal();
            a.TestPublic();
        }

    }
}
