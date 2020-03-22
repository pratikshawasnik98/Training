using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _7.online;
namespace _7.online_testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int res = obj.power(3, 2);
            int actual = 9;
            int expected = res;
            Assert.AreEqual(actual, expected);
        }
    }
}
