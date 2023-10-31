using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint4.Task1.V21.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] arrayNums = { 2, 4, 8, 5, 2, 6, 5, 8, 8, 6, 6 };

            var res = ds.Calculate(arrayNums);
            int wait = 1769472;

            Assert.AreEqual(wait, res);
        }
    }
}
