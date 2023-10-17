using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task4.V23.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate0()
        {
            double x = 2;
            double y = 9;
            DataService ds = new DataService();
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, 32.5);
        }
        [TestMethod]
        public void CheckCalculate1()
        {
            double x = 1;
            double y = 9;
            DataService ds1 = new DataService();
            var res = ds1.Calculate(x, y);
            Assert.AreEqual(res, 1.012);
        }
    }
}
