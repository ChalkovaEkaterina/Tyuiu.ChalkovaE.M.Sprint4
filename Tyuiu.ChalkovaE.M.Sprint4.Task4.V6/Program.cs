using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint4.Task4.V6.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task4.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Чалкова Е.М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #4                                                                   *");
            Console.WriteLine("* Вариант #6                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е.М. | ИИПб-23-2                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный значениями с *");
            Console.WriteLine("* клавиатуры в диапазоне от 4 до 9. Найдите сумму четных элементов массива.    *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("* 7, 6, 6, 6, 9,                                                               *");
            Console.WriteLine("* 4, 4, 4, 9, 4,                                                               *");
            Console.WriteLine("* 5, 5, 5, 6, 5,                                                               *");
            Console.WriteLine("* 4, 9, 5, 9, 7,                                                               *");
            Console.WriteLine("* 6, 9, 5, 6, 7,                                                               *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            int rows;
            Console.Write("Введите количество строк: ");
            rows = Convert.ToInt32(Console.ReadLine());
            int columns;
            Console.Write("Введите количество столбцов: ");
            columns = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"Введите значение {i},{j} элемента: ");
                    mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(mas[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] res = ds.Calculate(mas);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mas[i, j] % 2 != 0)
                    {
                        mas[i, j] = 0;
                    }
                    else
                    {
                        mas[i, j] = mas[i, j];
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(res[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
