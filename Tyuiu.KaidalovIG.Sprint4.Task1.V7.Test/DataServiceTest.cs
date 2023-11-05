using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint4.Task1.V7.Lib;

namespace Tyuiu.KaidalovIG.Sprint4.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 6, 9, 6, 9, 3, 8, 2, 9, 5, 7, 4 };
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(32, res);
        }
    }
}
