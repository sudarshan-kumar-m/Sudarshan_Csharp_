using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCoding
{
    internal class Question1
    {
        public static string Rever(string m)
        {
            //Spliting into words and adding to the List
            List<string> str = new List<string>();
            string k = "";
            for(int i = 0; i<m.Length;i++)
            {
                if (m[i] != ' ')
                {
                    k += m[i];
                    if (i == m.Length - 1)
                    {
                        //Console.WriteLine(k);
                        str.Add(k);
                    }
                }
                else
                {
                    //Console.WriteLine(k);
                    str.Add(k);
                    k = "";
                }
                    
            }

            
            //string[] p=m.Split(' ');
            //string s = "";
            //string q = "";
            //Console.WriteLine(p.Length);
            //for(int i=0;i<p.Length; i++)
            //{
            //    //Console.WriteLine(p[i]+" "+i);
            //    //Console.WriteLine(p[i].Length);
            //    for (int j = p[i].Length - 1; j > -1; j--)
            //    {
            //        s += p[i][j];

            //    }
            //    q += s;
            //    q = q + " ";
            //    s = "";
            //    //Console.WriteLine(q+"...........................................");
            //}
            //return q;




            
            string s = "";
            string q = "";
            //Console.WriteLine(str.Count);
            for(int i=0;i< str.Count; i++)
            {
                
                for (int j = str[i].Length - 1; j > -1; j--)
                {
                    s += str[i][j];

                }
                q += s;
                q = q + " ";
                s = "";
                
            }
            return q;
        }
        static void Main()
        {
            List<string> list = new List<string>()
            {
                "Hi Hello",
                "How are you",
                "Abhish Games"
            };
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
            for(int i=0;i<list.Count;i++)
            {
                
                list[i] = Rever(list[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Final Answer");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}
