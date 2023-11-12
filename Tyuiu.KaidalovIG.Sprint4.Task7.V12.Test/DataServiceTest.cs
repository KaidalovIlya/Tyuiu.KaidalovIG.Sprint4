using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint4.Task7.V12.Lib;

namespace Tyuiu.KaidalovIG.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int rows = 5;
            int column = 3;
            string str = "145258749635789";
            int res = ds.Calculate(rows, column, str);
            int wait = 12288;
            Assert.AreEqual(wait, res);
        }
    }
}
