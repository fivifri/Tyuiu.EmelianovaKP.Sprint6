using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.EmelianovaKP.Sprint6.Task1.V29.Lib
{
    public class DataService : ISprint6Task1V29
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vallueArray;
            int len = (stopValue - startValue) + 1;
            vallueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1 == 0)
                {
                    vallueArray[count] = 0;
                    count++;
                }
                else
                {
                    vallueArray[count] = Math.Round(Math.Cos(x) / (x + 1.0) - Math.Cos(x) * 1.3 + 3 * x, 2);
                    ++count;
                }
            }
            return vallueArray;
        }
    }
}
