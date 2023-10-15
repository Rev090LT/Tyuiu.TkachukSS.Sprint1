using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint1.Task4.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = (x + Math.Pow(y, 2)) / Math.Exp(2 - 4 * y);
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
