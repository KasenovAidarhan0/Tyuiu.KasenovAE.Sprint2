using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task0.V20.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetCompareOperations()
        {
            int x = 1075;
            int y = 275;
            DataService ds = new DataService();
            var res = ds.GetCompareOperations(x, y);
            bool[] TestArray = new bool[6] { true, false, true, false, true, false };
            CollectionAssert.AreEqual(res, TestArray);
        }
    }
}
