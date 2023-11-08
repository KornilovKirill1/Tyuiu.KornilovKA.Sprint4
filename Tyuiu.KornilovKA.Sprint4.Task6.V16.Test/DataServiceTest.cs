using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint4.Task6.V16.Lib;

namespace Tyuiu.KornilovKA.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] transportArray = { "Автомобиль", "Велосипед", "Самолет", "Поезд", "Трамвай", "Троллейбус", "Метро" };
            var res = ds.Calculate(transportArray);

            string[] wait = { "Автомобиль", "Велосипед", "Троллейбус" };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
