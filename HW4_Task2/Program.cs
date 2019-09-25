using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();

            Console.ReadLine();
        }

        static int[] Create()
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

        static void BubbleSort()
        {
            int[] sortArray = Create();

            int count = 0;

            while (count < sortArray.Length)
            {
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        sortArray[i] = sortArray[i + 1] + sortArray[i];
                        sortArray[i + 1] = sortArray[i] - sortArray[i + 1];
                        sortArray[i] = sortArray[i] - sortArray[i + 1];
                    }
                }

                count++;
            }

            foreach (var item in sortArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
