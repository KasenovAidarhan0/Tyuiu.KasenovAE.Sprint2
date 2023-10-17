using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task2.V2.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckDotInShadedAreaValid()
        {
            int x = 7;
            int y = 9;
            DataService ds = new DataService();
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, true);
        }
    }
}
