using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint2.Task2.V28.Lib;
namespace Tyuiu.ZamyatinDY.Sprint2.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
