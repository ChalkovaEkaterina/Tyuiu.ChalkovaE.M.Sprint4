using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int max = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (array[0, j] > max)
                    {
                        max = array[0, j];
                    }
                }
            }
            return max;
        }
    }
}
