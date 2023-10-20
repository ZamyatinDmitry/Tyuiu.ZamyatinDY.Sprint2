using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint2.Task6.V13.Lib;
namespace Tyuiu.ZamyatinDY.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 2020;
            int m = 2;
            int n = 28;
            var res = ds.FindDateOfNextDay(g, m, n);
            double wait = 20200229;
            Assert.AreEqual(wait, res);
        }
    }
}
