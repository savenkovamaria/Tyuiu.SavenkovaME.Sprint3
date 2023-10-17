using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task1.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int start = 1;
            int stop = 10;
            double res = ds.GetMultiplySeries(start, stop);
            double wait = 3.195;
            Assert.AreEqual(wait, res);
        }
    }
}
