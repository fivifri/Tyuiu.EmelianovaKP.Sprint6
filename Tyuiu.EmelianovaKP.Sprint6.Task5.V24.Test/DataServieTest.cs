using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.EmelianovaKP.Sprint6.Task5.V24.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServieTest
    {
        [TestMethod]
        public void ValidDataService()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask5V24.txt";

            CollectionAssert.AreEqual(new double[] { 0, 0 }, ds.LoadFromDataFile(path));
        }
    }
}
