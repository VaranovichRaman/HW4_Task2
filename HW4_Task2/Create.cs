using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task2
{
    class Create
    {
        public static int[] CreateArray()
        {
            Random numbers = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = numbers.Next(0, 100);
            }

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\n");

            return array;
        }
    }
}
