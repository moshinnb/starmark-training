using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Practice_ToggoleCasingInput
    {public static void ToggoleCase(string st)
        {
            string s = "";
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] >= 'A' && st[i] <= 'Z')
                   s+=(char)((int)st[i]-65+97);
                else if (st[i] >= 'a' && st[i] <= 'z')
                    s += (char)((int)st[i] + 65 - 97);
                else
                    s += st[i];
            }
            Console.WriteLine(s);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string st = Console.ReadLine();
            ToggoleCase(st);

        }
    }
}
