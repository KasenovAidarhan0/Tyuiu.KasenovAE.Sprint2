using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindCardNameAndValue()
        {
            int m = 1;
            int k = 6;
            DataService ds = new DataService();
            var res = ds.FindCardNameAndValue(m, k);
            Assert.AreEqual(res, "Шестёрка пик");
        }
    }
}
