using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint4.Task3.V2.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Чалкова Е. М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                                  *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е. М. | ИИПб-23-2                                          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный статическими *");
            Console.WriteLine("* значениями в диапазоне от 2 до 8. Найдите максимальный элемент в первой      *");
            Console.WriteLine("* строке массива.                                                              *");
            Console.WriteLine("* 4, 3, 2, 8, 7,                                                               *");
            Console.WriteLine("* 4, 6, 5, 5, 7,                                                               *");
            Console.WriteLine("* 3, 8, 8, 3, 5,                                                               *");
            Console.WriteLine("* 5, 7, 5, 4, 4,                                                               *");
            Console.WriteLine("* 8, 8, 3, 7, 6,                                                               *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int[,] array = new int[5, 5] { { 4, 3, 2, 8, 7 }, { 4, 6, 5, 5, 7 }, { 3, 8, 8, 3, 5 }, { 5, 7, 5, 4, 4 }, { 8, 8, 3, 7, 6 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(array);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Максимальный элемент в первой строке массива = " + res);

            Console.ReadKey();
        }
    }
}
