using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task3.V7.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculate()
        {
            double x = 5;
            DataService ds = new DataService();
            var res = ds.Calculate(x);
            Assert.AreEqual(res, 58014.531);
        }
    }
}
