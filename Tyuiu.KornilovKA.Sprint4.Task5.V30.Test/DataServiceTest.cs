using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint4.Task5.V30.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] arrayNums = new int[5, 5] { { 2, -1, 1, 2, 2 },
                                               { 0, 2, 3, -2, 4 },
                                               { 2, 2, 2, -1, 0 },
                                               { -2, 2, 4, 3, 2 },
                                               { 1, -1, 2, -1, 4 } };
            int res = ds.Calculate(arrayNums);
            int wait = 40;

            Assert.AreEqual(wait, res);
        }
    }
}
