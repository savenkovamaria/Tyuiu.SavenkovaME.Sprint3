using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task6.V27.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int start = 14;
            int stop = 20;
            int res = ds.GetSumTheDivisors(start, stop);
            int wait = 129;
            Assert.AreEqual(wait, res);
        }
    }
}
