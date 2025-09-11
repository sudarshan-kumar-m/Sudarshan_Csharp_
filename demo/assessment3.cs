using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class assessment3
    {
        static void Main()
        {

            string output = "";
            Console.Write("Enter the string:");
            string s=Console.ReadLine();
            int[] arr = new int[s.Length+1];
            arr[0] = 0;
            for (int i=0;i<s.Length;i++)
            {
                if(s[i]>='a' && s[i]<='o')
                {
                    int a = Convert.ToInt32(s[i])-'a' + 1;
                    //Console.WriteLine(a);
                    int rem = a % 3;
                    int n = rem;
                    if(n == 0)
                    {
                        rem = 3;
                    }
                    int div = a / 3;
                    if(n == 0)
                    {
                        div = div - 1;
                    }
                    arr[i+1]= div+2;
                    if (arr[i + 1] == arr[i])
                    {
                        output = output + '_';
                    }
                    for(int j=0;j<rem;j++)
                    {
                        output = output + (div+2);
                    }
                }
                else if (s[i] >= 'p' && s[i] <= 'v')
                {
                    int a = Convert.ToInt32(s[i]) - 'a' + 1;
                    int rem = a % 4;

                    int div = a / 4;
                    arr[i + 1] = div + 3;
                    if (arr[i + 1] == arr[i])
                    {
                        output = output + '_';
                    }
                    for (int j = 0; j < rem+1; j++)
                    {
                        output = output + (div + 3);
                    }

                }
                else if(s[i] >='w' &&  s[i] <='z')
                {
                    int a = Convert.ToInt32(s[i]) - 'a' + 1;
                    int rem = a %11;
                    int div = a / 11;
                    arr[i + 1] = div + 7;
                    if (arr[i + 1] == arr[i])
                    {
                        output = output + '_';
                    }
                    for (int j = 0; j < rem; j++)
                    {
                        output = output + (div + 7);
                    }
                }
                else
                {
                    output = output + 0;
                }
                
            }
            Console.WriteLine(output);
        }



    }
}
