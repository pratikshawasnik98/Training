using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6.online_testing;
namespace _6.online_testing_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program p = new Program();
            int res = p.first(10);
            int sol = p.second(20);
            int actual = sol;
            //int excepted = res;
            int except = res;
            Assert.AreEqual(actual, except);
        }
    }
}
