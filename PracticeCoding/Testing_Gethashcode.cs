using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class Testing_Gethashcode
    {
        public int Id;
        public override int GetHashCode()
        {
            Console.WriteLine($"GetHashCode called for Id = {Id}");
            return Id % 10;
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine($"Equals called: this.Id = {Id}, other.Id = {(obj as Testing_Gethashcode)?.Id}");
            return (obj is Testing_Gethashcode other) && this.Id == other.Id;
        }
        static void Main()
        {
            var dict = new Dictionary<Testing_Gethashcode, string>();
            Testing_Gethashcode a1 = new Testing_Gethashcode() { Id = 10 };
            Testing_Gethashcode a2 = new Testing_Gethashcode() { Id = 20 };
            dict.Add(a1, "Ten");
            dict.Add(a2, "Twenty");
            foreach (KeyValuePair<Testing_Gethashcode, string> k in dict)
            {
                Console.WriteLine(k.Key + " " + k.Value);
            }
            Console.WriteLine(a1.GetHashCode());
            Console.WriteLine(a2.GetHashCode());
        }
    }
}
