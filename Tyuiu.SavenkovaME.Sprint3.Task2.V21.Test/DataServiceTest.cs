using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task2.V21.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int start = 1;
            int stop = 10;
            double res = ds.GetSumSeries(value, start, stop);
            double wait = 0.298;
            Assert.AreEqual(wait, res);
        }
    }
}
