using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KornilovKA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Корнилов К. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Корнилов Кирилл Андреевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("* 4, 3, 5, 5, 3,                                                          *");
            Console.WriteLine("* 6, 7, 4, 4, 3,                                                          *");
            Console.WriteLine("* 3, 3, 7, 3, 6,                                                          *");
            Console.WriteLine("* 3, 4, 3, 7, 7,                                                          *");
            Console.WriteLine("* 3, 5, 6, 3, 6,                                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] arrayNums = new int[5, 5] { { 4, 3, 5, 5, 3 },
                                               { 6, 7, 4, 4, 3 },
                                               { 3, 3, 7, 3, 6 },
                                               { 3, 4, 3, 7, 7 },
                                               { 3, 5, 6, 3, 6 } };

            Console.WriteLine("Массив:");
            for (int i = 0; i < arrayNums.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNums.GetLength(1); j++)
                {
                    Console.Write($"{arrayNums[i,j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество четных элементов = " + ds.Calculate(arrayNums));

            Console.ReadLine();
        }
    }
}
