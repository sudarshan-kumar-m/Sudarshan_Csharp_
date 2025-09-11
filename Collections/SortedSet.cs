using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SortedSetProgramme
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 100,20, 10, 30, 10 };
            a.Add(5);
            a.Remove(30);
            a.Add(65);
            a.RemoveWhere(x => x > 55);
            foreach (int b in a)
            {
                Console.WriteLine(b);
            }
        }
    }
}
