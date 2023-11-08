using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LoginovMV.Sprint4.Task4.V11.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task4.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4| Выполнил: Логинов М.В | ИИПб-23-2";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #4                                                                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы. (Ввод с клавиатуры)                                                               *");
            Console.WriteLine("* Задание #4                                                                                                 *");
            Console.WriteLine("* Вариант #11                                                                                                *");
            Console.WriteLine("* Выполнил: Логинов М.В   | ИИПб-23-2                                                                        *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5на5 элементов,заполненный статическими значениями в диапазоне от 5до8  *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                                                                  *");
            Console.WriteLine("* 5, 7, 7, 8, 5,                                                                                             *");
            Console.WriteLine("* 6, 5, 6, 8, 6,                                                                                             *");
            Console.WriteLine("* 7, 6, 8, 8, 5,                                                                                             *");
            Console.WriteLine("* 7, 6, 7, 8, 6,                                                                                             *");
            Console.WriteLine("* 7, 6, 7, 7, 5,                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("Введите количество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("**************************************************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Результат:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();


        }
    }
}
