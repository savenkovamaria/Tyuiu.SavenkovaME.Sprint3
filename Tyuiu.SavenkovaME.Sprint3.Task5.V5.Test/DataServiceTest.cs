using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task5.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int start1 = 1;
            int start2 = 1;
            int stop1 = 3;
            int stop2 = 10;
            double res = ds.GetSumSumSeries(x, start1, start2, stop1, stop2);
            double wait = 98.286;
            Assert.AreEqual(wait, res);
        }
    }
}
