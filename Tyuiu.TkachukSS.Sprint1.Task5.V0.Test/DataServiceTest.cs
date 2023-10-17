using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint1.Task5.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            int k = 23, wait = 2, res = dataService.Calculate(k);
            Assert.AreEqual(wait, res);
        }
    }
}
