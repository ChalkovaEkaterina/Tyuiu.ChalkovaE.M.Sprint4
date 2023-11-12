using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ChalkovaE.M.Sprint4.Task6.V10.Lib;

namespace Tyuiu.ChalkovaE.M.Sprint4.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var words = new string[] { "Театр", "Кино", "Музей", "Парк", "Зоопарк", "Концерт", "Выставка" };
            string[] res = ds.Calculate(words);
            string[] wait = { "Театр", "Кино", "Музей", "Парк", };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
