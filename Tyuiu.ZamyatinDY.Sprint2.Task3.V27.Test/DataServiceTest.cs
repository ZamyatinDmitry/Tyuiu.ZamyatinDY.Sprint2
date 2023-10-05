using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZamyatinDY.Sprint2.Task3.V27.Lib;
namespace Tyuiu.ZamyatinDY.Sprint2.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresion1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2.005;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpresion2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.250;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpresion3()
        {
            DataService ds = new DataService();
            double x = -20;
            double res = ds.Calculate(x);
            double wait = 1.005;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidExpresion4()
        {
            DataService ds = new DataService();
            double x = -32;
            double res = ds.Calculate(x);
            double wait = -32798.961;
            Assert.AreEqual(wait, res);
        }
    }
}
