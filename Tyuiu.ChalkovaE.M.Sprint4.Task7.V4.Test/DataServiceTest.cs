using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint4.Task7.V4.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            DataService ds = new DataService();
            string value = "382976421897";
            int res = ds.Calculate(n, m, value);
            int wait = 36;
            Assert.AreEqual(wait, res);
        }
    }
}
