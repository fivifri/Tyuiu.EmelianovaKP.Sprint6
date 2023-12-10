using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task7.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask7V18.csv";

            int[,] wait = { 
                { -12, -18, 16, 2, -20, 12, -15, -3, 11, -19 },
                { 15, 15, 12, 12, -1, -18, 10, -3, 11, -17 },
                { 6, 4, 11, 4, 8, 7, -13, 15, 11, -15 },
                { 10, 9, 7, 16, 12, 20, -12, -13, 11, -17 },
                { -11, -5, -9, 15, -5, 0, 6, 19, 11, 9 },
                { 13, 4, 10, 3, -20, 7, 0, 14, 11, 8 },
                { -18, -12, -6, -14, -12, -8, -17, -10, 11, 3 },
                { 15, -14, 10, -12, -18, 19, -8, 5, 11, -7 },
                { 10, 1, 4, 20, -11, 1, 18, 0, 11, -11 },
                { -12, 7, -18, -11, 8, -15, -2, 7, 11, 8 }
            };
            CollectionAssert.AreEqual(wait, ds.GetMatrix(path));
        }
    }
}
