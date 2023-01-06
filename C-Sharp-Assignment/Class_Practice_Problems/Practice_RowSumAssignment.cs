
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Practice_RowSumAssignment
    {
        public static void rowSum(int [,] arr)
        {
            
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int res = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                    res += arr[i,j];

                }
                Console.WriteLine(res);


            }
        }
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            rowSum(arr);

        }
      
    }
}
