using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint6.Task2.V10.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            CollectionAssert.AreEqual(new double[] {-19.62, -17.12, -18.15, -63.13, -24.92, -5.00, -1.46, 1.57, 6.38, 32.78, 225.11}, ds.GetMassFunction(-5, 5));
        }
    }
}
