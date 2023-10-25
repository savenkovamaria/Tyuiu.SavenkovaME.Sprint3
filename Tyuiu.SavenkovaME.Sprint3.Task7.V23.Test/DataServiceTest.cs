using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task7.V23.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int start = -5;
            int stop = 5;
            int len = stop - start + 1;
            double[] wait = new double[len];
            wait[0] = 13.81;
            wait[1] = 11.87;
            wait[2] = 9.87;
            wait[3] = 7.74;
            wait[4] = 5.36;
            wait[5] = 2.50;
            wait[6] = 0.00;
            wait[7] = 0.79;
            wait[8] = -1.75;
            wait[9] = -3.78;
            wait[10] = -5.71;
            double[] res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
