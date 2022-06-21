using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Task2
    {
        /// <summary>
        /// Задание 2. Посчитайте асимптотическую сложность функции.
        /// </summary>

        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)         // O(n)
            {
                for (int j = 0; j < inputArray.Length; j++)     // O(n)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(n)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;                          // O(1)
                        }
                        sum += inputArray[i] + i + k + j + y;   // O(1)
                    }
                }
            }
            return sum;  // O(1)
        }
    }
}
        // Ответ: сложность функции O( n*(n*(n*1*1))+1 ) = O(n^3)
