using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.EmelianovaKP.Sprint6.Task3.V25.Lib
{
    public class DataService : ISprint6Task3V25
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] column = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                column[i] = matrix[i, 2];
            }

            Array.Sort(column);

            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                matrix[i, 2] = column[i];
            }

            return matrix;
        }
    }
}
