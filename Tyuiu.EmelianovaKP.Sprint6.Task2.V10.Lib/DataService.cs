using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.EmelianovaKP.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] y = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; ++x)
            {
                y[count] = Math.Round(2.0 * x - 4 + (2.0 * x - 1) / (Math.Sin(x) + 1), 2);
                if (double.IsInfinity(y[count]) || double.IsNaN(y[count]))
                {
                    y[count] = 0;
                }
                ++count;
            }

            return y;
        }
    }
}
