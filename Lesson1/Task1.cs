using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson8.TestLib;

namespace Lesson1
{
    internal class Task1
    {

        /// <summary>
        /// Задание 1. Проверка: число простое или нет?
        /// </summary>
        

        /// <summary>
        /// Проверка, натуральное ли число?
        /// </summary>
        /// <param name="num">число, которое подается на вход</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static int NumIsNatural(int num) 
        {
            if (num<=0)
            {
                throw new ArgumentException($"{num} => Число должно быть натуральным ( > 0 )!");
            }
            return num;
        }

        /// <summary>
        /// Реализация алгоритма проверки числа: простое или нет?
        /// </summary>
        /// <param name="num">проверяемое число</param>
        static void SimpleNum(int num)
        {
            int d = 0, i = 2;
            try
            {
                NumIsNatural(num);
                {
                    while (i < num)
                    {
                        if (num % i == 0)
                        {
                            d++;
                        }

                        i++;
                    }
                    if (d == 0)
                    {
                        Console.WriteLine($"{num} => Число простое");
                    }
                    else
                    {
                        Console.WriteLine($"{num} => Число составное (не простое)");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main1(string[] args)
        {
            Console.Title = "Lesson 1, Task 1";

            SimpleNum(2); // проверки с простыми числами
            SimpleNum(97);
            SimpleNum(67);

            SimpleNum(45); //проверки с составными числами
            SimpleNum(15);

            SimpleNum(-1); //проверка с невалидным числом

            Console.ReadKey();
        }
    }
}
