
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Practice_CountAlphaChar
    {
        public static void CtAlphaChar (string st)
            {
            int c1 = 0, c2 = 0, c3 = 0;
            for (int i = 0; i < st.Length; i++)
            {
                char c = st.ElementAt(i);
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    c1++;
                }
                else if (c >= '0' && c <= '9')
                {
                    c2++;
                }
                else
                {
                    c3++;
                }
            }
            Console.WriteLine($"Total Alphabets {c1} \nTotal Digits: {c2}\nTotal Special Charectes {c3}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string st = Console.ReadLine();
            CtAlphaChar(st);

        }
    }
}
