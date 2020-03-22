using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using amstrong;
namespace amstrong_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int res = p.ams(1234);
            int actual = 4321;
            int expected = res;
            Assert.AreEqual(expected, actual);
        }
    }
}
