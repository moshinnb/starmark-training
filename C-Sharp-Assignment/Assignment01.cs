using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Assignment01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Byte max: " + Byte.MaxValue);//255
            Console.WriteLine("Byte min: " + Byte.MinValue);//0
            Console.WriteLine();
            //Console.WriteLine(SByte.MaxValue);//127
            //Console.WriteLine(SByte.MinValue);//-128
            Console.WriteLine("Short Int max: " + Int16.MaxValue);//32767
            Console.WriteLine("Short Int min: " + Int16.MinValue);//-32768
            Console.WriteLine();
            Console.WriteLine("Int max: " + Int32.MaxValue);//2147483647
            Console.WriteLine("Int min: " + Int32.MinValue);//-2147483648
            Console.WriteLine();
            Console.WriteLine("Long max: " + Int64.MaxValue);//9223372036854775807
            Console.WriteLine("Long min: " + Int64.MinValue);//-9223372036854775808
            Console.WriteLine();
            Console.WriteLine("Float max: " + float.MaxValue);
            Console.WriteLine("Float min: " + float.MinValue);
            Console.WriteLine();
            Console.WriteLine("Double max: " + double.MaxValue);
            Console.WriteLine("Double min: " + double.MinValue);


        }
    }
}
