using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SavenkovaME.Sprint3.Task3.V4.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            char item = 'j';
            string value = "plkjjdw cvjkl";
            string res = ds.DeleteCharInString(value, item);
            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}
