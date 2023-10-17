using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KasenovAE.Sprint2.Task1.V3.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetLogicOperations()
        {
            int a = 185;
            int b = 316;
            int c = 134;
            int d = 134;
            DataService ds = new DataService();
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] TestArray = new bool[6] { true, false, false, false, false, false };
            CollectionAssert.AreEqual(res, TestArray);
        }
    }
}
