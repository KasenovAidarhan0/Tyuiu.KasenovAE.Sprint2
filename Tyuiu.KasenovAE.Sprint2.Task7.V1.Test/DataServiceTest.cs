using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task7.V1.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(0.25, 0.5);
            Assert.AreEqual(res, true);
        }
    }
}
