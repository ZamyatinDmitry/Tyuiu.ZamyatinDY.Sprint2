using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZamyatinDY.Sprint2.Task5.V12.Lib;
namespace Tyuiu.ZamyatinDY.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 2;
            int n = 2;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(1 + "." + 2 + "." + 2024);
            Assert.AreEqual(wait, res);
        }
    }
}
