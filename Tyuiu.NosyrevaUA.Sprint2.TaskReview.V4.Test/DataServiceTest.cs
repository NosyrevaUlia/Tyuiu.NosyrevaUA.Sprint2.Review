using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosyrevaUA.Sprint2.TaskReview.V4.Lib;

namespace Tyuiu.NosyrevaUA.Sprint2.TaskReview.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.2;
            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), false);
        }
    }
}
