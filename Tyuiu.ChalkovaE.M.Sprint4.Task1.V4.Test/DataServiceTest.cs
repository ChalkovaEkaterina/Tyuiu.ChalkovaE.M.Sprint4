using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint4.Task1.V4.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task1.V4.Test
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
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
