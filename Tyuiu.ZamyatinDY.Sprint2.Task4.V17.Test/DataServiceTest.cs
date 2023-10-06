using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.InteropServices;
using Tyuiu.ZamyatinDY.Sprint2.Task4.V17.Lib;

namespace Tyuiu.ZamyatinDY.Sprint2.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            
            double x = 5;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 4.480;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()   
        {
            DataService ds = new DataService();

            double x = 25;
            double y = 4;
            double res = ds.Calculate(x, y);
            double wait = 1298.767;
            Assert.AreEqual(wait, res);
        }
    }
}
