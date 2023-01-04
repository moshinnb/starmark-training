using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsleApp
{
    class Assignment04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of Aray");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the CTS equilavent name for the type of Arry u want to create");
            string typeName = Console.ReadLine();
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value of the type {type.Name}");
                string enteredValue = Console.ReadLine();
                object convertedValue = Convert.ChangeType(enteredValue, type);
                myArray.SetValue(convertedValue, i);

            }
            Console.WriteLine("All the values are set");
            foreach (object item in myArray)
                Console.WriteLine(item);
            {

            }
        }
    }
}
