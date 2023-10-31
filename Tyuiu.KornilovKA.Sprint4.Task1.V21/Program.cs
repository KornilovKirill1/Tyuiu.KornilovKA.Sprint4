using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KornilovKA.Sprint4.Task1.V21.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task1.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Корнилов К. А. | ИИПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Корнилов Кирилл Андреевич | ИИПб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать произведение   *");
            Console.WriteLine("* четных элементов массива. С клавиатуры: 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums = new int[11];

            for(int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write("Введите занчение " + i + " элемента массива: ");
                arrayNums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.Write("Массив: { ");
            for(int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write(arrayNums[i] + " ");
            }
            Console.WriteLine("}");
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Произведение четных элементов = " + ds.Calculate(arrayNums));

            Console.ReadLine();
        }
    }
}
