using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Practice_TransposeOfMatrix
    {
       
        public static void Transpose(int [,] array)

        {
            for (int i=0;i<array.GetLength(0);i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[j, i]);
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };
            Transpose(arr);

        }
    }
}
