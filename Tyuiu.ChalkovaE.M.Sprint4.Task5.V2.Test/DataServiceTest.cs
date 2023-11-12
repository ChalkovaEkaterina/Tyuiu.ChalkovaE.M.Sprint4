using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint4.Task5.V2.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5] { { 5, -6, 1, 2, -6 }, { 4, 3, -4, 2, -4 }, { 5, 1, 5, 3, 5 }, { -4, 4, -5, 3, 5 }, { -6, 3, 5, 4, 2 } };
            
            int res = ds.Calculate(mas);
            int wait = 7;
            Assert.AreEqual(wait, res);
        }
    }
}
