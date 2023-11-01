using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint4.Task2.V20.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] arrayNums = { 2, 4, 7, 5, 2, 6, 5, 7, 7, 6, 3, 2, 5, 4, 6, 7 };

            var res = ds.Calculate(arrayNums);
            int wait = 32;

            Assert.AreEqual(wait, res);
        }
    }
}
