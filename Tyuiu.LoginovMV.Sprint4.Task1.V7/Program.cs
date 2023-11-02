using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint4.Task1.V7.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Одномерные массивы(ввод с клавиатуры)                                                                *");
            Console.WriteLine("* Задание #1                                                                                                 *");
            Console.WriteLine("* Вариант #7                                                                                                 *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный значениями с клавиатуры в диапазоне        *");
            Console.WriteLine("* от 1 до 8 подсчитать сумму четных элементов массива.  С клавиатуры: 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int len;
            Console.Write("Введите количество элементов массива:");
            len = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива ");
                array[i] = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("Сумма элементов массива = " + res);
            Console.ReadKey();

        }
    }
}
