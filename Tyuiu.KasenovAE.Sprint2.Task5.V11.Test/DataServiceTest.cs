using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task5.V11.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfNextDay()
        {
            int g = 2023; int m = 12; int n = 31;
            DataService ds = new DataService();
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, "2024-1-1");
        }
    }
}
