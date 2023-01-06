using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Practice_DatePastToFuture
    {public static void PastFuture(DateTime dt)
        {
            for (int i = 1; i < 6; i++)
                Console.WriteLine($" {i} years Ago: {dt.AddYears(-i).ToShortDateString()}");
            Console.WriteLine("---------------------------------------------------------");
            for (int i = 1; i < 6; i++)
                Console.WriteLine($" {i} years in Future: {dt.AddYears(i).ToShortDateString()}"); 


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a date");
            //DateTime dt = DateTime.Now;
            DateTime dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            PastFuture(dt);





        }
    }
}
