using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task0.V12.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int stopValue = 13;
            int startValue = 1;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
