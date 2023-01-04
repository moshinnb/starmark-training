
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Assignment03
    {
        static int Calc(int a, int b, char operate)
        {
            switch (operate)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter 1'st value ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter any one opreator '+ - * / ' ");
                char operate = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2'nd value ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your result is here: " + Calc(a, b, operate));
                Console.WriteLine("press q to exit else press any key to continue\n");
            } while (Console.ReadLine() != "q");
        }
    }
}
