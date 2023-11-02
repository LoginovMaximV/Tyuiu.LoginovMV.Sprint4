using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint4.Task2.V28.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 5, 3, 8, 2, 6, 2, 5, 5, 7, 4, 6 };
            int res = ds.Calculate(array);
            int wait = 25;
            Assert.AreEqual(wait, res);
        }
    }
}
