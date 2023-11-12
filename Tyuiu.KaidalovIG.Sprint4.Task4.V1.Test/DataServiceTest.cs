using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint4.Task4.V1.Lib;

namespace Tyuiu.KaidalovIG.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = new int[5, 5]{{6, 6, 5, 3, 3 },

                                        { 5, 7, 4, 6, 4 },

                                        { 1, 2, 4, 1, 5 },

                                        { 1, 7, 2, 5, 7 },

                                        { 4, 2, 6, 5, 6 }
            };
            int[,] wait = new int[5, 5]{{6, 6, 0, 0, 0 },

                                        { 0, 0, 4, 6, 4 },

                                        { 0, 2, 4, 0, 0 },

                                        { 0, 0, 2, 0, 0 },

                                        { 4, 2, 6, 0, 6 }
            };
            int[,] result = ds.Calculate(array);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
