using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _8.online;
namespace _8.online_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program obj = new Program();
            int res = obj.fibo(5);
            int actual = 0;
            Assert.AreEqual(res, actual);
        }
    }
}
