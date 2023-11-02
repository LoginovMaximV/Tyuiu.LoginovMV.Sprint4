using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint4.Task3.V10.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task3.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                                                                *");
            Console.WriteLine("* Задание #3                                                                                                 *");
            Console.WriteLine("* Вариант #10                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5на5 элементов,заполненный статическими значениями в диапазоне от 4до8  *");
            Console.WriteLine("* Найдите максимальный элемент в третьей строке массива.                                                     *");
            Console.WriteLine("* 5, 7, 6, 6, 5,                                                                                             *");
            Console.WriteLine("* 5, 5, 5, 4, 6,                                                                                             *");
            Console.WriteLine("* 8, 5, 7, 4, 7,                                                                                             *");
            Console.WriteLine("* 7, 6, 7, 4, 7,                                                                                             *");
            Console.WriteLine("* 5, 8, 7, 8, 8,                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            int[,] array = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                           { 5, 5, 5, 4, 6 },
                                           { 8, 5, 7, 4, 7 },
                                           { 7, 6, 7, 4, 7 },
                                           { 5, 8, 7, 8, 8 } };
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]} \t");
                }
            }
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Максимальный элемент в третьей строчке массива = " + res);
            Console.ReadKey();
        }
    }
}
