using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint6.Task4.V8.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            CollectionAssert.AreEqual(new double[] { -8.86, -7.19, -6.14, -4.76, -2.33, 1.00, 4.38, 0, 6.13, 7.07, 8.61}, ds.GetMassFunction(-5, 5));
        }
    }
}
