using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    

    class Assignment06_DateValidation
    {
        static bool isValidDate(int year, int month, int day)
        {
            try {
                new DateTime(year, month, day);
                return true;
            }
            catch
            {
                return false;
            }
           
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("2018,13,1--->   " + isValidDate(2018,13,1));
            Console.WriteLine("2018, 2, 29-->  " + isValidDate(2018, 2, 29));
            Console.WriteLine("2016, 2, 29-->  " + isValidDate(2016, 2, 29));
            
        }
    }
}
