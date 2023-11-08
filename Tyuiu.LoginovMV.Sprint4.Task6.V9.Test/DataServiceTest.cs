using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LoginovMV.Sprint4.Task6.V9.Lib;

namespace Tyuiu.LoginovMV.Sprint4.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = new string[] { "Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый" };
            int res = ds.Calculate(array);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
