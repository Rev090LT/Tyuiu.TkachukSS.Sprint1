using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint1.Task3.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Validation()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 7;
            double wait = 35;
            var res = ds.HowManySquares(x, y, z);
            Assert.AreEqual(wait, res);
        }
    }
}
