using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TkachukSS.Sprint1.Task2.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 2;
            int c = 2;
            var res = ds.CalculateAVGValue(a,b,c);
            Assert.AreEqual(8,res);
        }
    }
}
