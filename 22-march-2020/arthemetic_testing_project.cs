using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using arthemetic_testing;

namespace arthemetic_testing_project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void add_TestMethod1()
        {
            BasicMethod bm = new BasicMethod();
            double res = bm.add(10, 10);
            Assert.AreEqual(res, 20);
        }
        public void subtract_TestMethod1()
        {
            BasicMethod bm = new BasicMethod();
            double res = bm.subtract(20, 10);
            double actual = 10;
            double expected = res;
            Assert.AreEqual(expected,actual);
        }
    }
}
