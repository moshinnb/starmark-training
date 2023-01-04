
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Assignment02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of input");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            string even = "";
            string odd = "";
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i+1} input");
                a[i] = Convert.ToInt32(Console.ReadLine());
                if(a[i]%2==0)
                {
                    even += a[i] + " ";
                }
                else
                {
                    odd += a[i] + " ";
                }
                
            }
            Console.WriteLine("even no:"+even);
            Console.WriteLine("odd no:" + odd);

        }
    }
}
