using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaE.M.Sprint4.Task5.V2.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнила: Чалкова Е.М. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                         *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #2                                                                   *");
            Console.WriteLine("* Выполнила Чалкова Е.М. | ИИПб-23-2                                           *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,заполненный случайными   *");
            Console.WriteLine("* значениями в диапазоне от -7 до 5. Найти количество отрицательных элементов. *");
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
                    mas[i, j] = rnd.Next(-7, 5);
                }

            }
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
            

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            int res = ds.Calculate(mas);
            Console.WriteLine("Количество отрицательных элементов = " + res);
            Console.ReadKey();
        }
    }
}
