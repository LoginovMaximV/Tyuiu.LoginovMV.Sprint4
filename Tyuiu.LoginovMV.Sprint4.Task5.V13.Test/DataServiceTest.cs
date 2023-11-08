using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint4.Task5.V13.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5] { { -2, -1, 0, 1, 2 },
                                           { 3, 4, 5, -2, -1 },
                                           { 0, 1, 2, 3, 4 },
                                           { 5, -2, -1, 0, 1 },
                                           { 2, 3, 4, 5, -2 } };
            int[,] res = ds.Calculate(array);
            int[,] wait = new int[5, 5] { { 0, 0, 0, 1, 2 },
                                           { 3, 4, 5, 0, 0 },
                                           { 0, 1, 2, 3, 4 },
                                           { 5, 0, 0, 0, 1 },
                                           { 2, 3, 4, 5, 0 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
