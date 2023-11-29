using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EmelianovaKP.Sprint6.Task0.V6.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.866, ds.Calculate(3));
        }
    }
}
