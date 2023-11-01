using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint4.Task2.V19.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] nums = { 1, 3, 6, 4, 8 };

            int res = ds.Calculate(nums);
            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
