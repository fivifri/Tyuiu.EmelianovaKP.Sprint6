using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Lib;

namespace Tyuiu.EmelianovaKP.Sprint6.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDataService()
        {
            DataService ds = new DataService();
            Assert.AreEqual("VAYYbnhDwTg sNnk CMmHkUlnNoZen nqrB", ds.CollectTextFromFile(@"C:\DataSprint6\InPutFileTask6V18.txt"));
        }
    }
}
