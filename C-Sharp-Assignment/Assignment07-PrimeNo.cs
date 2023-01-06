using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SampleConsleApp
{
    class primenumber
    {
        public static bool isPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else if (num == 2 || num == 3 || num == 5)
                return true;

            else if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0)
            {
                return false;
            }
            else
            {
                for (int i = 5; i <= Math.Sqrt(num); i += 5)
                {
                    if (num % i == 0 || num % (i + 2) == 0)
                    { return false; }
                }
                return true;
            }
        }
    }
    class Assignment07_PrimeNo
    {
        static void Main(string[] args)
        {
           
            do
            {
                Console.WriteLine("enter the number to check prime number");
                int num;
                if(!int.TryParse(Console.ReadLine(), out num))
                    break;

                string res = primenumber.isPrimeNumber(num) ? "Prime Number" : "Not a Prime Number";
                Console.WriteLine($"{num} is {res}");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                Console.Clear();
            } while (true);
        }
    }
}






