using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task2
{
    class Sort
    {
        public static void BubbleSort()
        {
            int[] sortArray = Create.CreateArray();
            for (int j = sortArray.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        sortArray[i] = sortArray[i + 1] + sortArray[i];
                        sortArray[i + 1] = sortArray[i] - sortArray[i + 1];
                        sortArray[i] = sortArray[i] - sortArray[i + 1];
                    }
                }
            }

            foreach (var item in sortArray)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
