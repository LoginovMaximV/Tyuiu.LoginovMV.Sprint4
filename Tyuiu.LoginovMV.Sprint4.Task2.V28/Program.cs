using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint4.Task2.V28.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы(генератор случайных чисел)                                                        *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #28                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный значениями с клавиатуры в диапазоне        *");
            Console.WriteLine("* от 2 до 9 подсчитать сумму нечетных элементов массива.                                                     *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int len;
            Random rnd = new Random();
            Console.Write("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2, 10);
            }
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
