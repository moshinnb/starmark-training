using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Assignment09ReverseByWord
    {
        public static string Reverse(string Input)
        {   char[] charArray = Input.ToCharArray();
            string reversedString = String.Empty;
            int length, index;
            length = charArray.Length - 1;
            index = length;
            while (index > -1)
            {   reversedString = reversedString + charArray[index];
                index--;
            }
            return reversedString;
        }
        public static string reverseByWords(string sentence)
        {   if (sentence != " ")
            {
                var original = sentence.Split(' ');
                var k = "";
                for (int i = 0; i < original.Length; i++)
                {
                    k += Reverse(original[i]) + " ";
                }
                return Reverse(k).TrimStart();
            }
            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence want to reverse by word");
            string inputString = Console.ReadLine();
            Console.WriteLine(reverseByWords(inputString));
        }
    }
}
